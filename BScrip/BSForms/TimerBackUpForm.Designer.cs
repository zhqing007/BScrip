namespace BScrip.BSForms {
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
            this.beginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.remoser_re = new System.Windows.Forms.TextBox();
            this.selserver_re = new System.Windows.Forms.Button();
            this.isUpLoad_re = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.isTimercheckbox = new System.Windows.Forms.CheckBox();
            this.stopLocal = new System.Windows.Forms.Button();
            this.localIsRunningPic = new System.Windows.Forms.PictureBox();
            this.getConfB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localIsRunningPic)).BeginInit();
            this.SuspendLayout();
            // 
            // moveRightB_t
            // 
            this.moveRightB_t.Location = new System.Drawing.Point(12, 28);
            this.moveRightB_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveRightB_t.Name = "moveRightB_t";
            this.moveRightB_t.Size = new System.Drawing.Size(35, 109);
            this.moveRightB_t.TabIndex = 19;
            this.moveRightB_t.Text = ">>";
            this.moveRightB_t.UseVisualStyleBackColor = true;
            this.moveRightB_t.Click += new System.EventHandler(this.moveRightB_t_Click);
            // 
            // moveLeftB_t
            // 
            this.moveLeftB_t.Location = new System.Drawing.Point(12, 141);
            this.moveLeftB_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveLeftB_t.Name = "moveLeftB_t";
            this.moveLeftB_t.Size = new System.Drawing.Size(35, 109);
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
            this.timerBackUpL.Location = new System.Drawing.Point(52, 28);
            this.timerBackUpL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timerBackUpL.Name = "timerBackUpL";
            this.timerBackUpL.Size = new System.Drawing.Size(680, 302);
            this.timerBackUpL.TabIndex = 18;
            this.timerBackUpL.UseCompatibleStateImageBehavior = false;
            this.timerBackUpL.View = System.Windows.Forms.View.Details;
            // 
            // beginTimePicker
            // 
            this.beginTimePicker.CustomFormat = "yyyy年MM月dd日 HH时mm分";
            this.beginTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginTimePicker.Location = new System.Drawing.Point(80, 26);
            this.beginTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.beginTimePicker.Name = "beginTimePicker";
            this.beginTimePicker.ShowUpDown = true;
            this.beginTimePicker.Size = new System.Drawing.Size(248, 25);
            this.beginTimePicker.TabIndex = 21;
            this.beginTimePicker.Value = new System.DateTime(2015, 4, 3, 16, 2, 10, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "开始时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "时：";
            // 
            // dayUpDown
            // 
            this.dayUpDown.Location = new System.Drawing.Point(53, 26);
            this.dayUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.dayUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.dayUpDown.Name = "dayUpDown";
            this.dayUpDown.Size = new System.Drawing.Size(46, 25);
            this.dayUpDown.TabIndex = 28;
            // 
            // hourUpDown
            // 
            this.hourUpDown.Location = new System.Drawing.Point(158, 26);
            this.hourUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.hourUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Size = new System.Drawing.Size(46, 25);
            this.hourUpDown.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minuteUpDown);
            this.groupBox1.Controls.Add(this.hourUpDown);
            this.groupBox1.Controls.Add(this.dayUpDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(318, 67);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "间隔时间";
            // 
            // minuteUpDown
            // 
            this.minuteUpDown.Location = new System.Drawing.Point(263, 26);
            this.minuteUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.minuteUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteUpDown.Name = "minuteUpDown";
            this.minuteUpDown.Size = new System.Drawing.Size(46, 25);
            this.minuteUpDown.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "分：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "需要备份配置的设备：";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.getConfB);
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 196);
            this.panel1.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.remoser_re);
            this.groupBox3.Controls.Add(this.selserver_re);
            this.groupBox3.Controls.Add(this.isUpLoad_re);
            this.groupBox3.Location = new System.Drawing.Point(495, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 148);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "上传服务器名：";
            // 
            // remoser_re
            // 
            this.remoser_re.Location = new System.Drawing.Point(9, 50);
            this.remoser_re.Name = "remoser_re";
            this.remoser_re.ReadOnly = true;
            this.remoser_re.Size = new System.Drawing.Size(210, 25);
            this.remoser_re.TabIndex = 37;
            // 
            // selserver_re
            // 
            this.selserver_re.Enabled = false;
            this.selserver_re.Location = new System.Drawing.Point(70, 85);
            this.selserver_re.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selserver_re.Name = "selserver_re";
            this.selserver_re.Size = new System.Drawing.Size(149, 30);
            this.selserver_re.TabIndex = 35;
            this.selserver_re.Text = "选择上上传服务器";
            this.selserver_re.UseVisualStyleBackColor = true;
            this.selserver_re.Click += new System.EventHandler(this.selserver_re_Click);
            // 
            // isUpLoad_re
            // 
            this.isUpLoad_re.AutoSize = true;
            this.isUpLoad_re.Location = new System.Drawing.Point(9, 0);
            this.isUpLoad_re.Name = "isUpLoad_re";
            this.isUpLoad_re.Size = new System.Drawing.Size(104, 19);
            this.isUpLoad_re.TabIndex = 36;
            this.isUpLoad_re.Text = "上传到远端";
            this.isUpLoad_re.UseVisualStyleBackColor = true;
            this.isUpLoad_re.CheckedChanged += new System.EventHandler(this.isUpLoad_re_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.isTimercheckbox);
            this.groupBox2.Controls.Add(this.beginTimePicker);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.stopLocal);
            this.groupBox2.Controls.Add(this.localIsRunningPic);
            this.groupBox2.Location = new System.Drawing.Point(14, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 148);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // isTimercheckbox
            // 
            this.isTimercheckbox.AutoSize = true;
            this.isTimercheckbox.Location = new System.Drawing.Point(9, 0);
            this.isTimercheckbox.Name = "isTimercheckbox";
            this.isTimercheckbox.Size = new System.Drawing.Size(89, 19);
            this.isTimercheckbox.TabIndex = 38;
            this.isTimercheckbox.Text = "定时备份";
            this.isTimercheckbox.UseVisualStyleBackColor = true;
            this.isTimercheckbox.CheckedChanged += new System.EventHandler(this.isTimercheckbox_CheckedChanged);
            // 
            // stopLocal
            // 
            this.stopLocal.Enabled = false;
            this.stopLocal.Location = new System.Drawing.Point(352, 26);
            this.stopLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopLocal.Name = "stopLocal";
            this.stopLocal.Size = new System.Drawing.Size(100, 30);
            this.stopLocal.TabIndex = 31;
            this.stopLocal.Text = "停止";
            this.stopLocal.UseVisualStyleBackColor = true;
            this.stopLocal.Click += new System.EventHandler(this.stopLocal_Click);
            // 
            // localIsRunningPic
            // 
            this.localIsRunningPic.BackColor = System.Drawing.SystemColors.Control;
            this.localIsRunningPic.Image = global::BScrip.Properties.Resources.norun;
            this.localIsRunningPic.Location = new System.Drawing.Point(352, 85);
            this.localIsRunningPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.localIsRunningPic.Name = "localIsRunningPic";
            this.localIsRunningPic.Size = new System.Drawing.Size(100, 30);
            this.localIsRunningPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.localIsRunningPic.TabIndex = 33;
            this.localIsRunningPic.TabStop = false;
            // 
            // getConfB
            // 
            this.getConfB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getConfB.Location = new System.Drawing.Point(12, 160);
            this.getConfB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getConfB.Name = "getConfB";
            this.getConfB.Size = new System.Drawing.Size(106, 30);
            this.getConfB.TabIndex = 34;
            this.getConfB.Text = "开始备份";
            this.getConfB.UseVisualStyleBackColor = true;
            this.getConfB.Click += new System.EventHandler(this.getConfB_Click);
            // 
            // TimerBackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moveRightB_t);
            this.Controls.Add(this.moveLeftB_t);
            this.Controls.Add(this.timerBackUpL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimerBackUpForm";
            this.Text = "设备配置备份";
            ((System.ComponentModel.ISupportInitialize)(this.dayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localIsRunningPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveRightB_t;
        private System.Windows.Forms.Button moveLeftB_t;
        private System.Windows.Forms.ListView timerBackUpL;
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
        private System.Windows.Forms.Button stopLocal;
        private System.Windows.Forms.PictureBox localIsRunningPic;
        private System.Windows.Forms.TextBox remoser_re;
        private System.Windows.Forms.CheckBox isUpLoad_re;
        private System.Windows.Forms.Button selserver_re;
        private System.Windows.Forms.Button getConfB;
        private System.Windows.Forms.CheckBox isTimercheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
    }
}