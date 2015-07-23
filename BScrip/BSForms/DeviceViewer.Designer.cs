namespace BScrip.BSForms {
    partial class DeviceViewer {
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
            this.backupinfo = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.monthPicker = new System.Windows.Forms.DateTimePicker();
            this.removehostButton = new System.Windows.Forms.Button();
            this.addhostButton = new System.Windows.Forms.Button();
            this.resutilizelist_v = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.slotlistview = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timespanset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backupinfo
            // 
            this.backupinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backupinfo.Location = new System.Drawing.Point(269, 398);
            this.backupinfo.Name = "backupinfo";
            this.backupinfo.Size = new System.Drawing.Size(75, 23);
            this.backupinfo.TabIndex = 8;
            this.backupinfo.Text = "备份情况";
            this.backupinfo.UseVisualStyleBackColor = true;
            this.backupinfo.Click += new System.EventHandler(this.backupinfo_Click);
            // 
            // export
            // 
            this.export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.export.Location = new System.Drawing.Point(437, 398);
            this.export.Margin = new System.Windows.Forms.Padding(2);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 7;
            this.export.Text = "导出";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // monthPicker
            // 
            this.monthPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monthPicker.CustomFormat = "yyyy年MM月";
            this.monthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthPicker.Location = new System.Drawing.Point(39, 398);
            this.monthPicker.Margin = new System.Windows.Forms.Padding(2);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.ShowUpDown = true;
            this.monthPicker.Size = new System.Drawing.Size(105, 21);
            this.monthPicker.TabIndex = 6;
            // 
            // removehostButton
            // 
            this.removehostButton.Location = new System.Drawing.Point(6, 106);
            this.removehostButton.Name = "removehostButton";
            this.removehostButton.Size = new System.Drawing.Size(26, 87);
            this.removehostButton.TabIndex = 5;
            this.removehostButton.Text = "<<";
            this.removehostButton.UseVisualStyleBackColor = true;
            this.removehostButton.Click += new System.EventHandler(this.removehostButton_Click);
            // 
            // addhostButton
            // 
            this.addhostButton.Location = new System.Drawing.Point(6, 12);
            this.addhostButton.Name = "addhostButton";
            this.addhostButton.Size = new System.Drawing.Size(26, 87);
            this.addhostButton.TabIndex = 4;
            this.addhostButton.Text = ">>";
            this.addhostButton.UseVisualStyleBackColor = true;
            this.addhostButton.Click += new System.EventHandler(this.addhostButton_Click);
            // 
            // resutilizelist_v
            // 
            this.resutilizelist_v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resutilizelist_v.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.resutilizelist_v.FullRowSelect = true;
            this.resutilizelist_v.Location = new System.Drawing.Point(38, 12);
            this.resutilizelist_v.Name = "resutilizelist_v";
            this.resutilizelist_v.Size = new System.Drawing.Size(474, 242);
            this.resutilizelist_v.TabIndex = 3;
            this.resutilizelist_v.UseCompatibleStateImageBehavior = false;
            this.resutilizelist_v.View = System.Windows.Forms.View.Details;
            this.resutilizelist_v.SelectedIndexChanged += new System.EventHandler(this.resutilizelist_v_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "设备名称";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP地址";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CPU月均使用率";
            this.columnHeader4.Width = 132;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MEM月均使用率";
            this.columnHeader5.Width = 90;
            // 
            // slotlistview
            // 
            this.slotlistview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slotlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.slotlistview.Location = new System.Drawing.Point(38, 260);
            this.slotlistview.Name = "slotlistview";
            this.slotlistview.Size = new System.Drawing.Size(474, 125);
            this.slotlistview.TabIndex = 9;
            this.slotlistview.UseCompatibleStateImageBehavior = false;
            this.slotlistview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "序号";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "卡槽名称";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CPU月均使用率";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MEM月均使用率";
            this.columnHeader9.Width = 100;
            // 
            // timespanset
            // 
            this.timespanset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timespanset.Location = new System.Drawing.Point(353, 398);
            this.timespanset.Name = "timespanset";
            this.timespanset.Size = new System.Drawing.Size(75, 23);
            this.timespanset.TabIndex = 10;
            this.timespanset.Text = "统计设置";
            this.timespanset.UseVisualStyleBackColor = true;
            this.timespanset.Click += new System.EventHandler(this.timespanset_Click);
            // 
            // DeviceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 432);
            this.Controls.Add(this.timespanset);
            this.Controls.Add(this.slotlistview);
            this.Controls.Add(this.backupinfo);
            this.Controls.Add(this.export);
            this.Controls.Add(this.monthPicker);
            this.Controls.Add(this.removehostButton);
            this.Controls.Add(this.addhostButton);
            this.Controls.Add(this.resutilizelist_v);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeviceViewer";
            this.Text = "设备信息及状态";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView resutilizelist_v;
        private System.Windows.Forms.Button removehostButton;
        private System.Windows.Forms.Button addhostButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DateTimePicker monthPicker;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button backupinfo;
        private System.Windows.Forms.ListView slotlistview;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button timespanset;

    }
}