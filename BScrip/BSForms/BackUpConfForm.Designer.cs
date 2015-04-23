using System.Windows.Forms;

namespace BScrip.BSForms
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
            this.DownHosts = new System.Windows.Forms.ListView();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.selectAllHost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selserver = new System.Windows.Forms.Button();
            this.isUpLoad = new System.Windows.Forms.CheckBox();
            this.remoser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getConfB_Local
            // 
            this.getConfB_Local.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getConfB_Local.Location = new System.Drawing.Point(157, 359);
            this.getConfB_Local.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getConfB_Local.Name = "getConfB_Local";
            this.getConfB_Local.Size = new System.Drawing.Size(99, 30);
            this.getConfB_Local.TabIndex = 2;
            this.getConfB_Local.Text = "开始备份";
            this.getConfB_Local.UseVisualStyleBackColor = true;
            this.getConfB_Local.Click += new System.EventHandler(this.getConfB_Local_Click);
            // 
            // DownHosts
            // 
            this.DownHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DownHosts.FullRowSelect = true;
            this.DownHosts.Location = new System.Drawing.Point(52, 27);
            this.DownHosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownHosts.Name = "DownHosts";
            this.DownHosts.Size = new System.Drawing.Size(288, 318);
            this.DownHosts.TabIndex = 10;
            this.DownHosts.UseCompatibleStateImageBehavior = false;
            this.DownHosts.View = System.Windows.Forms.View.Details;
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(12, 27);
            this.moveRightButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(34, 179);
            this.moveRightButton.TabIndex = 11;
            this.moveRightButton.Text = ">>";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(12, 210);
            this.moveLeftButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(34, 179);
            this.moveLeftButton.TabIndex = 12;
            this.moveLeftButton.Text = "<<";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // selectAllHost
            // 
            this.selectAllHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAllHost.Location = new System.Drawing.Point(52, 359);
            this.selectAllHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectAllHost.Name = "selectAllHost";
            this.selectAllHost.Size = new System.Drawing.Size(99, 30);
            this.selectAllHost.TabIndex = 15;
            this.selectAllHost.Text = "全选";
            this.selectAllHost.UseVisualStyleBackColor = true;
            this.selectAllHost.Click += new System.EventHandler(this.selectAllHost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "需要备份配置的交换机：";
            // 
            // selserver
            // 
            this.selserver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selserver.Enabled = false;
            this.selserver.Location = new System.Drawing.Point(820, 359);
            this.selserver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selserver.Name = "selserver";
            this.selserver.Size = new System.Drawing.Size(40, 30);
            this.selserver.TabIndex = 18;
            this.selserver.Text = "...";
            this.selserver.UseVisualStyleBackColor = true;
            this.selserver.Click += new System.EventHandler(this.selserver_Click);
            // 
            // isUpLoad
            // 
            this.isUpLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.isUpLoad.AutoSize = true;
            this.isUpLoad.Location = new System.Drawing.Point(472, 366);
            this.isUpLoad.Name = "isUpLoad";
            this.isUpLoad.Size = new System.Drawing.Size(104, 19);
            this.isUpLoad.TabIndex = 19;
            this.isUpLoad.Text = "上传到远端";
            this.isUpLoad.UseVisualStyleBackColor = true;
            this.isUpLoad.CheckedChanged += new System.EventHandler(this.isUpLoad_CheckedChanged);
            // 
            // remoser
            // 
            this.remoser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remoser.Location = new System.Drawing.Point(582, 361);
            this.remoser.Name = "remoser";
            this.remoser.ReadOnly = true;
            this.remoser.Size = new System.Drawing.Size(238, 25);
            this.remoser.TabIndex = 20;
            // 
            // BackUpConfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 595);
            this.Controls.Add(this.remoser);
            this.Controls.Add(this.isUpLoad);
            this.Controls.Add(this.selserver);
            this.Controls.Add(this.getConfB_Local);
            this.Controls.Add(this.selectAllHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.DownHosts);
            this.Controls.Add(this.moveLeftButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BackUpConfForm";
            this.Text = "交换机配置备份";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getConfB_Local;
        private System.Windows.Forms.ListView DownHosts;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button selectAllHost;
        private System.Windows.Forms.Label label2;
        private Button selserver;
        private CheckBox isUpLoad;
        private TextBox remoser;
    }
}

