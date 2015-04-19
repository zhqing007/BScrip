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
            this.refreshinfobg = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.cpuresourceschart)).BeginInit();
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
            legend1.Name = "Legend1";
            this.cpuresourceschart.Legends.Add(legend1);
            this.cpuresourceschart.Location = new System.Drawing.Point(12, 146);
            this.cpuresourceschart.Name = "cpuresourceschart";
            this.cpuresourceschart.Size = new System.Drawing.Size(475, 279);
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
            this.devbaseinfo.Location = new System.Drawing.Point(12, 12);
            this.devbaseinfo.Multiline = true;
            this.devbaseinfo.Name = "devbaseinfo";
            this.devbaseinfo.ReadOnly = true;
            this.devbaseinfo.Size = new System.Drawing.Size(605, 119);
            this.devbaseinfo.TabIndex = 1;
            // 
            // refreshinfobg
            // 
            this.refreshinfobg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.refreshinfobg_DoWork);
            // 
            // DeviceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 646);
            this.Controls.Add(this.devbaseinfo);
            this.Controls.Add(this.cpuresourceschart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeviceViewer";
            this.Text = "SwitchControler";
            ((System.ComponentModel.ISupportInitialize)(this.cpuresourceschart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cpuresourceschart;
        private System.ComponentModel.BackgroundWorker loadbasebg;
        private System.Windows.Forms.TextBox devbaseinfo;
        private System.ComponentModel.BackgroundWorker refreshinfobg;

    }
}