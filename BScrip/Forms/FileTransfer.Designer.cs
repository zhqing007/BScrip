namespace BScrip {
    partial class FileTransfer {
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
            this.serverBox = new System.Windows.Forms.ComboBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.loginNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.savedServer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // serverBox
            // 
            this.serverBox.FormattingEnabled = true;
            this.serverBox.Location = new System.Drawing.Point(162, 39);
            this.serverBox.Margin = new System.Windows.Forms.Padding(4);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(272, 23);
            this.serverBox.TabIndex = 0;
            this.serverBox.SelectionChangeCommitted += new System.EventHandler(this.serverBox_SelectionChangeCommitted);
            // 
            // PWBox
            // 
            this.PWBox.Location = new System.Drawing.Point(162, 188);
            this.PWBox.Margin = new System.Windows.Forms.Padding(4);
            this.PWBox.Name = "PWBox";
            this.PWBox.PasswordChar = '*';
            this.PWBox.Size = new System.Drawing.Size(272, 25);
            this.PWBox.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(104, 280);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(99, 35);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "确定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(162, 88);
            this.ipBox.Margin = new System.Windows.Forms.Padding(4);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(272, 25);
            this.ipBox.TabIndex = 3;
            // 
            // loginNameBox
            // 
            this.loginNameBox.Location = new System.Drawing.Point(162, 138);
            this.loginNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginNameBox.Name = "loginNameBox";
            this.loginNameBox.Size = new System.Drawing.Size(272, 25);
            this.loginNameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "服务器名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "登录名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码：";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(302, 280);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 35);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // savedServer
            // 
            this.savedServer.AutoSize = true;
            this.savedServer.Location = new System.Drawing.Point(162, 240);
            this.savedServer.Name = "savedServer";
            this.savedServer.Size = new System.Drawing.Size(134, 19);
            this.savedServer.TabIndex = 10;
            this.savedServer.Text = "保存服务器信息";
            this.savedServer.UseVisualStyleBackColor = true;
            // 
            // FileTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 352);
            this.Controls.Add(this.savedServer);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginNameBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.serverBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileTransfer";
            this.ShowIcon = false;
            this.Text = "输入服务器信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serverBox;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox loginNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox savedServer;
    }
}