namespace BScrip.BSForms {
    partial class WelcomeForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.namebox = new System.Windows.Forms.TextBox();
            this.pwbox = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(60, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "网络设备维护";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(281, 168);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(231, 25);
            this.namebox.TabIndex = 1;
            // 
            // pwbox
            // 
            this.pwbox.Location = new System.Drawing.Point(281, 242);
            this.pwbox.Name = "pwbox";
            this.pwbox.PasswordChar = '*';
            this.pwbox.Size = new System.Drawing.Size(231, 25);
            this.pwbox.TabIndex = 2;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(211, 321);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(101, 33);
            this.login.TabIndex = 3;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(411, 321);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(101, 33);
            this.close.TabIndex = 4;
            this.close.Text = "关闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(208, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "登录名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(208, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "密码：";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pwbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WelcomeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomForm";
            this.Shown += new System.EventHandler(this.WelcomeForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox pwbox;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}