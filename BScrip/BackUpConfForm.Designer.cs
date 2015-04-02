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
            this.FunctionTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.getConfB_remote = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.moveRightB_t = new System.Windows.Forms.Button();
            this.moveLeftB_t = new System.Windows.Forms.Button();
            this.timerBackUpL = new System.Windows.Forms.ListBox();
            this.timerLogTBox = new System.Windows.Forms.TextBox();
            this.timerRemBu = new System.Windows.Forms.Button();
            this.timerLocBu = new System.Windows.Forms.Button();
            this.FunctionTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // getConfB_Local
            // 
            this.getConfB_Local.Location = new System.Drawing.Point(217, 411);
            this.getConfB_Local.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getConfB_Local.Name = "getConfB_Local";
            this.getConfB_Local.Size = new System.Drawing.Size(99, 30);
            this.getConfB_Local.TabIndex = 2;
            this.getConfB_Local.Text = "备份到本地";
            this.getConfB_Local.UseVisualStyleBackColor = true;
            this.getConfB_Local.Click += new System.EventHandler(this.getConfB_Local_Click);
            // 
            // DownHosts
            // 
            this.DownHosts.FormattingEnabled = true;
            this.DownHosts.ItemHeight = 15;
            this.DownHosts.Location = new System.Drawing.Point(93, 30);
            this.DownHosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownHosts.Name = "DownHosts";
            this.DownHosts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DownHosts.Size = new System.Drawing.Size(345, 364);
            this.DownHosts.TabIndex = 10;
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(19, 58);
            this.moveRightButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(41, 42);
            this.moveRightButton.TabIndex = 11;
            this.moveRightButton.Text = ">>";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(19, 238);
            this.moveLeftButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(41, 42);
            this.moveLeftButton.TabIndex = 12;
            this.moveLeftButton.Text = "<<";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // selectAllHost
            // 
            this.selectAllHost.Location = new System.Drawing.Point(93, 411);
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
            this.label2.Location = new System.Drawing.Point(91, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "需要备份配置的交换机：";
            // 
            // FunctionTab
            // 
            this.FunctionTab.Controls.Add(this.tabPage1);
            this.FunctionTab.Controls.Add(this.tabPage2);
            this.FunctionTab.Location = new System.Drawing.Point(321, 42);
            this.FunctionTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FunctionTab.Name = "FunctionTab";
            this.FunctionTab.SelectedIndex = 0;
            this.FunctionTab.Size = new System.Drawing.Size(631, 481);
            this.FunctionTab.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.getConfB_remote);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DownHosts);
            this.tabPage1.Controls.Add(this.moveRightButton);
            this.tabPage1.Controls.Add(this.moveLeftButton);
            this.tabPage1.Controls.Add(this.selectAllHost);
            this.tabPage1.Controls.Add(this.getConfB_Local);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(623, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "配置备份";
            // 
            // getConfB_remote
            // 
            this.getConfB_remote.Location = new System.Drawing.Point(340, 411);
            this.getConfB_remote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getConfB_remote.Name = "getConfB_remote";
            this.getConfB_remote.Size = new System.Drawing.Size(99, 30);
            this.getConfB_remote.TabIndex = 18;
            this.getConfB_remote.Text = "备份到远程";
            this.getConfB_remote.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.moveRightB_t);
            this.tabPage2.Controls.Add(this.moveLeftB_t);
            this.tabPage2.Controls.Add(this.timerBackUpL);
            this.tabPage2.Controls.Add(this.timerLogTBox);
            this.tabPage2.Controls.Add(this.timerRemBu);
            this.tabPage2.Controls.Add(this.timerLocBu);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(623, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "定时备份";
            // 
            // moveRightB_t
            // 
            this.moveRightB_t.Location = new System.Drawing.Point(34, 81);
            this.moveRightB_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveRightB_t.Name = "moveRightB_t";
            this.moveRightB_t.Size = new System.Drawing.Size(41, 42);
            this.moveRightB_t.TabIndex = 13;
            this.moveRightB_t.Text = ">>";
            this.moveRightB_t.UseVisualStyleBackColor = true;
            // 
            // moveLeftB_t
            // 
            this.moveLeftB_t.Location = new System.Drawing.Point(34, 275);
            this.moveLeftB_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveLeftB_t.Name = "moveLeftB_t";
            this.moveLeftB_t.Size = new System.Drawing.Size(41, 42);
            this.moveLeftB_t.TabIndex = 14;
            this.moveLeftB_t.Text = "<<";
            this.moveLeftB_t.UseVisualStyleBackColor = true;
            // 
            // timerBackUpL
            // 
            this.timerBackUpL.FormattingEnabled = true;
            this.timerBackUpL.ItemHeight = 15;
            this.timerBackUpL.Location = new System.Drawing.Point(93, 23);
            this.timerBackUpL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timerBackUpL.Name = "timerBackUpL";
            this.timerBackUpL.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.timerBackUpL.Size = new System.Drawing.Size(317, 364);
            this.timerBackUpL.TabIndex = 11;
            // 
            // timerLogTBox
            // 
            this.timerLogTBox.Location = new System.Drawing.Point(521, 69);
            this.timerLogTBox.Margin = new System.Windows.Forms.Padding(4);
            this.timerLogTBox.Multiline = true;
            this.timerLogTBox.Name = "timerLogTBox";
            this.timerLogTBox.Size = new System.Drawing.Size(95, 318);
            this.timerLogTBox.TabIndex = 2;
            // 
            // timerRemBu
            // 
            this.timerRemBu.Location = new System.Drawing.Point(453, 395);
            this.timerRemBu.Margin = new System.Windows.Forms.Padding(4);
            this.timerRemBu.Name = "timerRemBu";
            this.timerRemBu.Size = new System.Drawing.Size(163, 29);
            this.timerRemBu.TabIndex = 1;
            this.timerRemBu.Text = "定时备份到远程";
            this.timerRemBu.UseVisualStyleBackColor = true;
            this.timerRemBu.Click += new System.EventHandler(this.timerRemBu_Click);
            // 
            // timerLocBu
            // 
            this.timerLocBu.Location = new System.Drawing.Point(247, 395);
            this.timerLocBu.Margin = new System.Windows.Forms.Padding(4);
            this.timerLocBu.Name = "timerLocBu";
            this.timerLocBu.Size = new System.Drawing.Size(163, 29);
            this.timerLocBu.TabIndex = 0;
            this.timerLocBu.Text = "定时备份到本机";
            this.timerLocBu.UseVisualStyleBackColor = true;
            this.timerLocBu.Click += new System.EventHandler(this.timerLocBu_Click);
            // 
            // BackUpConfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 580);
            this.Controls.Add(this.FunctionTab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BackUpConfForm";
            this.Text = "交换机配置备份";
            this.FunctionTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getConfB_Local;
        private System.Windows.Forms.ListBox DownHosts;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button selectAllHost;
        private System.Windows.Forms.Label label2;
        private TabControl FunctionTab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button getConfB_remote;
        private Button timerRemBu;
        private Button timerLocBu;
        private TextBox timerLogTBox;
        private Button moveRightB_t;
        private Button moveLeftB_t;
        private ListBox timerBackUpL;
    }
}

