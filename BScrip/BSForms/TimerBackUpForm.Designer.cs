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
            this.timerBackUpL = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopLocal = new System.Windows.Forms.Button();
            this.getConfB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveRightB_t
            // 
            this.moveRightB_t.Location = new System.Drawing.Point(9, 254);
            this.moveRightB_t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveRightB_t.Name = "moveRightB_t";
            this.moveRightB_t.Size = new System.Drawing.Size(26, 87);
            this.moveRightB_t.TabIndex = 19;
            this.moveRightB_t.Text = ">>";
            this.moveRightB_t.UseVisualStyleBackColor = true;
            this.moveRightB_t.Click += new System.EventHandler(this.moveRightB_t_Click);
            // 
            // timerBackUpL
            // 
            this.timerBackUpL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timerBackUpL.FullRowSelect = true;
            this.timerBackUpL.Location = new System.Drawing.Point(9, 22);
            this.timerBackUpL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timerBackUpL.Name = "timerBackUpL";
            this.timerBackUpL.Size = new System.Drawing.Size(474, 230);
            this.timerBackUpL.TabIndex = 18;
            this.timerBackUpL.UseCompatibleStateImageBehavior = false;
            this.timerBackUpL.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "时：";
            // 
            // dayUpDown
            // 
            this.dayUpDown.Location = new System.Drawing.Point(133, 86);
            this.dayUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.dayUpDown.Name = "dayUpDown";
            this.dayUpDown.Size = new System.Drawing.Size(58, 21);
            this.dayUpDown.TabIndex = 28;
            // 
            // hourUpDown
            // 
            this.hourUpDown.Location = new System.Drawing.Point(300, 86);
            this.hourUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Size = new System.Drawing.Size(69, 21);
            this.hourUpDown.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "需要备份配置的设备：";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ipaddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.namebox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hourUpDown);
            this.panel1.Controls.Add(this.dayUpDown);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.getConfB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.stopLocal);
            this.panel1.Location = new System.Drawing.Point(40, 254);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 218);
            this.panel1.TabIndex = 32;
            // 
            // stopLocal
            // 
            this.stopLocal.Enabled = false;
            this.stopLocal.Location = new System.Drawing.Point(294, 154);
            this.stopLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopLocal.Name = "stopLocal";
            this.stopLocal.Size = new System.Drawing.Size(75, 24);
            this.stopLocal.TabIndex = 31;
            this.stopLocal.Text = "停止";
            this.stopLocal.UseVisualStyleBackColor = true;
            this.stopLocal.Click += new System.EventHandler(this.stopLocal_Click);
            // 
            // getConfB
            // 
            this.getConfB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getConfB.Location = new System.Drawing.Point(41, 154);
            this.getConfB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getConfB.Name = "getConfB";
            this.getConfB.Size = new System.Drawing.Size(80, 24);
            this.getConfB.TabIndex = 34;
            this.getConfB.Text = "开始备份";
            this.getConfB.UseVisualStyleBackColor = true;
            this.getConfB.Click += new System.EventHandler(this.getConfB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "主机名：";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(98, 20);
            this.namebox.Name = "namebox";
            this.namebox.ReadOnly = true;
            this.namebox.Size = new System.Drawing.Size(295, 21);
            this.namebox.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "IP地址：";
            // 
            // ipaddress
            // 
            this.ipaddress.Location = new System.Drawing.Point(98, 53);
            this.ipaddress.Name = "ipaddress";
            this.ipaddress.ReadOnly = true;
            this.ipaddress.Size = new System.Drawing.Size(295, 21);
            this.ipaddress.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "间隔时间：";
            // 
            // TimerBackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moveRightB_t);
            this.Controls.Add(this.timerBackUpL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TimerBackUpForm";
            this.Text = "设备配置备份";
            ((System.ComponentModel.ISupportInitialize)(this.dayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveRightB_t;
        private System.Windows.Forms.ListView timerBackUpL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dayUpDown;
        private System.Windows.Forms.NumericUpDown hourUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopLocal;
        private System.Windows.Forms.Button getConfB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ipaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label1;
    }
}