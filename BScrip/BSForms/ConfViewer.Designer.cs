namespace BScrip.BSForms {
    partial class ConfViewer {
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
            this.components = new System.ComponentModel.Container();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.beginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hostinfotb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.configlist = new System.Windows.Forms.ListBox();
            this.upto = new System.Windows.Forms.Button();
            this.saveto = new System.Windows.Forms.Button();
            this.confrichtb = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // endTimePicker
            // 
            this.endTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.endTimePicker.Location = new System.Drawing.Point(261, 666);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(184, 25);
            this.endTimePicker.TabIndex = 3;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // beginTimePicker
            // 
            this.beginTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.beginTimePicker.Location = new System.Drawing.Point(37, 666);
            this.beginTimePicker.Name = "beginTimePicker";
            this.beginTimePicker.Size = new System.Drawing.Size(184, 25);
            this.beginTimePicker.TabIndex = 4;
            this.beginTimePicker.ValueChanged += new System.EventHandler(this.beginTimePicker_ValueChanged);
            // 
            // hostinfotb
            // 
            this.hostinfotb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.hostinfotb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hostinfotb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hostinfotb.Location = new System.Drawing.Point(12, 15);
            this.hostinfotb.Name = "hostinfotb";
            this.hostinfotb.ReadOnly = true;
            this.hostinfotb.Size = new System.Drawing.Size(857, 23);
            this.hostinfotb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 672);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "启：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "终：";
            // 
            // configlist
            // 
            this.configlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.configlist.FormattingEnabled = true;
            this.configlist.ItemHeight = 15;
            this.configlist.Location = new System.Drawing.Point(12, 51);
            this.configlist.Name = "configlist";
            this.configlist.Size = new System.Drawing.Size(213, 604);
            this.configlist.TabIndex = 9;
            this.configlist.SelectedIndexChanged += new System.EventHandler(this.datelist_SelectedIndexChanged);
            // 
            // upto
            // 
            this.upto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upto.Location = new System.Drawing.Point(764, 665);
            this.upto.Name = "upto";
            this.upto.Size = new System.Drawing.Size(105, 30);
            this.upto.TabIndex = 12;
            this.upto.Text = "上传到...";
            this.upto.UseVisualStyleBackColor = true;
            this.upto.Click += new System.EventHandler(this.upto_Click);
            // 
            // saveto
            // 
            this.saveto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveto.Location = new System.Drawing.Point(653, 665);
            this.saveto.Name = "saveto";
            this.saveto.Size = new System.Drawing.Size(105, 30);
            this.saveto.TabIndex = 11;
            this.saveto.Text = "另存为...";
            this.saveto.UseVisualStyleBackColor = true;
            this.saveto.Click += new System.EventHandler(this.saveto_Click);
            // 
            // confrichtb
            // 
            this.confrichtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.confrichtb.BackColor = System.Drawing.SystemColors.Info;
            this.confrichtb.ContextMenuStrip = this.contextMenuStrip1;
            this.confrichtb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confrichtb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.confrichtb.Location = new System.Drawing.Point(233, 51);
            this.confrichtb.Name = "confrichtb";
            this.confrichtb.ReadOnly = true;
            this.confrichtb.Size = new System.Drawing.Size(636, 604);
            this.confrichtb.TabIndex = 13;
            this.confrichtb.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuCopy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // contextMenuCopy
            // 
            this.contextMenuCopy.Name = "contextMenuCopy";
            this.contextMenuCopy.Size = new System.Drawing.Size(108, 24);
            this.contextMenuCopy.Text = "复制";
            this.contextMenuCopy.Click += new System.EventHandler(this.contextMenuCopy_Click);
            // 
            // ConfViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 703);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.beginTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confrichtb);
            this.Controls.Add(this.upto);
            this.Controls.Add(this.saveto);
            this.Controls.Add(this.configlist);
            this.Controls.Add(this.hostinfotb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfViewer";
            this.Text = "配置查询";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker beginTimePicker;
        private System.Windows.Forms.TextBox hostinfotb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox configlist;
        private System.Windows.Forms.Button upto;
        private System.Windows.Forms.Button saveto;
        private System.Windows.Forms.RichTextBox confrichtb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCopy;
    }
}