namespace relauncher_test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.buttonHandledException = new System.Windows.Forms.Button();
            this.buttonUnhandledException = new System.Windows.Forms.Button();
            this.buttonBusyUI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiFreezeTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonFork = new System.Windows.Forms.Button();
            this.buttonRunProc = new System.Windows.Forms.Button();
            this.labelAvailableProcessors = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericTasks = new System.Windows.Forms.NumericUpDown();
            this.buttonRunTasks = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.statusLabelTasks = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCancelTasks = new System.Windows.Forms.Button();
            this.numericTaskRuntime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkExceptionTimer = new System.Windows.Forms.CheckBox();
            this.numericExceptionTimer = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericSelfTerminate = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSelfTerminate = new System.Windows.Forms.Button();
            this.buttonCancelTerminate = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiFreezeTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTasks)).BeginInit();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTaskRuntime)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExceptionTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelfTerminate)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(392, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // buttonHandledException
            // 
            this.buttonHandledException.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHandledException.Location = new System.Drawing.Point(285, 27);
            this.buttonHandledException.Name = "buttonHandledException";
            this.buttonHandledException.Size = new System.Drawing.Size(75, 23);
            this.buttonHandledException.TabIndex = 1;
            this.buttonHandledException.Text = "Давай";
            this.buttonHandledException.UseVisualStyleBackColor = true;
            this.buttonHandledException.Click += new System.EventHandler(this.buttonHandledException_Click);
            // 
            // buttonUnhandledException
            // 
            this.buttonUnhandledException.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnhandledException.Location = new System.Drawing.Point(285, 62);
            this.buttonUnhandledException.Name = "buttonUnhandledException";
            this.buttonUnhandledException.Size = new System.Drawing.Size(75, 23);
            this.buttonUnhandledException.TabIndex = 2;
            this.buttonUnhandledException.Text = "Жги";
            this.buttonUnhandledException.UseVisualStyleBackColor = true;
            this.buttonUnhandledException.Click += new System.EventHandler(this.buttonUnhandledException_Click);
            // 
            // buttonBusyUI
            // 
            this.buttonBusyUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBusyUI.Location = new System.Drawing.Point(285, 110);
            this.buttonBusyUI.Name = "buttonBusyUI";
            this.buttonBusyUI.Size = new System.Drawing.Size(75, 23);
            this.buttonBusyUI.TabIndex = 3;
            this.buttonBusyUI.Text = "Сделай это";
            this.buttonBusyUI.UseVisualStyleBackColor = true;
            this.buttonBusyUI.Click += new System.EventHandler(this.buttonBusyUI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Обрабатываемое исключение";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Необрабатываемое исключение";
            // 
            // uiFreezeTime
            // 
            this.uiFreezeTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.uiFreezeTime.Location = new System.Drawing.Point(111, 113);
            this.uiFreezeTime.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.uiFreezeTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiFreezeTime.Name = "uiFreezeTime";
            this.uiFreezeTime.Size = new System.Drawing.Size(54, 20);
            this.uiFreezeTime.TabIndex = 6;
            this.uiFreezeTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Подвесить UI на ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "сек";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonCancelTerminate);
            this.groupBox1.Controls.Add(this.buttonSelfTerminate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericSelfTerminate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonRunProc);
            this.groupBox1.Controls.Add(this.buttonFork);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.uiFreezeTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBusyUI);
            this.groupBox1.Controls.Add(this.buttonUnhandledException);
            this.groupBox1.Controls.Add(this.buttonHandledException);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 343);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Плюхи";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 17);
            this.statusLabel.Text = "         ";
            // 
            // buttonFork
            // 
            this.buttonFork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFork.Location = new System.Drawing.Point(230, 314);
            this.buttonFork.Name = "buttonFork";
            this.buttonFork.Size = new System.Drawing.Size(130, 23);
            this.buttonFork.TabIndex = 9;
            this.buttonFork.Text = "Форк себя";
            this.buttonFork.UseVisualStyleBackColor = true;
            this.buttonFork.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRunProc
            // 
            this.buttonRunProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunProc.Location = new System.Drawing.Point(94, 314);
            this.buttonRunProc.Name = "buttonRunProc";
            this.buttonRunProc.Size = new System.Drawing.Size(130, 23);
            this.buttonRunProc.TabIndex = 10;
            this.buttonRunProc.Text = "Запустить процесс";
            this.buttonRunProc.UseVisualStyleBackColor = true;
            this.buttonRunProc.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelAvailableProcessors
            // 
            this.labelAvailableProcessors.AutoSize = true;
            this.labelAvailableProcessors.Location = new System.Drawing.Point(6, 16);
            this.labelAvailableProcessors.Name = "labelAvailableProcessors";
            this.labelAvailableProcessors.Size = new System.Drawing.Size(131, 13);
            this.labelAvailableProcessors.TabIndex = 11;
            this.labelAvailableProcessors.Text = "Доступно процессоров: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericTaskRuntime);
            this.groupBox2.Controls.Add(this.buttonCancelTasks);
            this.groupBox2.Controls.Add(this.statusStrip2);
            this.groupBox2.Controls.Add(this.buttonRunTasks);
            this.groupBox2.Controls.Add(this.numericTasks);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelAvailableProcessors);
            this.groupBox2.Location = new System.Drawing.Point(14, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 120);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параллельные задачи:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Количество потоков:";
            // 
            // numericTasks
            // 
            this.numericTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericTasks.Location = new System.Drawing.Point(176, 37);
            this.numericTasks.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericTasks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTasks.Name = "numericTasks";
            this.numericTasks.Size = new System.Drawing.Size(75, 20);
            this.numericTasks.TabIndex = 13;
            this.numericTasks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonRunTasks
            // 
            this.buttonRunTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunTasks.Location = new System.Drawing.Point(259, 34);
            this.buttonRunTasks.Name = "buttonRunTasks";
            this.buttonRunTasks.Size = new System.Drawing.Size(75, 23);
            this.buttonRunTasks.TabIndex = 14;
            this.buttonRunTasks.Text = "Погнали";
            this.buttonRunTasks.UseVisualStyleBackColor = true;
            this.buttonRunTasks.Click += new System.EventHandler(this.buttonRunTasks_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelTasks});
            this.statusStrip2.Location = new System.Drawing.Point(3, 95);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(340, 22);
            this.statusStrip2.TabIndex = 15;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // statusLabelTasks
            // 
            this.statusLabelTasks.Name = "statusLabelTasks";
            this.statusLabelTasks.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonCancelTasks
            // 
            this.buttonCancelTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelTasks.Enabled = false;
            this.buttonCancelTasks.Location = new System.Drawing.Point(259, 63);
            this.buttonCancelTasks.Name = "buttonCancelTasks";
            this.buttonCancelTasks.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelTasks.TabIndex = 16;
            this.buttonCancelTasks.Text = "Стопай!";
            this.buttonCancelTasks.UseVisualStyleBackColor = true;
            this.buttonCancelTasks.Click += new System.EventHandler(this.buttonCancelTasks_Click);
            // 
            // numericTaskRuntime
            // 
            this.numericTaskRuntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericTaskRuntime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericTaskRuntime.Location = new System.Drawing.Point(177, 63);
            this.numericTaskRuntime.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericTaskRuntime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTaskRuntime.Name = "numericTaskRuntime";
            this.numericTaskRuntime.Size = new System.Drawing.Size(74, 20);
            this.numericTaskRuntime.TabIndex = 17;
            this.numericTaskRuntime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Время работы задачи (сек):";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.numericExceptionTimer);
            this.groupBox3.Controls.Add(this.checkExceptionTimer);
            this.groupBox3.Location = new System.Drawing.Point(182, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 75);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "По таймеру";
            // 
            // checkExceptionTimer
            // 
            this.checkExceptionTimer.AutoSize = true;
            this.checkExceptionTimer.Location = new System.Drawing.Point(7, 25);
            this.checkExceptionTimer.Name = "checkExceptionTimer";
            this.checkExceptionTimer.Size = new System.Drawing.Size(15, 14);
            this.checkExceptionTimer.TabIndex = 0;
            this.checkExceptionTimer.UseVisualStyleBackColor = true;
            // 
            // numericExceptionTimer
            // 
            this.numericExceptionTimer.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericExceptionTimer.Location = new System.Drawing.Point(37, 22);
            this.numericExceptionTimer.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericExceptionTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericExceptionTimer.Name = "numericExceptionTimer";
            this.numericExceptionTimer.Size = new System.Drawing.Size(51, 20);
            this.numericExceptionTimer.TabIndex = 1;
            this.numericExceptionTimer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Закрыть себя через";
            // 
            // numericSelfTerminate
            // 
            this.numericSelfTerminate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericSelfTerminate.Location = new System.Drawing.Point(127, 272);
            this.numericSelfTerminate.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericSelfTerminate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSelfTerminate.Name = "numericSelfTerminate";
            this.numericSelfTerminate.Size = new System.Drawing.Size(44, 20);
            this.numericSelfTerminate.TabIndex = 14;
            this.numericSelfTerminate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "сек";
            // 
            // buttonSelfTerminate
            // 
            this.buttonSelfTerminate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelfTerminate.Location = new System.Drawing.Point(285, 269);
            this.buttonSelfTerminate.Name = "buttonSelfTerminate";
            this.buttonSelfTerminate.Size = new System.Drawing.Size(75, 23);
            this.buttonSelfTerminate.TabIndex = 16;
            this.buttonSelfTerminate.Text = "Будь добр";
            this.buttonSelfTerminate.UseVisualStyleBackColor = true;
            this.buttonSelfTerminate.Click += new System.EventHandler(this.buttonSelfTerminate_Click);
            // 
            // buttonCancelTerminate
            // 
            this.buttonCancelTerminate.Location = new System.Drawing.Point(204, 268);
            this.buttonCancelTerminate.Name = "buttonCancelTerminate";
            this.buttonCancelTerminate.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelTerminate.TabIndex = 17;
            this.buttonCancelTerminate.Text = "Передумал";
            this.buttonCancelTerminate.UseVisualStyleBackColor = true;
            this.buttonCancelTerminate.Visible = false;
            this.buttonCancelTerminate.Click += new System.EventHandler(this.buttonCancelTerminate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Всякие штуковины";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiFreezeTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTasks)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTaskRuntime)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExceptionTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelfTerminate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonHandledException;
        private System.Windows.Forms.Button buttonUnhandledException;
        private System.Windows.Forms.Button buttonBusyUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown uiFreezeTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button buttonFork;
        private System.Windows.Forms.Button buttonRunProc;
        private System.Windows.Forms.Label labelAvailableProcessors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelTasks;
        private System.Windows.Forms.Button buttonRunTasks;
        private System.Windows.Forms.NumericUpDown numericTasks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancelTasks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericTaskRuntime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericExceptionTimer;
        private System.Windows.Forms.CheckBox checkExceptionTimer;
        private System.Windows.Forms.Button buttonSelfTerminate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericSelfTerminate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCancelTerminate;
    }
}

