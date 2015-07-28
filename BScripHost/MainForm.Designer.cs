namespace BScripHost {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.expbutton = new System.Windows.Forms.Button();
            this.oracleexp = new System.Windows.Forms.TextBox();
            this.dbfbutton = new System.Windows.Forms.Button();
            this.dbfpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oraclecheckBox = new System.Windows.Forms.CheckBox();
            this.dbcheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(126, 278);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(71, 26);
            this.start.TabIndex = 0;
            this.start.Text = "开始服务";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(327, 278);
            this.stop.Margin = new System.Windows.Forms.Padding(2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(71, 26);
            this.stop.TabIndex = 1;
            this.stop.Text = "停止服务";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 263);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dbcheckBox);
            this.tabPage1.Controls.Add(this.oraclecheckBox);
            this.tabPage1.Controls.Add(this.expbutton);
            this.tabPage1.Controls.Add(this.oracleexp);
            this.tabPage1.Controls.Add(this.dbfbutton);
            this.tabPage1.Controls.Add(this.dbfpath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据备份设置";
            // 
            // expbutton
            // 
            this.expbutton.Enabled = false;
            this.expbutton.Location = new System.Drawing.Point(419, 168);
            this.expbutton.Name = "expbutton";
            this.expbutton.Size = new System.Drawing.Size(77, 25);
            this.expbutton.TabIndex = 5;
            this.expbutton.Text = "选择";
            this.expbutton.UseVisualStyleBackColor = true;
            this.expbutton.Click += new System.EventHandler(this.expbutton_Click);
            // 
            // oracleexp
            // 
            this.oracleexp.Enabled = false;
            this.oracleexp.Location = new System.Drawing.Point(28, 170);
            this.oracleexp.Name = "oracleexp";
            this.oracleexp.ReadOnly = true;
            this.oracleexp.Size = new System.Drawing.Size(368, 21);
            this.oracleexp.TabIndex = 4;
            // 
            // dbfbutton
            // 
            this.dbfbutton.Enabled = false;
            this.dbfbutton.Location = new System.Drawing.Point(419, 93);
            this.dbfbutton.Name = "dbfbutton";
            this.dbfbutton.Size = new System.Drawing.Size(77, 25);
            this.dbfbutton.TabIndex = 2;
            this.dbfbutton.Text = "选择";
            this.dbfbutton.UseVisualStyleBackColor = true;
            this.dbfbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbfpath
            // 
            this.dbfpath.Enabled = false;
            this.dbfpath.Location = new System.Drawing.Point(28, 95);
            this.dbfpath.Name = "dbfpath";
            this.dbfpath.ReadOnly = true;
            this.dbfpath.Size = new System.Drawing.Size(368, 21);
            this.dbfpath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "备份路径：";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "无";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 319);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(530, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(74, 17);
            this.StatusLabel.Text = "StatusLabel";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "BScrip服务端已经最小化到此处，\r\n双击后还原。";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BScrip服务端";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenuItem,
            this.ExitMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // BackMenuItem
            // 
            this.BackMenuItem.Name = "BackMenuItem";
            this.BackMenuItem.Size = new System.Drawing.Size(100, 22);
            this.BackMenuItem.Text = "还原";
            this.BackMenuItem.Click += new System.EventHandler(this.BackMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitMenuItem.Text = "退出";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // oraclecheckBox
            // 
            this.oraclecheckBox.AutoSize = true;
            this.oraclecheckBox.Enabled = false;
            this.oraclecheckBox.Location = new System.Drawing.Point(28, 146);
            this.oraclecheckBox.Name = "oraclecheckBox";
            this.oraclecheckBox.Size = new System.Drawing.Size(186, 16);
            this.oraclecheckBox.TabIndex = 6;
            this.oraclecheckBox.Text = "Oracle备份程序（exp.exe）：";
            this.oraclecheckBox.UseVisualStyleBackColor = true;
            this.oraclecheckBox.CheckedChanged += new System.EventHandler(this.oraclecheckBox_CheckedChanged);
            // 
            // dbcheckBox
            // 
            this.dbcheckBox.AutoSize = true;
            this.dbcheckBox.Location = new System.Drawing.Point(28, 30);
            this.dbcheckBox.Name = "dbcheckBox";
            this.dbcheckBox.Size = new System.Drawing.Size(84, 16);
            this.dbcheckBox.TabIndex = 7;
            this.dbcheckBox.Text = "数据库备份";
            this.dbcheckBox.UseVisualStyleBackColor = true;
            this.dbcheckBox.CheckedChanged += new System.EventHandler(this.dbcheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 341);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button dbfbutton;
        private System.Windows.Forms.TextBox dbfpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button expbutton;
        private System.Windows.Forms.TextBox oracleexp;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem BackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.CheckBox oraclecheckBox;
        private System.Windows.Forms.CheckBox dbcheckBox;
    }
}

