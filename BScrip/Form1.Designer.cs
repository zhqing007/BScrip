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
            this.executeButton = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.HostList = new System.Windows.Forms.ListBox();
            this.DownHosts = new System.Windows.Forms.ListBox();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.selectAllXml = new System.Windows.Forms.Button();
            this.selectAllHost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HostView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(421, 368);
            this.executeButton.Margin = new System.Windows.Forms.Padding(2);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(107, 24);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "备份配置";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.Execute_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(99, 368);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(60, 24);
            this.add.TabIndex = 8;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // HostList
            // 
            this.HostList.FormattingEnabled = true;
            this.HostList.ItemHeight = 12;
            this.HostList.Location = new System.Drawing.Point(37, 42);
            this.HostList.Margin = new System.Windows.Forms.Padding(2);
            this.HostList.Name = "HostList";
            this.HostList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.HostList.Size = new System.Drawing.Size(195, 316);
            this.HostList.TabIndex = 9;
            this.HostList.DoubleClick += new System.EventHandler(this.HostList_DoubleClick);
            // 
            // DownHosts
            // 
            this.DownHosts.FormattingEnabled = true;
            this.DownHosts.ItemHeight = 12;
            this.DownHosts.Location = new System.Drawing.Point(334, 42);
            this.DownHosts.Margin = new System.Windows.Forms.Padding(2);
            this.DownHosts.Name = "DownHosts";
            this.DownHosts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DownHosts.Size = new System.Drawing.Size(195, 316);
            this.DownHosts.TabIndex = 10;
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(267, 105);
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
            this.moveLeftButton.Location = new System.Drawing.Point(267, 245);
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
            this.del.Location = new System.Drawing.Point(161, 368);
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
            this.selectAllXml.Location = new System.Drawing.Point(37, 368);
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
            this.selectAllHost.Location = new System.Drawing.Point(334, 368);
            this.selectAllHost.Margin = new System.Windows.Forms.Padding(2);
            this.selectAllHost.Name = "selectAllHost";
            this.selectAllHost.Size = new System.Drawing.Size(60, 24);
            this.selectAllHost.TabIndex = 15;
            this.selectAllHost.Text = "全选";
            this.selectAllHost.UseVisualStyleBackColor = true;
            this.selectAllHost.Click += new System.EventHandler(this.selectAllHost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "所有交换机：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "需要备份配置的交换机：";
            // 
            // HostView
            // 
            this.HostView.FullRowSelect = true;
            this.HostView.Location = new System.Drawing.Point(557, 43);
            this.HostView.Name = "HostView";
            this.HostView.Size = new System.Drawing.Size(210, 316);
            this.HostView.TabIndex = 18;
            this.HostView.UseCompatibleStateImageBehavior = false;
            this.HostView.View = System.Windows.Forms.View.Details;
            this.HostView.DoubleClick += new System.EventHandler(this.HostView_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 463);
            this.Controls.Add(this.HostView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectAllHost);
            this.Controls.Add(this.selectAllXml);
            this.Controls.Add(this.del);
            this.Controls.Add(this.moveLeftButton);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.DownHosts);
            this.Controls.Add(this.HostList);
            this.Controls.Add(this.add);
            this.Controls.Add(this.executeButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "交换机配置备份";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox HostList;
        private System.Windows.Forms.ListBox DownHosts;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button selectAllXml;
        private System.Windows.Forms.Button selectAllHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView HostView;
    }
}

