﻿namespace BScrip {
    partial class HostsForm {
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
            this.selectAllHosts = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HostView
            // 
            this.HostView.Dock = System.Windows.Forms.DockStyle.Top;
            this.HostView.FullRowSelect = true;
            this.HostView.HideSelection = false;
            this.HostView.Location = new System.Drawing.Point(0, 0);
            this.HostView.Margin = new System.Windows.Forms.Padding(4);
            this.HostView.Name = "HostView";
            this.HostView.Size = new System.Drawing.Size(268, 622);
            this.HostView.TabIndex = 23;
            this.HostView.UseCompatibleStateImageBehavior = false;
            this.HostView.View = System.Windows.Forms.View.Details;
            this.HostView.DoubleClick += new System.EventHandler(this.HostView_DoubleClick);
            // 
            // selectAllHosts
            // 
            this.selectAllHosts.Location = new System.Drawing.Point(6, 628);
            this.selectAllHosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectAllHosts.Name = "selectAllHosts";
            this.selectAllHosts.Size = new System.Drawing.Size(80, 30);
            this.selectAllHosts.TabIndex = 21;
            this.selectAllHosts.Text = "全选";
            this.selectAllHosts.UseVisualStyleBackColor = true;
            this.selectAllHosts.Click += new System.EventHandler(this.selectAllHosts_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(178, 628);
            this.del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(80, 30);
            this.del.TabIndex = 20;
            this.del.Text = "删除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(92, 628);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(80, 30);
            this.add.TabIndex = 19;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // HostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 664);
            this.ControlBox = false;
            this.Controls.Add(this.HostView);
            this.Controls.Add(this.selectAllHosts);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HostsForm";
            this.Text = "HostsForm";
            this.Resize += new System.EventHandler(this.HostsForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView HostView;
        private System.Windows.Forms.Button selectAllHosts;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
    }
}