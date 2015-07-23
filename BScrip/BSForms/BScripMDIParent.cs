using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BScrip.BScripService;

namespace BScrip.BSForms {
    public partial class BScripMDIParent : Form {
        public static BScripMDIParent onlyOneMDI = null;

        private int childFormNumber = 0;
        //private BSForms.BackUpConfForm backUpMDIChild = null;
        private TimerBackUpForm timerBUMDIChild = null;
        private BSForms.DeviceViewer switchCMDIChild = null;
        private BSForms.ConfViewer confViewerCMDIChild = null;
        private BSForms.DBexport tabRCMDIChild = null;
        private BSForms.DeviceInfo devInfoMDIChild = null;

        public BScripMDIParent() {
            InitializeComponent();
            HostsForm.allhostsform = new HostsForm();
            HostsForm.allhostsform.MdiParent = this;
            HostsForm.allhostsform.Parent = splitContainer1.Panel1;
            HostsForm.allhostsform.Dock = DockStyle.Fill;
            HostsForm.allhostsform.Show();
            timerBackUp_Click(null, null);
            LogMessageForm.logForm = new LogMessageForm();
            //LogMessageForm.logForm.MdiParent = this;
            //LogMessageForm.logForm.Parent = splitContainer2.Panel2;
            //LogMessageForm.logForm.Dock = DockStyle.Fill;
            //LogMessageForm.logForm.Show();
        }

        private void ShowNewForm(object sender, EventArgs e) {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        //private void BackUpConf_Click(object sender, EventArgs e) {
        //    splitContainer1.Panel2.Controls.Clear();
        //    if (backUpMDIChild == null || backUpMDIChild.IsDisposed) {
        //        backUpMDIChild = new BSForms.BackUpConfForm();
        //        backUpMDIChild.MdiParent = this;
        //        backUpMDIChild.Parent = splitContainer1.Panel2;
        //        backUpMDIChild.Dock = DockStyle.Fill;
        //        backUpMDIChild.Show();
        //    }
        //    else
        //        splitContainer1.Panel2.Controls.Add(backUpMDIChild);
            
        //}

        private void timerBackUp_Click(object sender, EventArgs e) {
            splitContainer1.Panel2.Controls.Clear();
            if (timerBUMDIChild == null || timerBUMDIChild.IsDisposed) {
                timerBUMDIChild = new TimerBackUpForm();
                timerBUMDIChild.MdiParent = this;
                timerBUMDIChild.Parent = splitContainer1.Panel2;
                timerBUMDIChild.Dock = DockStyle.Fill;
                timerBUMDIChild.Show();
            }
            else
                splitContainer1.Panel2.Controls.Add(timerBUMDIChild);
        }

        private void showInfo_Click(object sender, EventArgs e) {
            ShowSwitchInfo();
        }

        public void AddHost(Host h = null, bool timer = false) {
            timerBackUp_Click(null, null);
            BSForm bsf = splitContainer1.Panel2.Controls[0] as BSForm;
            if(bsf != null)
                bsf.AddHost(h);
        }

        public void ShowSwitchInfo() {
            //List<Host> selecthosts = HostsForm.allhostsform.GetSelectHosts();
            //if (selecthosts.Count <= 0) {
            //    MessageBox.Show("没有选择设备！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            splitContainer1.Panel2.Controls.Clear();
            if (switchCMDIChild == null || switchCMDIChild.IsDisposed) {
                switchCMDIChild = new BSForms.DeviceViewer();                
                switchCMDIChild.MdiParent = this;
                switchCMDIChild.Parent = splitContainer1.Panel2;
                switchCMDIChild.Dock = DockStyle.Fill;
                switchCMDIChild.Show();
                //switchCMDIChild.AddHost(selecthosts[0]);
            }
            else
                splitContainer1.Panel2.Controls.Add(switchCMDIChild);
        }

        public void confviewer_Click(object sender, EventArgs e) {
            List<Host> selecthosts = HostsForm.allhostsform.GetSelectHosts();
            if (selecthosts.Count <= 0) {
                MessageBox.Show("没有选择设备！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            splitContainer1.Panel2.Controls.Clear();
            if (confViewerCMDIChild == null || confViewerCMDIChild.IsDisposed) {
                confViewerCMDIChild = new BSForms.ConfViewer(selecthosts[0]);
                confViewerCMDIChild.MdiParent = this;
                confViewerCMDIChild.Parent = splitContainer1.Panel2;
                confViewerCMDIChild.Dock = DockStyle.Fill;
                confViewerCMDIChild.Show();
            }
            else {
                confViewerCMDIChild.AddHost(selecthosts[0]);
                splitContainer1.Panel2.Controls.Add(confViewerCMDIChild);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            splitContainer1.Panel2.Controls.Clear();
            if (tabRCMDIChild == null || tabRCMDIChild.IsDisposed) {
                tabRCMDIChild = new DBexport();
                tabRCMDIChild.MdiParent = this;
                tabRCMDIChild.Parent = splitContainer1.Panel2;
                tabRCMDIChild.Dock = DockStyle.Fill;
                tabRCMDIChild.Show();
            }
            else
                splitContainer1.Panel2.Controls.Add(tabRCMDIChild);
        }

        public void ShowStatus_Click(object sender, EventArgs e) {
            List<Host> selecthosts = HostsForm.allhostsform.GetSelectHosts();
            if (selecthosts.Count <= 0) {
                MessageBox.Show("没有选择设备！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            splitContainer1.Panel2.Controls.Clear();
            if (devInfoMDIChild == null || devInfoMDIChild.IsDisposed) {
                devInfoMDIChild = new DeviceInfo(selecthosts[0]);
                devInfoMDIChild.MdiParent = this;
                devInfoMDIChild.Parent = splitContainer1.Panel2;
                devInfoMDIChild.Dock = DockStyle.Fill;
                devInfoMDIChild.Show();
            }
            else
                splitContainer1.Panel2.Controls.Add(devInfoMDIChild);
        }
    }

    public class BSForm : Form {
        public BSForm(){
            this.BackColor = StaticFun.BSColor;
        }

        public virtual void AddHost(Host h = null){}

        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x00A1 && m.WParam.ToInt32() == 2) {
                m.Msg = 0x0201;
                m.LParam = IntPtr.Zero;
            }
            base.WndProc(ref m);            
        }
    }
}
