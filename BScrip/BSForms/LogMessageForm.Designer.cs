namespace BScrip.BSForms {
    partial class LogMessageForm {
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
            this.loglist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogFCopyB = new System.Windows.Forms.Button();
            this.LogFSaveB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loglist
            // 
            this.loglist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.loglist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.loglist.FullRowSelect = true;
            this.loglist.Location = new System.Drawing.Point(0, 0);
            this.loglist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loglist.Name = "loglist";
            this.loglist.Size = new System.Drawing.Size(505, 108);
            this.loglist.TabIndex = 0;
            this.loglist.UseCompatibleStateImageBehavior = false;
            this.loglist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "时间";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "消息";
            this.columnHeader4.Width = 309;
            // 
            // LogFCopyB
            // 
            this.LogFCopyB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogFCopyB.Location = new System.Drawing.Point(443, 113);
            this.LogFCopyB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogFCopyB.Name = "LogFCopyB";
            this.LogFCopyB.Size = new System.Drawing.Size(61, 20);
            this.LogFCopyB.TabIndex = 5;
            this.LogFCopyB.Text = "复制";
            this.LogFCopyB.UseVisualStyleBackColor = true;
            // 
            // LogFSaveB
            // 
            this.LogFSaveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogFSaveB.Location = new System.Drawing.Point(378, 113);
            this.LogFSaveB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogFSaveB.Name = "LogFSaveB";
            this.LogFSaveB.Size = new System.Drawing.Size(61, 20);
            this.LogFSaveB.TabIndex = 4;
            this.LogFSaveB.Text = "保存...";
            this.LogFSaveB.UseVisualStyleBackColor = true;
            // 
            // LogMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 134);
            this.Controls.Add(this.LogFCopyB);
            this.Controls.Add(this.LogFSaveB);
            this.Controls.Add(this.loglist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogMessageForm";
            this.ShowInTaskbar = false;
            this.Text = "日志";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView loglist;
        private System.Windows.Forms.Button LogFCopyB;
        private System.Windows.Forms.Button LogFSaveB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}