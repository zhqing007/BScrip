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
            this.refreshinfobg = new System.ComponentModel.BackgroundWorker();
            this.memresourceschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cpuresourceschart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memresourceschart)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuresourceschart
            // 
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.Maximum = 20D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.cpuresourceschart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.cpuresourceschart.Legends.Add(legend1);
            this.cpuresourceschart.Location = new System.Drawing.Point(9, 117);
            this.cpuresourceschart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpuresourceschart.Name = "cpuresourceschart";
            this.cpuresourceschart.Size = new System.Drawing.Size(455, 223);
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
            this.devbaseinfo.Location = new System.Drawing.Point(9, 10);
            this.devbaseinfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.devbaseinfo.Multiline = true;
            this.devbaseinfo.Name = "devbaseinfo";
            this.devbaseinfo.ReadOnly = true;
            this.devbaseinfo.Size = new System.Drawing.Size(455, 96);
            this.devbaseinfo.TabIndex = 1;
            // 
            // refreshinfobg
            // 
            this.refreshinfobg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.refreshinfobg_DoWork);
            // 
            // memresourceschart
            // 
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.AxisX.Maximum = 20D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.memresourceschart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.memresourceschart.Legends.Add(legend2);
            this.memresourceschart.Location = new System.Drawing.Point(9, 354);
            this.memresourceschart.Margin = new System.Windows.Forms.Padding(2);
            this.memresourceschart.Name = "memresourceschart";
            this.memresourceschart.Size = new System.Drawing.Size(455, 223);
            this.memresourceschart.TabIndex = 2;
            this.memresourceschart.Text = "chart1";
            // 
            // DeviceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 595);
            this.Controls.Add(this.memresourceschart);
            this.Controls.Add(this.devbaseinfo);
            this.Controls.Add(this.cpuresourceschart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeviceViewer";
            this.Text = "SwitchControler";
            ((System.ComponentModel.ISupportInitialize)(this.cpuresourceschart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memresourceschart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cpuresourceschart;
        private System.ComponentModel.BackgroundWorker loadbasebg;
        private System.Windows.Forms.TextBox devbaseinfo;
        private System.ComponentModel.BackgroundWorker refreshinfobg;
        private System.Windows.Forms.DataVisualization.Charting.Chart memresourceschart;

    }
}