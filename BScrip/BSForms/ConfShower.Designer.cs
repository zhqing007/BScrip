namespace BScrip.BSForms {
    partial class ConfShower {
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
            this.conftextb = new System.Windows.Forms.TextBox();
            this.upto = new System.Windows.Forms.Button();
            this.saveto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conftextb
            // 
            this.conftextb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.conftextb.BackColor = System.Drawing.SystemColors.Info;
            this.conftextb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.conftextb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.conftextb.Location = new System.Drawing.Point(12, 12);
            this.conftextb.Multiline = true;
            this.conftextb.Name = "conftextb";
            this.conftextb.ReadOnly = true;
            this.conftextb.Size = new System.Drawing.Size(584, 506);
            this.conftextb.TabIndex = 1;
            // 
            // upto
            // 
            this.upto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upto.Location = new System.Drawing.Point(491, 527);
            this.upto.Name = "upto";
            this.upto.Size = new System.Drawing.Size(105, 39);
            this.upto.TabIndex = 4;
            this.upto.Text = "上传到...";
            this.upto.UseVisualStyleBackColor = true;
            this.upto.Click += new System.EventHandler(this.upto_Click);
            // 
            // saveto
            // 
            this.saveto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveto.Location = new System.Drawing.Point(380, 527);
            this.saveto.Name = "saveto";
            this.saveto.Size = new System.Drawing.Size(105, 39);
            this.saveto.TabIndex = 3;
            this.saveto.Text = "另存为...";
            this.saveto.UseVisualStyleBackColor = true;
            this.saveto.Click += new System.EventHandler(this.saveto_Click);
            // 
            // ConfShower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 574);
            this.Controls.Add(this.upto);
            this.Controls.Add(this.saveto);
            this.Controls.Add(this.conftextb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfShower";
            this.Text = "ConfShower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox conftextb;
        private System.Windows.Forms.Button upto;
        private System.Windows.Forms.Button saveto;
    }
}