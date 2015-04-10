namespace BScrip {
    partial class TimerBackUpForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.moveRightB_t = new System.Windows.Forms.Button();
            this.moveLeftB_t = new System.Windows.Forms.Button();
            this.timerBackUpL = new System.Windows.Forms.ListView();
            this.timerLogTBox = new System.Windows.Forms.TextBox();
            this.timerRemBu = new System.Windows.Forms.Button();
            this.timerLocBu = new System.Windows.Forms.Button();
            this.beginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.localIsRunningPic = new System.Windows.Forms.PictureBox();
            this.stopRemote = new System.Windows.Forms.Button();
            this.stopLocal = new System.Windows.Forms.Button();
            this.selectAllB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localIsRunningPic)).BeginInit();
            this.SuspendLayout();
            // 
            // moveRightB_t
            // 
            this.moveRightB_t.Location = new System.Drawing.Point(9, 22);
            this.moveRightB_t.Margin = new System.Windows.Forms.Padding(2);
            this.moveRightB_t.Name = "moveRightB_t";
            this.moveRightB_t.Size = new System.Drawing.Size(26, 143);
            this.moveRightB_t.TabIndex = 19;
            this.moveRightB_t.Text = ">>";
            this.moveRightB_t.UseVisualStyleBackColor = true;
            this.moveRightB_t.Click += new System.EventHandler(this.moveRightB_t_Click);
            // 
            // moveLeftB_t
            // 
            this.moveLeftB_t.Location = new System.Drawing.Point(9, 168);
            this.moveLeftB_t.Margin = new System.Windows.Forms.Padding(2);
            this.moveLeftB_t.Name = "moveLeftB_t";
            this.moveLeftB_t.Size = new System.Drawing.Size(26, 143);
            this.moveLeftB_t.TabIndex = 20;
            this.moveLeftB_t.Text = "<<";
            this.moveLeftB_t.UseVisualStyleBackColor = true;
            this.moveLeftB_t.Click += new System.EventHandler(this.moveLeftB_t_Click);
            // 
            // timerBackUpL
            // 
            this.timerBackUpL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timerBackUpL.FullRowSelect = true;
            this.timerBackUpL.Location = new System.Drawing.Point(39, 22);
            this.timerBackUpL.Margin = new System.Windows.Forms.Padding(2);
            this.timerBackUpL.Name = "timerBackUpL";
            this.timerBackUpL.Size = new System.Drawing.Size(322, 474);
            this.timerBackUpL.TabIndex = 18;
            this.timerBackUpL.UseCompatibleStateImageBehavior = false;
            this.timerBackUpL.View = System.Windows.Forms.View.Details;
            // 
            // timerLogTBox
            // 
            this.timerLogTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLogTBox.BackColor = System.Drawing.SystemColors.Window;
            this.timerLogTBox.Location = new System.Drawing.Point(368, 256);
            this.timerLogTBox.Multiline = true;
            this.timerLogTBox.Name = "timerLogTBox";
            this.timerLogTBox.ReadOnly = true;
            this.timerLogTBox.Size = new System.Drawing.Size(313, 274);
            this.timerLogTBox.TabIndex = 17;
            // 
            // timerRemBu
            // 
            this.timerRemBu.Location = new System.Drawing.Point(22, 186);
            this.timerRemBu.Name = "timerRemBu";
            this.timerRemBu.Size = new System.Drawing.Size(112, 23);
            this.timerRemBu.TabIndex = 16;
            this.timerRemBu.Text = "定时备份到远程";
            this.timerRemBu.UseVisualStyleBackColor = true;
            this.timerRemBu.Click += new System.EventHandler(this.timerRemBu_Click);
            // 
            // timerLocBu
            // 
            this.timerLocBu.Location = new System.Drawing.Point(22, 146);
            this.timerLocBu.Name = "timerLocBu";
            this.timerLocBu.Size = new System.Drawing.Size(112, 23);
            this.timerLocBu.TabIndex = 15;
            this.timerLocBu.Text = "定时备份到本机";
            this.timerLocBu.UseVisualStyleBackColor = true;
            this.timerLocBu.Click += new System.EventHandler(this.timerLocBu_Click);
            // 
            // beginTimePicker
            // 
            this.beginTimePicker.CustomFormat = "yyyy年MM月dd日 HH时mm分";
            this.beginTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginTimePicker.Location = new System.Drawing.Point(98, 20);
            this.beginTimePicker.Name = "beginTimePicker";
            this.beginTimePicker.ShowUpDown = true;
            this.beginTimePicker.Size = new System.Drawing.Size(199, 21);
            this.beginTimePicker.TabIndex = 21;
            this.beginTimePicker.Value = new System.DateTime(2015, 4, 3, 16, 2, 10, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "开始时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "时：";
            // 
            // dayUpDown
            // 
            this.dayUpDown.Location = new System.Drawing.Point(45, 21);
            this.dayUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.dayUpDown.Name = "dayUpDown";
            this.dayUpDown.Size = new System.Drawing.Size(46, 21);
            this.dayUpDown.TabIndex = 28;
            // 
            // hourUpDown
            // 
            this.hourUpDown.Location = new System.Drawing.Point(136, 21);
            this.hourUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Size = new System.Drawing.Size(46, 21);
            this.hourUpDown.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.minuteUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hourUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dayUpDown);
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 67);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "间隔时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "分：";
            // 
            // minuteUpDown
            // 
            this.minuteUpDown.Location = new System.Drawing.Point(224, 21);
            this.minuteUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteUpDown.Name = "minuteUpDown";
            this.minuteUpDown.Size = new System.Drawing.Size(46, 21);
            this.minuteUpDown.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "需要备份配置的交换机：";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.localIsRunningPic);
            this.panel1.Controls.Add(this.stopRemote);
            this.panel1.Controls.Add(this.stopLocal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.beginTimePicker);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.timerLocBu);
            this.panel1.Controls.Add(this.timerRemBu);
            this.panel1.Location = new System.Drawing.Point(368, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 229);
            this.panel1.TabIndex = 32;
            // 
            // localIsRunningPic
            // 
            this.localIsRunningPic.BackColor = System.Drawing.SystemColors.Control;
            this.localIsRunningPic.Location = new System.Drawing.Point(239, 146);
            this.localIsRunningPic.Margin = new System.Windows.Forms.Padding(2);
            this.localIsRunningPic.Name = "localIsRunningPic";
            this.localIsRunningPic.Size = new System.Drawing.Size(46, 43);
            this.localIsRunningPic.TabIndex = 33;
            this.localIsRunningPic.TabStop = false;
            // 
            // stopRemote
            // 
            this.stopRemote.Enabled = false;
            this.stopRemote.Location = new System.Drawing.Point(151, 186);
            this.stopRemote.Margin = new System.Windows.Forms.Padding(2);
            this.stopRemote.Name = "stopRemote";
            this.stopRemote.Size = new System.Drawing.Size(75, 23);
            this.stopRemote.TabIndex = 32;
            this.stopRemote.Text = "停止";
            this.stopRemote.UseVisualStyleBackColor = true;
            // 
            // stopLocal
            // 
            this.stopLocal.Enabled = false;
            this.stopLocal.Location = new System.Drawing.Point(151, 146);
            this.stopLocal.Margin = new System.Windows.Forms.Padding(2);
            this.stopLocal.Name = "stopLocal";
            this.stopLocal.Size = new System.Drawing.Size(75, 23);
            this.stopLocal.TabIndex = 31;
            this.stopLocal.Text = "停止";
            this.stopLocal.UseVisualStyleBackColor = true;
            this.stopLocal.Click += new System.EventHandler(this.stopLocal_Click);
            // 
            // selectAllB
            // 
            this.selectAllB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllB.Location = new System.Drawing.Point(39, 506);
            this.selectAllB.Margin = new System.Windows.Forms.Padding(2);
            this.selectAllB.Name = "selectAllB";
            this.selectAllB.Size = new System.Drawing.Size(56, 23);
            this.selectAllB.TabIndex = 33;
            this.selectAllB.Text = "全选";
            this.selectAllB.UseVisualStyleBackColor = true;
            this.selectAllB.Click += new System.EventHandler(this.selectAllB_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(190, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 23);
            this.panel2.TabIndex = 34;
            // 
            // TimerBackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.selectAllB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moveRightB_t);
            this.Controls.Add(this.moveLeftB_t);
            this.Controls.Add(this.timerBackUpL);
            this.Controls.Add(this.timerLogTBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TimerBackUpForm";
            this.Text = "TimerBackUpForm";
            this.Shown += new System.EventHandler(this.TimerBackUpForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localIsRunningPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveRightB_t;
        private System.Windows.Forms.Button moveLeftB_t;
        private System.Windows.Forms.ListView timerBackUpL;
        private System.Windows.Forms.TextBox timerLogTBox;
        private System.Windows.Forms.Button timerRemBu;
        private System.Windows.Forms.Button timerLocBu;
        private System.Windows.Forms.DateTimePicker beginTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dayUpDown;
        private System.Windows.Forms.NumericUpDown hourUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown minuteUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button selectAllB;
        private System.Windows.Forms.Button stopRemote;
        private System.Windows.Forms.Button stopLocal;
        private System.Windows.Forms.PictureBox localIsRunningPic;
        private System.Windows.Forms.Panel panel2;
    }
}