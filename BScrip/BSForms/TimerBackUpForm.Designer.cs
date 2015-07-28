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
            this.dayUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addToBU = new System.Windows.Forms.Button();
            this.stopLocal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dayUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveRightB_t
            // 
            this.moveRightB_t.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveRightB_t.Location = new System.Drawing.Point(9, 259);
            this.moveRightB_t.Margin = new System.Windows.Forms.Padding(2);
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
            this.timerBackUpL.Margin = new System.Windows.Forms.Padding(2);
            this.timerBackUpL.Name = "timerBackUpL";
            this.timerBackUpL.Size = new System.Drawing.Size(487, 233);
            this.timerBackUpL.TabIndex = 18;
            this.timerBackUpL.UseCompatibleStateImageBehavior = false;
            this.timerBackUpL.View = System.Windows.Forms.View.Details;
            this.timerBackUpL.SelectedIndexChanged += new System.EventHandler(this.timerBackUpL_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "天";
            // 
            // dayUpDown
            // 
            this.dayUpDown.Location = new System.Drawing.Point(98, 76);
            this.dayUpDown.Name = "dayUpDown";
            this.dayUpDown.Size = new System.Drawing.Size(77, 21);
            this.dayUpDown.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "定期备份配置的设备：";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ipbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.namebox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dayUpDown);
            this.panel1.Controls.Add(this.addToBU);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.stopLocal);
            this.panel1.Location = new System.Drawing.Point(40, 258);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 138);
            this.panel1.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "间隔时间：";
            // 
            // ipbox
            // 
            this.ipbox.Location = new System.Drawing.Point(98, 43);
            this.ipbox.Name = "ipbox";
            this.ipbox.ReadOnly = true;
            this.ipbox.Size = new System.Drawing.Size(295, 21);
            this.ipbox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "IP地址：";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(98, 10);
            this.namebox.Name = "namebox";
            this.namebox.ReadOnly = true;
            this.namebox.Size = new System.Drawing.Size(295, 21);
            this.namebox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "主机名：";
            // 
            // addToBU
            // 
            this.addToBU.Location = new System.Drawing.Point(73, 104);
            this.addToBU.Margin = new System.Windows.Forms.Padding(2);
            this.addToBU.Name = "addToBU";
            this.addToBU.Size = new System.Drawing.Size(80, 24);
            this.addToBU.TabIndex = 34;
            this.addToBU.Text = "加入备份";
            this.addToBU.UseVisualStyleBackColor = true;
            this.addToBU.Click += new System.EventHandler(this.addToBU_Click);
            // 
            // stopLocal
            // 
            this.stopLocal.Enabled = false;
            this.stopLocal.Location = new System.Drawing.Point(278, 104);
            this.stopLocal.Margin = new System.Windows.Forms.Padding(2);
            this.stopLocal.Name = "stopLocal";
            this.stopLocal.Size = new System.Drawing.Size(75, 24);
            this.stopLocal.TabIndex = 31;
            this.stopLocal.Text = "停止";
            this.stopLocal.UseVisualStyleBackColor = true;
            this.stopLocal.Click += new System.EventHandler(this.stopLocal_Click);
            // 
            // TimerBackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moveRightB_t);
            this.Controls.Add(this.timerBackUpL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TimerBackUpForm";
            this.Text = "设备配置备份";
            ((System.ComponentModel.ISupportInitialize)(this.dayUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveRightB_t;
        private System.Windows.Forms.ListView timerBackUpL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown dayUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopLocal;
        private System.Windows.Forms.Button addToBU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label1;
    }
}