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
            this.timerBackUpL = new System.Windows.Forms.ListBox();
            this.timerLogTBox = new System.Windows.Forms.TextBox();
            this.timerRemBu = new System.Windows.Forms.Button();
            this.timerLocBu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // moveRightB_t
            // 
            this.moveRightB_t.Location = new System.Drawing.Point(26, 29);
            this.moveRightB_t.Margin = new System.Windows.Forms.Padding(2);
            this.moveRightB_t.Name = "moveRightB_t";
            this.moveRightB_t.Size = new System.Drawing.Size(30, 108);
            this.moveRightB_t.TabIndex = 19;
            this.moveRightB_t.Text = ">>";
            this.moveRightB_t.UseVisualStyleBackColor = true;
            // 
            // moveLeftB_t
            // 
            this.moveLeftB_t.Location = new System.Drawing.Point(26, 273);
            this.moveLeftB_t.Margin = new System.Windows.Forms.Padding(2);
            this.moveLeftB_t.Name = "moveLeftB_t";
            this.moveLeftB_t.Size = new System.Drawing.Size(30, 108);
            this.moveLeftB_t.TabIndex = 20;
            this.moveLeftB_t.Text = "<<";
            this.moveLeftB_t.UseVisualStyleBackColor = true;
            // 
            // timerBackUpL
            // 
            this.timerBackUpL.FormattingEnabled = true;
            this.timerBackUpL.ItemHeight = 12;
            this.timerBackUpL.Location = new System.Drawing.Point(72, 29);
            this.timerBackUpL.Margin = new System.Windows.Forms.Padding(2);
            this.timerBackUpL.Name = "timerBackUpL";
            this.timerBackUpL.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.timerBackUpL.Size = new System.Drawing.Size(218, 352);
            this.timerBackUpL.TabIndex = 18;
            // 
            // timerLogTBox
            // 
            this.timerLogTBox.BackColor = System.Drawing.SystemColors.Info;
            this.timerLogTBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timerLogTBox.Location = new System.Drawing.Point(0, 387);
            this.timerLogTBox.Multiline = true;
            this.timerLogTBox.Name = "timerLogTBox";
            this.timerLogTBox.ReadOnly = true;
            this.timerLogTBox.Size = new System.Drawing.Size(716, 128);
            this.timerLogTBox.TabIndex = 17;
            // 
            // timerRemBu
            // 
            this.timerRemBu.Location = new System.Drawing.Point(521, 358);
            this.timerRemBu.Name = "timerRemBu";
            this.timerRemBu.Size = new System.Drawing.Size(122, 23);
            this.timerRemBu.TabIndex = 16;
            this.timerRemBu.Text = "定时备份到远程";
            this.timerRemBu.UseVisualStyleBackColor = true;
            // 
            // timerLocBu
            // 
            this.timerLocBu.Location = new System.Drawing.Point(334, 358);
            this.timerLocBu.Name = "timerLocBu";
            this.timerLocBu.Size = new System.Drawing.Size(122, 23);
            this.timerLocBu.TabIndex = 15;
            this.timerLocBu.Text = "定时备份到本机";
            this.timerLocBu.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(443, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2015, 4, 3, 16, 2, 10, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "开始时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "月：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "时：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 27;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(111, 69);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown2.TabIndex = 28;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(111, 112);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown3.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(348, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 212);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "间隔时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "分：";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(111, 160);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown4.TabIndex = 31;
            // 
            // TimerBackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.moveRightB_t);
            this.Controls.Add(this.moveLeftB_t);
            this.Controls.Add(this.timerBackUpL);
            this.Controls.Add(this.timerLogTBox);
            this.Controls.Add(this.timerRemBu);
            this.Controls.Add(this.timerLocBu);
            this.Name = "TimerBackUpForm";
            this.Text = "TimerBackUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveRightB_t;
        private System.Windows.Forms.Button moveLeftB_t;
        private System.Windows.Forms.ListBox timerBackUpL;
        private System.Windows.Forms.TextBox timerLogTBox;
        private System.Windows.Forms.Button timerRemBu;
        private System.Windows.Forms.Button timerLocBu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}