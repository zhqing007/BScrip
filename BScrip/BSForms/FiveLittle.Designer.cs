﻿namespace BScrip.BSForms {
    partial class FiveLittle {
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
            this.HostView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HostView
            // 
            this.HostView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.HostView.FullRowSelect = true;
            this.HostView.HideSelection = false;
            this.HostView.Location = new System.Drawing.Point(0, 0);
            this.HostView.Margin = new System.Windows.Forms.Padding(4);
            this.HostView.Name = "HostView";
            this.HostView.Size = new System.Drawing.Size(355, 611);
            this.HostView.TabIndex = 23;
            this.HostView.UseCompatibleStateImageBehavior = false;
            this.HostView.View = System.Windows.Forms.View.Details;
            this.HostView.DoubleClick += new System.EventHandler(this.modifyHost_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "备份配置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FiveLittle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(355, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HostView);
            this.Name = "FiveLittle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备信息";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView HostView;
        private System.Windows.Forms.Button button1;
    }
}