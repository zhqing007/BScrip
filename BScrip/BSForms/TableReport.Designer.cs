namespace BScrip.BSForms {
    partial class TableReport {
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
            this.label6 = new System.Windows.Forms.Label();
            this.moveRightB_t = new System.Windows.Forms.Button();
            this.moveLeftB_t = new System.Windows.Forms.Button();
            this.deviceList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backupAna = new System.Windows.Forms.Button();
            this.monthAna = new System.Windows.Forms.Button();
            this.errorAna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "需要统计的设备：";
            // 
            // moveRightB_t
            // 
            this.moveRightB_t.Location = new System.Drawing.Point(12, 28);
            this.moveRightB_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveRightB_t.Name = "moveRightB_t";
            this.moveRightB_t.Size = new System.Drawing.Size(35, 109);
            this.moveRightB_t.TabIndex = 33;
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
            this.moveLeftB_t.TabIndex = 34;
            this.moveLeftB_t.Text = "<<";
            this.moveLeftB_t.UseVisualStyleBackColor = true;
            this.moveLeftB_t.Click += new System.EventHandler(this.moveLeftB_t_Click);
            // 
            // deviceList
            // 
            this.deviceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.deviceList.FullRowSelect = true;
            this.deviceList.Location = new System.Drawing.Point(52, 28);
            this.deviceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(710, 302);
            this.deviceList.TabIndex = 32;
            this.deviceList.UseCompatibleStateImageBehavior = false;
            this.deviceList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "主机名";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP地址";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "登录名";
            this.columnHeader3.Width = 145;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "登录方式";
            this.columnHeader4.Width = 90;
            // 
            // backupAna
            // 
            this.backupAna.Location = new System.Drawing.Point(36, 364);
            this.backupAna.Name = "backupAna";
            this.backupAna.Size = new System.Drawing.Size(100, 34);
            this.backupAna.TabIndex = 36;
            this.backupAna.Text = "备份统计";
            this.backupAna.UseVisualStyleBackColor = true;
            this.backupAna.Click += new System.EventHandler(this.backupAna_Click);
            // 
            // monthAna
            // 
            this.monthAna.Location = new System.Drawing.Point(174, 364);
            this.monthAna.Name = "monthAna";
            this.monthAna.Size = new System.Drawing.Size(100, 34);
            this.monthAna.TabIndex = 37;
            this.monthAna.Text = "月度分析";
            this.monthAna.UseVisualStyleBackColor = true;
            // 
            // errorAna
            // 
            this.errorAna.Location = new System.Drawing.Point(319, 364);
            this.errorAna.Name = "errorAna";
            this.errorAna.Size = new System.Drawing.Size(100, 34);
            this.errorAna.TabIndex = 38;
            this.errorAna.Text = "故障率统计";
            this.errorAna.UseVisualStyleBackColor = true;
            // 
            // TableReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 563);
            this.Controls.Add(this.errorAna);
            this.Controls.Add(this.monthAna);
            this.Controls.Add(this.backupAna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moveRightB_t);
            this.Controls.Add(this.moveLeftB_t);
            this.Controls.Add(this.deviceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TableReport";
            this.Text = "报表统计";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button moveRightB_t;
        private System.Windows.Forms.Button moveLeftB_t;
        private System.Windows.Forms.ListView deviceList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button backupAna;
        private System.Windows.Forms.Button monthAna;
        private System.Windows.Forms.Button errorAna;
    }
}