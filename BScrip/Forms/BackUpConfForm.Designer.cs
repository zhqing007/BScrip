using System.Windows.Forms;

namespace BScrip
{
    partial class BackUpConfForm
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
            this.getConfB_Local = new System.Windows.Forms.Button();
            this.DownHosts = new System.Windows.Forms.ListBox();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.selectAllHost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.getConfB_remote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getConfB_Local
            // 
            this.getConfB_Local.Location = new System.Drawing.Point(255, 394);
            this.getConfB_Local.Margin = new System.Windows.Forms.Padding(2);
            this.getConfB_Local.Name = "getConfB_Local";
            this.getConfB_Local.Size = new System.Drawing.Size(74, 24);
            this.getConfB_Local.TabIndex = 2;
            this.getConfB_Local.Text = "备份到本地";
            this.getConfB_Local.UseVisualStyleBackColor = true;
            this.getConfB_Local.Click += new System.EventHandler(this.getConfB_Local_Click);
            // 
            // DownHosts
            // 
            this.DownHosts.FormattingEnabled = true;
            this.DownHosts.ItemHeight = 12;
            this.DownHosts.Location = new System.Drawing.Point(84, 44);
            this.DownHosts.Margin = new System.Windows.Forms.Padding(2);
            this.DownHosts.Name = "DownHosts";
            this.DownHosts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DownHosts.Size = new System.Drawing.Size(383, 328);
            this.DownHosts.TabIndex = 10;
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(30, 44);
            this.moveRightButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(31, 90);
            this.moveRightButton.TabIndex = 11;
            this.moveRightButton.Text = ">>";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(30, 282);
            this.moveLeftButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(31, 90);
            this.moveLeftButton.TabIndex = 12;
            this.moveLeftButton.Text = "<<";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // selectAllHost
            // 
            this.selectAllHost.Location = new System.Drawing.Point(84, 394);
            this.selectAllHost.Margin = new System.Windows.Forms.Padding(2);
            this.selectAllHost.Name = "selectAllHost";
            this.selectAllHost.Size = new System.Drawing.Size(74, 24);
            this.selectAllHost.TabIndex = 15;
            this.selectAllHost.Text = "全选";
            this.selectAllHost.UseVisualStyleBackColor = true;
            this.selectAllHost.Click += new System.EventHandler(this.selectAllHost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "需要备份配置的交换机：";
            // 
            // getConfB_remote
            // 
            this.getConfB_remote.Location = new System.Drawing.Point(393, 394);
            this.getConfB_remote.Margin = new System.Windows.Forms.Padding(2);
            this.getConfB_remote.Name = "getConfB_remote";
            this.getConfB_remote.Size = new System.Drawing.Size(74, 24);
            this.getConfB_remote.TabIndex = 18;
            this.getConfB_remote.Text = "备份到远程";
            this.getConfB_remote.UseVisualStyleBackColor = true;
            this.getConfB_remote.Click += new System.EventHandler(this.getConfB_remote_Click);
            // 
            // BackUpConfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 464);
            this.Controls.Add(this.getConfB_remote);
            this.Controls.Add(this.getConfB_Local);
            this.Controls.Add(this.selectAllHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.DownHosts);
            this.Controls.Add(this.moveLeftButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BackUpConfForm";
            this.Text = "交换机配置备份";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getConfB_Local;
        private System.Windows.Forms.ListBox DownHosts;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button selectAllHost;
        private System.Windows.Forms.Label label2;
        private Button getConfB_remote;
    }
}

