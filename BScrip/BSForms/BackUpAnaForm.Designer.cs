namespace BScrip.BSForms {
    partial class BackUpAnaForm {
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
            this.backuplist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.close = new System.Windows.Forms.Button();
            this.anaStatus = new System.Windows.Forms.StatusStrip();
            this.anaStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.export = new System.Windows.Forms.Button();
            this.anaStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // backuplist
            // 
            this.backuplist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.backuplist.Dock = System.Windows.Forms.DockStyle.Top;
            this.backuplist.Location = new System.Drawing.Point(0, 0);
            this.backuplist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backuplist.Name = "backuplist";
            this.backuplist.Size = new System.Drawing.Size(471, 421);
            this.backuplist.TabIndex = 0;
            this.backuplist.UseCompatibleStateImageBehavior = false;
            this.backuplist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "设备名称";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP地址";
            this.columnHeader3.Width = 161;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "次数";
            this.columnHeader4.Width = 134;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(398, 438);
            this.close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(64, 24);
            this.close.TabIndex = 4;
            this.close.Text = "关闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // anaStatus
            // 
            this.anaStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaStatusLabel});
            this.anaStatus.Location = new System.Drawing.Point(0, 469);
            this.anaStatus.Name = "anaStatus";
            this.anaStatus.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.anaStatus.Size = new System.Drawing.Size(471, 22);
            this.anaStatus.TabIndex = 5;
            this.anaStatus.Text = "statusStrip1";
            // 
            // anaStatusLabel
            // 
            this.anaStatusLabel.Name = "anaStatusLabel";
            this.anaStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(286, 438);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 6;
            this.export.Text = "导出";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // BackUpAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 491);
            this.Controls.Add(this.export);
            this.Controls.Add(this.anaStatus);
            this.Controls.Add(this.close);
            this.Controls.Add(this.backuplist);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BackUpAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "网络设备备份统计";
            this.anaStatus.ResumeLayout(false);
            this.anaStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView backuplist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.StatusStrip anaStatus;
        private System.Windows.Forms.ToolStripStatusLabel anaStatusLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button export;
    }
}