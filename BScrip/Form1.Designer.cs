namespace BScrip
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.executeButton = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.XMLHosts = new System.Windows.Forms.ListBox();
            this.DownHosts = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(251, 200);
            this.executeButton.Margin = new System.Windows.Forms.Padding(2);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(56, 18);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.Execute_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(37, 194);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(71, 30);
            this.add.TabIndex = 8;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // XMLHosts
            // 
            this.XMLHosts.FormattingEnabled = true;
            this.XMLHosts.ItemHeight = 12;
            this.XMLHosts.Location = new System.Drawing.Point(37, 18);
            this.XMLHosts.Margin = new System.Windows.Forms.Padding(2);
            this.XMLHosts.Name = "XMLHosts";
            this.XMLHosts.Size = new System.Drawing.Size(190, 160);
            this.XMLHosts.TabIndex = 9;
            this.XMLHosts.DoubleClick += new System.EventHandler(this.XMLHosts_DoubleClick);
            // 
            // DownHosts
            // 
            this.DownHosts.FormattingEnabled = true;
            this.DownHosts.ItemHeight = 12;
            this.DownHosts.Location = new System.Drawing.Point(334, 18);
            this.DownHosts.Margin = new System.Windows.Forms.Padding(2);
            this.DownHosts.Name = "DownHosts";
            this.DownHosts.Size = new System.Drawing.Size(195, 160);
            this.DownHosts.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 59);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 18);
            this.button4.TabIndex = 11;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 122);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 18);
            this.button5.TabIndex = 12;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 419);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DownHosts);
            this.Controls.Add(this.XMLHosts);
            this.Controls.Add(this.add);
            this.Controls.Add(this.executeButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox XMLHosts;
        private System.Windows.Forms.ListBox DownHosts;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

