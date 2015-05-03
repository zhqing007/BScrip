namespace BScrip.BSForms {
    partial class HostInfo {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.telnetBox = new System.Windows.Forms.RadioButton();
            this.sshBox = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.LoginNameBox = new System.Windows.Forms.TextBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.SPWBox = new System.Windows.Forms.TextBox();
            this.InfoOK = new System.Windows.Forms.Button();
            this.InfoCancle = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "登录名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "登录密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "权限密码:";
            // 
            // telnetBox
            // 
            this.telnetBox.AutoSize = true;
            this.telnetBox.Location = new System.Drawing.Point(16, 24);
            this.telnetBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telnetBox.Name = "telnetBox";
            this.telnetBox.Size = new System.Drawing.Size(76, 19);
            this.telnetBox.TabIndex = 4;
            this.telnetBox.TabStop = true;
            this.telnetBox.Text = "Telnet";
            this.telnetBox.UseVisualStyleBackColor = true;
            // 
            // sshBox
            // 
            this.sshBox.AutoSize = true;
            this.sshBox.Location = new System.Drawing.Point(208, 24);
            this.sshBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sshBox.Name = "sshBox";
            this.sshBox.Size = new System.Drawing.Size(52, 19);
            this.sshBox.TabIndex = 5;
            this.sshBox.TabStop = true;
            this.sshBox.Text = "SSH";
            this.sshBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sshBox);
            this.groupBox1.Controls.Add(this.telnetBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(325, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录类型";
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(163, 138);
            this.IPBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(176, 25);
            this.IPBox.TabIndex = 7;
            this.IPBox.TextChanged += new System.EventHandler(this.IPBox_TextChanged);
            // 
            // LoginNameBox
            // 
            this.LoginNameBox.Location = new System.Drawing.Point(163, 181);
            this.LoginNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginNameBox.Name = "LoginNameBox";
            this.LoginNameBox.Size = new System.Drawing.Size(176, 25);
            this.LoginNameBox.TabIndex = 8;
            // 
            // PWBox
            // 
            this.PWBox.Location = new System.Drawing.Point(163, 225);
            this.PWBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PWBox.Name = "PWBox";
            this.PWBox.PasswordChar = '*';
            this.PWBox.Size = new System.Drawing.Size(176, 25);
            this.PWBox.TabIndex = 9;
            // 
            // SPWBox
            // 
            this.SPWBox.Location = new System.Drawing.Point(163, 269);
            this.SPWBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SPWBox.Name = "SPWBox";
            this.SPWBox.PasswordChar = '*';
            this.SPWBox.Size = new System.Drawing.Size(176, 25);
            this.SPWBox.TabIndex = 10;
            // 
            // InfoOK
            // 
            this.InfoOK.Location = new System.Drawing.Point(64, 328);
            this.InfoOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoOK.Name = "InfoOK";
            this.InfoOK.Size = new System.Drawing.Size(108, 38);
            this.InfoOK.TabIndex = 11;
            this.InfoOK.Text = "保存";
            this.InfoOK.UseVisualStyleBackColor = true;
            this.InfoOK.Click += new System.EventHandler(this.InfoOK_Click);
            // 
            // InfoCancle
            // 
            this.InfoCancle.Location = new System.Drawing.Point(232, 328);
            this.InfoCancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoCancle.Name = "InfoCancle";
            this.InfoCancle.Size = new System.Drawing.Size(108, 38);
            this.InfoCancle.TabIndex = 12;
            this.InfoCancle.Text = "取消";
            this.InfoCancle.UseVisualStyleBackColor = true;
            this.InfoCancle.Click += new System.EventHandler(this.InfoCancle_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(163, 94);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(176, 25);
            this.NameBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "主机名:";
            // 
            // HostInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 405);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InfoCancle);
            this.Controls.Add(this.InfoOK);
            this.Controls.Add(this.SPWBox);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.LoginNameBox);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设备信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton telnetBox;
        private System.Windows.Forms.RadioButton sshBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.TextBox LoginNameBox;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.TextBox SPWBox;
        private System.Windows.Forms.Button InfoOK;
        private System.Windows.Forms.Button InfoCancle;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label5;
    }
}