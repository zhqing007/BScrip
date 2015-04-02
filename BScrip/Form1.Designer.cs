using System.Windows.Forms;

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
            this.getConfB_Local = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.DownHosts = new System.Windows.Forms.ListBox();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.selectAllXml = new System.Windows.Forms.Button();
            this.selectAllHost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HostView = new System.Windows.Forms.ListView();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.FunctionTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.getConfB_remote = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.getConfB_Local.Location = new System.Drawing.Point(163, 329);
            this.getConfB_Local.Margin = new System.Windows.Forms.Padding(2);
            this.getConfB_Local.Name = "getConfB_Local";
            this.getConfB_Local.Size = new System.Drawing.Size(74, 24);
            this.getConfB_Local.TabIndex = 2;
            this.getConfB_Local.Text = "备份到本地";
            this.getConfB_Local.UseVisualStyleBackColor = true;
            this.getConfB_Local.Click += new System.EventHandler(this.getConfB_Local_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(99, 382);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(60, 24);
            this.add.TabIndex = 8;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // DownHosts
            // 
            this.DownHosts.FormattingEnabled = true;
            this.DownHosts.ItemHeight = 12;
            this.DownHosts.Location = new System.Drawing.Point(70, 24);
            this.DownHosts.Margin = new System.Windows.Forms.Padding(2);
            this.DownHosts.Name = "DownHosts";
            this.DownHosts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DownHosts.Size = new System.Drawing.Size(260, 292);
            this.DownHosts.TabIndex = 10;
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(14, 46);
            this.moveRightButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(31, 34);
            this.moveRightButton.TabIndex = 11;
            this.moveRightButton.Text = ">>";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(14, 190);
            this.moveLeftButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(31, 34);
            this.moveLeftButton.TabIndex = 12;
            this.moveLeftButton.Text = "<<";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(161, 382);
            this.del.Margin = new System.Windows.Forms.Padding(2);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(60, 24);
            this.del.TabIndex = 13;
            this.del.Text = "删除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // selectAllXml
            // 
            this.selectAllXml.Location = new System.Drawing.Point(37, 382);
            this.selectAllXml.Margin = new System.Windows.Forms.Padding(2);
            this.selectAllXml.Name = "selectAllXml";
            this.selectAllXml.Size = new System.Drawing.Size(60, 24);
            this.selectAllXml.TabIndex = 14;
            this.selectAllXml.Text = "全选";
            this.selectAllXml.UseVisualStyleBackColor = true;
            this.selectAllXml.Click += new System.EventHandler(this.selectAllHostList_Click);
            // 
            // selectAllHost
            // 
            this.selectAllHost.Location = new System.Drawing.Point(70, 329);
            this.selectAllHost.Margin = new System.Windows.Forms.Padding(2);
            this.selectAllHost.Name = "selectAllHost";
            this.selectAllHost.Size = new System.Drawing.Size(74, 24);
            this.selectAllHost.TabIndex = 15;
            this.selectAllHost.Text = "全选";
            this.selectAllHost.UseVisualStyleBackColor = true;
            this.selectAllHost.Click += new System.EventHandler(this.selectAllHost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "所有交换机：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "需要备份配置的交换机：";
            // 
            // HostView
            // 
            this.HostView.FullRowSelect = true;
            this.HostView.HideSelection = false;
            this.HostView.Location = new System.Drawing.Point(26, 56);
            this.HostView.Name = "HostView";
            this.HostView.Size = new System.Drawing.Size(210, 316);
            this.HostView.TabIndex = 18;
            this.HostView.UseCompatibleStateImageBehavior = false;
            this.HostView.View = System.Windows.Forms.View.Details;
            this.HostView.DoubleClick += new System.EventHandler(this.HostView_DoubleClick);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(626, 25);
            this.ToolStrip.TabIndex = 19;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // FunctionTab
            // 
            this.FunctionTab.Controls.Add(this.tabPage1);
            this.FunctionTab.Controls.Add(this.tabPage2);
            this.FunctionTab.Location = new System.Drawing.Point(241, 34);
            this.FunctionTab.Margin = new System.Windows.Forms.Padding(2);
            this.FunctionTab.Name = "FunctionTab";
            this.FunctionTab.SelectedIndex = 0;
            this.FunctionTab.Size = new System.Drawing.Size(371, 385);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(363, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "配置备份";
            // 
            // getConfB_remote
            // 
            this.getConfB_remote.Location = new System.Drawing.Point(255, 329);
            this.getConfB_remote.Margin = new System.Windows.Forms.Padding(2);
            this.getConfB_remote.Name = "getConfB_remote";
            this.getConfB_remote.Size = new System.Drawing.Size(74, 24);
            this.getConfB_remote.TabIndex = 18;
            this.getConfB_remote.Text = "备份到远程";
            this.getConfB_remote.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.timerLogTBox);
            this.tabPage2.Controls.Add(this.timerRemBu);
            this.tabPage2.Controls.Add(this.timerLocBu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(363, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "定时备份";
            // 
            // timerLogTBox
            // 
            this.timerLogTBox.Location = new System.Drawing.Point(27, 42);
            this.timerLogTBox.Multiline = true;
            this.timerLogTBox.Name = "timerLogTBox";
            this.timerLogTBox.Size = new System.Drawing.Size(292, 225);
            this.timerLogTBox.TabIndex = 2;
            // 
            // timerRemBu
            // 
            this.timerRemBu.Location = new System.Drawing.Point(198, 293);
            this.timerRemBu.Name = "timerRemBu";
            this.timerRemBu.Size = new System.Drawing.Size(122, 23);
            this.timerRemBu.TabIndex = 1;
            this.timerRemBu.Text = "定时备份到远程";
            this.timerRemBu.UseVisualStyleBackColor = true;
            this.timerRemBu.Click += new System.EventHandler(this.timerRemBu_Click);
            // 
            // timerLocBu
            // 
            this.timerLocBu.Location = new System.Drawing.Point(34, 293);
            this.timerLocBu.Name = "timerLocBu";
            this.timerLocBu.Size = new System.Drawing.Size(122, 23);
            this.timerLocBu.TabIndex = 0;
            this.timerLocBu.Text = "定时备份到本机";
            this.timerLocBu.UseVisualStyleBackColor = true;
            this.timerLocBu.Click += new System.EventHandler(this.timerLocBu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 438);
            this.Controls.Add(this.FunctionTab);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.HostView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectAllXml);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "交换机配置备份";
            this.FunctionTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getConfB_Local;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox DownHosts;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button selectAllXml;
        private System.Windows.Forms.Button selectAllHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView HostView;
        private ToolStrip ToolStrip;
        private TabControl FunctionTab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button getConfB_remote;
        private Button timerRemBu;
        private Button timerLocBu;
        private TextBox timerLogTBox;
    }
}

