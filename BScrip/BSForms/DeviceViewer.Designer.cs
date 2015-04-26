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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.cpuresourceschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadbasebg = new System.ComponentModel.BackgroundWorker();
            this.devbaseinfo = new System.Windows.Forms.TextBox();
            this.refreshinfobg = new System.ComponentModel.BackgroundWorker();
            this.memresourceschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.devicebasemsg = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.interfaceGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.cpuresourceschart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memresourceschart)).BeginInit();
            this.devicebasemsg.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpuresourceschart
            // 
            this.cpuresourceschart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea5.AxisX.Interval = 10D;
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisX.MajorGrid.Interval = 10D;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisX.MajorTickMark.Interval = 5D;
            chartArea5.AxisX.Maximum = 100D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea5.AxisY.Interval = 10D;
            chartArea5.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisY.IsInterlaced = true;
            chartArea5.AxisY.MajorGrid.Interval = 10D;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.MajorTickMark.Interval = 5D;
            chartArea5.AxisY.Maximum = 100D;
            chartArea5.Name = "ChartArea1";
            this.cpuresourceschart.ChartAreas.Add(chartArea5);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Name = "Legend1";
            this.cpuresourceschart.Legends.Add(legend5);
            this.cpuresourceschart.Location = new System.Drawing.Point(6, 45);
            this.cpuresourceschart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpuresourceschart.Name = "cpuresourceschart";
            this.cpuresourceschart.Size = new System.Drawing.Size(777, 366);
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
            this.devbaseinfo.BackColor = System.Drawing.SystemColors.Control;
            this.devbaseinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.devbaseinfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.devbaseinfo.Location = new System.Drawing.Point(3, 36);
            this.devbaseinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.devbaseinfo.Multiline = true;
            this.devbaseinfo.Name = "devbaseinfo";
            this.devbaseinfo.ReadOnly = true;
            this.devbaseinfo.Size = new System.Drawing.Size(451, 119);
            this.devbaseinfo.TabIndex = 1;
            // 
            // refreshinfobg
            // 
            this.refreshinfobg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.refreshinfobg_DoWork);
            // 
            // memresourceschart
            // 
            this.memresourceschart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea6.AxisX.Interval = 10D;
            chartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisX.MajorGrid.Interval = 10D;
            chartArea6.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.AxisX.MajorTickMark.Interval = 5D;
            chartArea6.AxisX.Maximum = 100D;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea6.AxisY.Interval = 10D;
            chartArea6.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisY.IsInterlaced = true;
            chartArea6.AxisY.MajorGrid.Interval = 10D;
            chartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.AxisY.MajorTickMark.Interval = 5D;
            chartArea6.AxisY.Maximum = 100D;
            chartArea6.Name = "ChartArea1";
            this.memresourceschart.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Name = "Legend1";
            this.memresourceschart.Legends.Add(legend6);
            this.memresourceschart.Location = new System.Drawing.Point(6, 45);
            this.memresourceschart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memresourceschart.Name = "memresourceschart";
            this.memresourceschart.Size = new System.Drawing.Size(777, 366);
            this.memresourceschart.TabIndex = 2;
            this.memresourceschart.Text = "chart1";
            // 
            // devicebasemsg
            // 
            this.devicebasemsg.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.devicebasemsg.Controls.Add(this.tabPage1);
            this.devicebasemsg.Controls.Add(this.tabPage2);
            this.devicebasemsg.Controls.Add(this.tabPage3);
            this.devicebasemsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicebasemsg.Location = new System.Drawing.Point(0, 0);
            this.devicebasemsg.Name = "devicebasemsg";
            this.devicebasemsg.SelectedIndex = 0;
            this.devicebasemsg.Size = new System.Drawing.Size(797, 535);
            this.devicebasemsg.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.interfaceGridView);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.devbaseinfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
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
            this.interfaceGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.interfaceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interfaceGridView.Location = new System.Drawing.Point(6, 189);
            this.interfaceGridView.Name = "interfaceGridView";
            this.interfaceGridView.ReadOnly = true;
            this.interfaceGridView.RowTemplate.Height = 27;
            this.interfaceGridView.Size = new System.Drawing.Size(777, 311);
            this.interfaceGridView.TabIndex = 3;
            this.interfaceGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.interfaceGridView_CellPainting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "设备基本信息：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.cpuresourceschart);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CPU占用率";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.memresourceschart);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 497);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "内存占用率";
            // 
            // DeviceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 535);
            this.Controls.Add(this.devicebasemsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeviceViewer";
            this.Text = "设备信息及状态";
            ((System.ComponentModel.ISupportInitialize)(this.cpuresourceschart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memresourceschart)).EndInit();
            this.devicebasemsg.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cpuresourceschart;
        private System.ComponentModel.BackgroundWorker loadbasebg;
        private System.Windows.Forms.TextBox devbaseinfo;
        private System.ComponentModel.BackgroundWorker refreshinfobg;
        private System.Windows.Forms.DataVisualization.Charting.Chart memresourceschart;
        private System.Windows.Forms.TabControl devicebasemsg;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView interfaceGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;

    }
}