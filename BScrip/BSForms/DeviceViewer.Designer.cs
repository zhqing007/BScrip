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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.cpuresourceschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadbasebg = new System.ComponentModel.BackgroundWorker();
            this.devbaseinfo = new System.Windows.Forms.TextBox();
            this.memresourceschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.devicebasemsg = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stop_cpu = new System.Windows.Forms.Button();
            this.begin_cpu = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.stop_mem = new System.Windows.Forms.Button();
            this.begin_mem = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.interfaceGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.resutilizelist_v = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cpuresourceschart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memresourceschart)).BeginInit();
            this.devicebasemsg.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.cpuresourceschart.Location = new System.Drawing.Point(69, 0);
            this.cpuresourceschart.Margin = new System.Windows.Forms.Padding(2);
            this.cpuresourceschart.Name = "cpuresourceschart";
            this.cpuresourceschart.Size = new System.Drawing.Size(691, 198);
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
            this.devbaseinfo.Margin = new System.Windows.Forms.Padding(2);
            this.devbaseinfo.Multiline = true;
            this.devbaseinfo.Name = "devbaseinfo";
            this.devbaseinfo.ReadOnly = true;
            this.devbaseinfo.Size = new System.Drawing.Size(567, 69);
            this.devbaseinfo.TabIndex = 1;
            // 
            // memresourceschart
            // 
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.Interval = 10D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.MajorGrid.Interval = 10D;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MajorTickMark.Interval = 5D;
            chartArea2.AxisX.Maximum = 100D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisY.Interval = 10D;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IsInterlaced = true;
            chartArea2.AxisY.MajorGrid.Interval = 10D;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorTickMark.Interval = 5D;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.Name = "ChartArea1";
            this.memresourceschart.ChartAreas.Add(chartArea2);
            this.memresourceschart.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.memresourceschart.Legends.Add(legend2);
            this.memresourceschart.Location = new System.Drawing.Point(2, 2);
            this.memresourceschart.Margin = new System.Windows.Forms.Padding(2);
            this.memresourceschart.Name = "memresourceschart";
            this.memresourceschart.Size = new System.Drawing.Size(763, 293);
            this.memresourceschart.TabIndex = 2;
            this.memresourceschart.Text = "chart1";
            // 
            // devicebasemsg
            // 
            this.devicebasemsg.Controls.Add(this.tabPage2);
            this.devicebasemsg.Controls.Add(this.tabPage3);
            this.devicebasemsg.Controls.Add(this.tabPage1);
            this.devicebasemsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicebasemsg.Location = new System.Drawing.Point(0, 0);
            this.devicebasemsg.Margin = new System.Windows.Forms.Padding(2);
            this.devicebasemsg.Name = "devicebasemsg";
            this.devicebasemsg.SelectedIndex = 0;
            this.devicebasemsg.Size = new System.Drawing.Size(775, 536);
            this.devicebasemsg.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.resutilizelist_v);
            this.tabPage2.Controls.Add(this.stop_cpu);
            this.tabPage2.Controls.Add(this.begin_cpu);
            this.tabPage2.Controls.Add(this.cpuresourceschart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(767, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CPU占用率";
            // 
            // stop_cpu
            // 
            this.stop_cpu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stop_cpu.Location = new System.Drawing.Point(697, 468);
            this.stop_cpu.Margin = new System.Windows.Forms.Padding(2);
            this.stop_cpu.Name = "stop_cpu";
            this.stop_cpu.Size = new System.Drawing.Size(63, 24);
            this.stop_cpu.TabIndex = 2;
            this.stop_cpu.Text = "停止监控";
            this.stop_cpu.UseVisualStyleBackColor = true;
            this.stop_cpu.Click += new System.EventHandler(this.stop_cpu_Click);
            // 
            // begin_cpu
            // 
            this.begin_cpu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.begin_cpu.Location = new System.Drawing.Point(601, 468);
            this.begin_cpu.Margin = new System.Windows.Forms.Padding(2);
            this.begin_cpu.Name = "begin_cpu";
            this.begin_cpu.Size = new System.Drawing.Size(63, 24);
            this.begin_cpu.TabIndex = 1;
            this.begin_cpu.Text = "开始监控";
            this.begin_cpu.UseVisualStyleBackColor = true;
            this.begin_cpu.Click += new System.EventHandler(this.begin_cpu_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.tabPage3.Controls.Add(this.stop_mem);
            this.tabPage3.Controls.Add(this.begin_mem);
            this.tabPage3.Controls.Add(this.memresourceschart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(767, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "内存占用率";
            // 
            // stop_mem
            // 
            this.stop_mem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stop_mem.Location = new System.Drawing.Point(618, 334);
            this.stop_mem.Margin = new System.Windows.Forms.Padding(2);
            this.stop_mem.Name = "stop_mem";
            this.stop_mem.Size = new System.Drawing.Size(63, 24);
            this.stop_mem.TabIndex = 4;
            this.stop_mem.Text = "停止监控";
            this.stop_mem.UseVisualStyleBackColor = true;
            this.stop_mem.Click += new System.EventHandler(this.stop_mem_Click);
            // 
            // begin_mem
            // 
            this.begin_mem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.begin_mem.Location = new System.Drawing.Point(618, 298);
            this.begin_mem.Margin = new System.Windows.Forms.Padding(2);
            this.begin_mem.Name = "begin_mem";
            this.begin_mem.Size = new System.Drawing.Size(63, 24);
            this.begin_mem.TabIndex = 3;
            this.begin_mem.Text = "开始监控";
            this.begin_mem.UseVisualStyleBackColor = true;
            this.begin_mem.Click += new System.EventHandler(this.begin_mem_Click);
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(672, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本信息";
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.Location = new System.Drawing.Point(534, 97);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
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
            this.interfaceGridView.Margin = new System.Windows.Forms.Padding(2);
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
            // resutilizelist_v
            // 
            this.resutilizelist_v.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.resutilizelist_v.Location = new System.Drawing.Point(69, 203);
            this.resutilizelist_v.Name = "resutilizelist_v";
            this.resutilizelist_v.Size = new System.Drawing.Size(691, 207);
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
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP地址";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CPU月均使用率";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MEM月均使用率";
            this.columnHeader5.Width = 90;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 158);
            this.button1.TabIndex = 4;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 158);
            this.button2.TabIndex = 5;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DeviceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 536);
            this.Controls.Add(this.devicebasemsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeviceViewer";
            this.Text = "设备信息及状态";
            ((System.ComponentModel.ISupportInitialize)(this.cpuresourceschart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memresourceschart)).EndInit();
            this.devicebasemsg.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cpuresourceschart;
        private System.ComponentModel.BackgroundWorker loadbasebg;
        private System.Windows.Forms.TextBox devbaseinfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart memresourceschart;
        private System.Windows.Forms.TabControl devicebasemsg;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView interfaceGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button begin_cpu;
        private System.Windows.Forms.Button stop_cpu;
        private System.Windows.Forms.Button stop_mem;
        private System.Windows.Forms.Button begin_mem;
        private System.Windows.Forms.ListView resutilizelist_v;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;

    }
}