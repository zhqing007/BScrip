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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.cpuresourceschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadbasebg = new System.ComponentModel.BackgroundWorker();
            this.devbaseinfo = new System.Windows.Forms.TextBox();
            this.devicebasemsg = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.interfaceGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backupinfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cpuresourceschart)).BeginInit();
            this.devicebasemsg.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuresourceschart
            // 
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.Interval = 10D;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.Interval = 5D;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsInterlaced = true;
            chartArea1.AxisY.MajorGrid.Interval = 10D;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.Interval = 5D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.Name = "ChartArea1";
            this.cpuresourceschart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.cpuresourceschart.Legends.Add(legend1);
            this.cpuresourceschart.Location = new System.Drawing.Point(38, 0);
            this.cpuresourceschart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpuresourceschart.Name = "cpuresourceschart";
            this.cpuresourceschart.Size = new System.Drawing.Size(460, 145);
            this.cpuresourceschart.TabIndex = 0;
            this.cpuresourceschart.Text = "chart1";
            // 
            // loadbasebg
            // 
            this.loadbasebg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bGWorker_DoWork);
            this.loadbasebg.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bGWorker_RunWorkerCompleted);
            // 
            // devbaseinfo
            // 
            this.devbaseinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.devbaseinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.devbaseinfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.devbaseinfo.Location = new System.Drawing.Point(8, 25);
            this.devbaseinfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.devbaseinfo.Multiline = true;
            this.devbaseinfo.Name = "devbaseinfo";
            this.devbaseinfo.ReadOnly = true;
            this.devbaseinfo.Size = new System.Drawing.Size(567, 69);
            this.devbaseinfo.TabIndex = 1;
            // 
            // devicebasemsg
            // 
            this.devicebasemsg.Controls.Add(this.tabPage2);
            this.devicebasemsg.Controls.Add(this.tabPage1);
            this.devicebasemsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicebasemsg.Location = new System.Drawing.Point(0, 0);
            this.devicebasemsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.devicebasemsg.Name = "devicebasemsg";
            this.devicebasemsg.SelectedIndex = 0;
            this.devicebasemsg.Size = new System.Drawing.Size(628, 544);
            this.devicebasemsg.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.tabPage2.Controls.Add(this.backupinfo);
            this.tabPage2.Controls.Add(this.export);
            this.tabPage2.Controls.Add(this.monthPicker);
            this.tabPage2.Controls.Add(this.removehostButton);
            this.tabPage2.Controls.Add(this.addhostButton);
            this.tabPage2.Controls.Add(this.resutilizelist_v);
            this.tabPage2.Controls.Add(this.cpuresourceschart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(620, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CPU占用率";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(407, 434);
            this.export.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(90, 20);
            this.export.TabIndex = 7;
            this.export.Text = "导出";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // monthPicker
            // 
            this.monthPicker.CustomFormat = "yyyy年MM月";
            this.monthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthPicker.Location = new System.Drawing.Point(38, 434);
            this.monthPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.ShowUpDown = true;
            this.monthPicker.Size = new System.Drawing.Size(105, 21);
            this.monthPicker.TabIndex = 6;
            // 
            // removehostButton
            // 
            this.removehostButton.Location = new System.Drawing.Point(7, 98);
            this.removehostButton.Name = "removehostButton";
            this.removehostButton.Size = new System.Drawing.Size(26, 87);
            this.removehostButton.TabIndex = 5;
            this.removehostButton.Text = "<<";
            this.removehostButton.UseVisualStyleBackColor = true;
            this.removehostButton.Click += new System.EventHandler(this.removehostButton_Click);
            // 
            // addhostButton
            // 
            this.addhostButton.Location = new System.Drawing.Point(7, 5);
            this.addhostButton.Name = "addhostButton";
            this.addhostButton.Size = new System.Drawing.Size(26, 87);
            this.addhostButton.TabIndex = 4;
            this.addhostButton.Text = ">>";
            this.addhostButton.UseVisualStyleBackColor = true;
            this.addhostButton.Click += new System.EventHandler(this.addhostButton_Click);
            // 
            // resutilizelist_v
            // 
            this.resutilizelist_v.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.resutilizelist_v.Location = new System.Drawing.Point(39, 150);
            this.resutilizelist_v.Name = "resutilizelist_v";
            this.resutilizelist_v.Size = new System.Drawing.Size(459, 279);
            this.resutilizelist_v.TabIndex = 3;
            this.resutilizelist_v.UseCompatibleStateImageBehavior = false;
            this.resutilizelist_v.View = System.Windows.Forms.View.Details;
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.tabPage1.Controls.Add(this.refresh);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.interfaceGridView);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.devbaseinfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(502, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本信息";
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.Location = new System.Drawing.Point(534, 97);
            this.refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(49, 27);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "接口信息：";
            // 
            // interfaceGridView
            // 
            this.interfaceGridView.AllowUserToAddRows = false;
            this.interfaceGridView.AllowUserToDeleteRows = false;
            this.interfaceGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.interfaceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interfaceGridView.Location = new System.Drawing.Point(4, 128);
            this.interfaceGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.interfaceGridView.Name = "interfaceGridView";
            this.interfaceGridView.ReadOnly = true;
            this.interfaceGridView.RowTemplate.Height = 27;
            this.interfaceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.interfaceGridView.Size = new System.Drawing.Size(583, 239);
            this.interfaceGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "设备基本信息：";
            // 
            // backupinfo
            // 
            this.backupinfo.Location = new System.Drawing.Point(301, 443);
            this.backupinfo.Name = "backupinfo";
            this.backupinfo.Size = new System.Drawing.Size(75, 23);
            this.backupinfo.TabIndex = 8;
            this.backupinfo.Text = "backupinfo";
            this.backupinfo.UseVisualStyleBackColor = true;
            this.backupinfo.Click += new System.EventHandler(this.backupinfo_Click);
            // 
            // DeviceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 544);
            this.Controls.Add(this.devicebasemsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeviceViewer";
            this.Text = "设备信息及状态";
            ((System.ComponentModel.ISupportInitialize)(this.cpuresourceschart)).EndInit();
            this.devicebasemsg.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cpuresourceschart;
        private System.ComponentModel.BackgroundWorker loadbasebg;
        private System.Windows.Forms.TextBox devbaseinfo;
        private System.Windows.Forms.TabControl devicebasemsg;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView interfaceGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refresh;
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

    }
}