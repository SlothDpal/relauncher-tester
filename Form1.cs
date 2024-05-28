using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using relauncher_test.Properties;

namespace relauncher_test
{
    public partial class Form1 : Form
    {
        private string[] cmdArgs;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private bool terminateApplicationCancel = false;

        public Form1()
        {            
            InitializeComponent();
            cmdArgs = Environment.GetCommandLineArgs();
            statusLabel.Text = "Args: ";
            if (cmdArgs.Length>1)
                for ( int i = 1; i < cmdArgs.Length; i++ )
                { 
                    statusLabel.Text += cmdArgs[i] + " "; 
                }
            labelAvailableProcessors.Text += Environment.ProcessorCount;
            numericTasks.Value = Environment.ProcessorCount;
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHandledException_Click(object sender, EventArgs e)
        {
            if (checkExceptionTimer.Checked)
            {
                int tick = (int)numericExceptionTimer.Value;
                buttonHandledException.Enabled = false;
                buttonUnhandledException.Enabled = false;
                while (tick > 0 )
                {
                    statusLabel.Text = $"Обрабатываемое исключение через {tick} сек.";
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    tick--;
                }
                statusLabel.Text = $"";
                buttonHandledException.Enabled = true;
                buttonUnhandledException.Enabled = true;
            }

            try
            {
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Обработали DivideByZeroException.","Исключение",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonUnhandledException_Click(object sender, EventArgs e)
        {
            if (checkExceptionTimer.Checked)
            {
                int tick = (int)numericExceptionTimer.Value;
                buttonHandledException.Enabled = false;
                buttonUnhandledException.Enabled = false;
                while (tick > 0)
                {
                    statusLabel.Text = $"Необрабатываемое исключение через {tick} сек.";
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    tick--;
                }
                statusLabel.Text = $"";
                buttonHandledException.Enabled = true;
                buttonUnhandledException.Enabled = true;
            }
            throw new DivideByZeroException();
        }

        private void buttonBusyUI_Click(object sender, EventArgs e)
        {
            statusLabel.Text = $"Подвешиваем UI на {((int)uiFreezeTime.Value)} сек.";
            Application.DoEvents();
            Thread.Sleep((int)uiFreezeTime.Value*1000);
            statusLabel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process currProcess = Process.GetCurrentProcess();
            statusLabel.Text= currProcess.MainModule.FileName;
            Process.Start(currProcess.MainModule.FileName,"-fork");
            Application.DoEvents();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Исполняемые файлы (*.exe)|*.exe";
            openFile.Title = "Укажите программу запуска";

            if (openFile.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Process.Start(openFile.FileName,"");
            Application.DoEvents();
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            foreach (string cmd in cmdArgs)
            {
                if (cmd == "-fork") { MessageBox.Show("Запустили сами себя!", "Форк", MessageBoxButtons.OK, MessageBoxIcon.Information); break; }
            }
        }

        private async void buttonRunTasks_Click(object sender, EventArgs e)
        {
            List<Thread> tasks = new List<Thread>();

            cancellationTokenSource.Dispose();
            cancellationTokenSource=new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
            statusLabelTasks.Text = $"Запускаем задачи: ";
            buttonCancelTasks.Enabled = true;
            buttonRunTasks.Enabled = false;
            Application.DoEvents();
            for (int i=0; i < (int)numericTasks.Value; i++)
            {
                tasks.Add(new Thread(() => { TaskForRun((int)numericTaskRuntime.Value * 1000); }));
                tasks[i].IsBackground = true;
                tasks[i].Start();
            }
            await Task.Run(() =>
                {
                    foreach (Thread curtask in tasks)
                    {
                        while (curtask.ThreadState != System.Threading.ThreadState.Stopped) { }
                    }
                    Thread.Sleep(1000);
                    buttonRunTasks.Invoke( (MethodInvoker) (()=> { buttonRunTasks.Enabled = true; }) );
                    buttonCancelTasks.Invoke( (MethodInvoker) (() => { buttonCancelTasks.Enabled = false; }) );
                    statusLabelTasks.Text = "";
                });
        }

        private void TaskForRun (object threadData)
        {
            int taskRuntime = (int)threadData;
            Stopwatch runtime = new Stopwatch();
            Random rand = new Random();

            statusStrip2.Invoke((MethodInvoker)(() => { statusLabelTasks.Text += "+"; }) );
            runtime.Start();
            while ( ( runtime.ElapsedMilliseconds < taskRuntime ) && ( !cancellationToken.IsCancellationRequested ) )
            {
                    double a = 6*Math.Sin(2 * Math.PI * (rand.NextDouble() - 0.5))/7+3*Math.Sqrt(rand.NextDouble()); // что-то делаем
            }
            runtime.Stop();
            statusStrip2.Invoke((MethodInvoker)(() => { statusLabelTasks.Text += "-"; }) );
        }

        private void buttonCancelTasks_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
            buttonRunTasks.Enabled = false;
            buttonCancelTasks.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ( e.CloseReason == CloseReason.ApplicationExitCall)
            {
                cancellationTokenSource.Dispose();
            }
        }

        private async void buttonSelfTerminate_Click(object sender, EventArgs e)
        {
            
            buttonSelfTerminate.Enabled = false;
            buttonCancelTerminate.Visible = true;
            await Task.Run(() =>
            {
                int tick = (int)numericSelfTerminate.Value;
                while ( (tick > 0) && (!terminateApplicationCancel) )
                {
                    statusStrip1.Invoke((MethodInvoker)(()=> { statusLabel.Text = $"Приложение закрывавется через {tick} сек."; }));
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    tick--;
                }
            });
            statusLabel.Text = $"";
            buttonSelfTerminate.Enabled = true;
            buttonCancelTerminate.Visible = false;
            if (!terminateApplicationCancel)Application.Exit();
            terminateApplicationCancel = false;
        }

        private void buttonCancelTerminate_Click(object sender, EventArgs e)
        {
            terminateApplicationCancel = true;
        }
    }
}
