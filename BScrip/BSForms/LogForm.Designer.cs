namespace BScrip.BSForms {
    partial class LogForm {
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
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.LogFSaveB = new System.Windows.Forms.Button();
            this.LogFCloseB = new System.Windows.Forms.Button();
            this.LogFCopyB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.logTextBox.Location = new System.Drawing.Point(12, 12);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(446, 333);
            this.logTextBox.TabIndex = 0;
            // 
            // LogFSaveB
            // 
            this.LogFSaveB.Location = new System.Drawing.Point(166, 351);
            this.LogFSaveB.Name = "LogFSaveB";
            this.LogFSaveB.Size = new System.Drawing.Size(81, 34);
            this.LogFSaveB.TabIndex = 1;
            this.LogFSaveB.Text = "保存...";
            this.LogFSaveB.UseVisualStyleBackColor = true;
            this.LogFSaveB.Click += new System.EventHandler(this.LogFSaveB_Click);
            // 
            // LogFCloseB
            // 
            this.LogFCloseB.Location = new System.Drawing.Point(363, 351);
            this.LogFCloseB.Name = "LogFCloseB";
            this.LogFCloseB.Size = new System.Drawing.Size(81, 34);
            this.LogFCloseB.TabIndex = 2;
            this.LogFCloseB.Text = "关闭";
            this.LogFCloseB.UseVisualStyleBackColor = true;
            this.LogFCloseB.Click += new System.EventHandler(this.LogFCloseB_Click);
            // 
            // LogFCopyB
            // 
            this.LogFCopyB.Location = new System.Drawing.Point(266, 351);
            this.LogFCopyB.Name = "LogFCopyB";
            this.LogFCopyB.Size = new System.Drawing.Size(81, 34);
            this.LogFCopyB.TabIndex = 3;
            this.LogFCopyB.Text = "复制";
            this.LogFCopyB.UseVisualStyleBackColor = true;
            this.LogFCopyB.Click += new System.EventHandler(this.LogFCopyB_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 428);
            this.ControlBox = false;
            this.Controls.Add(this.LogFCopyB);
            this.Controls.Add(this.LogFCloseB);
            this.Controls.Add(this.LogFSaveB);
            this.Controls.Add(this.logTextBox);
            this.Name = "LogForm";
            this.ShowInTaskbar = false;
            this.Text = "正在导出";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button LogFSaveB;
        private System.Windows.Forms.Button LogFCloseB;
        private System.Windows.Forms.Button LogFCopyB;
    }
}