using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using BScripServiceLibrary;

namespace BScripHost {
    public partial class MainForm : Form {
        ServiceHost host;

        public MainForm() {
            InitializeComponent();
            host = null;
            dbfpath.Text = DBhelper.GetConfiguration("DataBaseFilePath").Trim();
            oracleexp.Text = DBhelper.GetConfiguration("OracleExpPath").Trim();
            StatusLabel.Text = "服务没有运行！";
            stop.Enabled = false;
        }

        private void start_Click(object sender, EventArgs e) {
            if (dbcheckBox.Checked) {
                if (dbfpath.Text.Length == 0) {
                    MessageBox.Show("请设置数据库备份文件存放路径！");
                    return;
                }

                if (oraclecheckBox.Checked && oracleexp.Text.Length == 0) {
                    MessageBox.Show("请设置Oracle备份程序路径！");
                    return;
                }
            }

            if (host != null && host.State == CommunicationState.Opened) {
                StatusLabel.Text = "服务正在运行！";
                return;
            }
            BSService bscripServer = new BSService(dbcheckBox.Checked, oraclecheckBox.Checked);
            host = new ServiceHost(bscripServer);
            host.Opened += delegate { StatusLabel.Text = "服务已经启动！"; };
            host.Closed += delegate { StatusLabel.Text = "服务已经停止！"; };
            host.Open();
            start.Enabled = false;
            stop.Enabled = true;
        }

        private bool StopServer() {
            if (host != null && host.State == CommunicationState.Opened) {
                if (MessageBox.Show("是否确定停止服务？"
                    , "确认", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    return true;

                BSService ts = (BSService)(host.SingletonInstance);
                ts.StopThreads();
                host.Close();
                start.Enabled = true;
                stop.Enabled = false;
            }
            return false;
        }

        private void stop_Click(object sender, EventArgs e) {
            if(!StopServer())
                StatusLabel.Text = "服务没有运行！";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (StopServer())
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            FolderBrowserDialog pathdia = new FolderBrowserDialog();
            pathdia.ShowDialog();
            if (pathdia.SelectedPath.Length != 0) {
                DBhelper.SetConfiguration("DataBaseFilePath", pathdia.SelectedPath);
                dbfpath.Text = pathdia.SelectedPath;
            }
        }

        private void expbutton_Click(object sender, EventArgs e) {
            OpenFileDialog expdia = new OpenFileDialog();
            expdia.Filter = "Oracle导出程序(exp.exe)|exp.exe";
            expdia.ShowDialog();
            if (expdia.FileName.Length != 0) {
                DBhelper.SetConfiguration("OracleExpPath", expdia.FileName);
                oracleexp.Text = expdia.FileName;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) { //判断是否最小化
                this.ShowInTaskbar = false; //不显示在系统任务栏
                notifyIcon.Visible = true; //托盘图标可见
                if (DBhelper.GetConfiguration("HostFirstRun") == "Yes") {
                    this.notifyIcon.ShowBalloonTip(100
                        , this.notifyIcon.BalloonTipTitle
                        , this.notifyIcon.BalloonTipText, ToolTipIcon.Info);
                    DBhelper.SetConfiguration("HostFirstRun", "No");
                }
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void BackMenuItem_Click(object sender, EventArgs e) {
            notifyIcon_DoubleClick(sender, e);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void oraclecheckBox_CheckedChanged(object sender, EventArgs e) {
            if (oraclecheckBox.Checked)
                oracleexp.Enabled = expbutton.Enabled = true;
            else
                oracleexp.Enabled = expbutton.Enabled = false;
        }

        private void dbcheckBox_CheckedChanged(object sender, EventArgs e) {
            if (dbcheckBox.Checked)
                label1.Enabled = dbfpath.Enabled = dbfbutton.Enabled
                    = oraclecheckBox.Enabled = true;
            else {
                oraclecheckBox.Checked = false;
                label1.Enabled = dbfpath.Enabled = dbfbutton.Enabled
                    = oraclecheckBox.Enabled = false;
            }
        }
    }
}
