using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BScrip.BScripService;

namespace BScrip.BSForms {
    public partial class TimerBackUpForm : BSForm {
        private System.Threading.Timer locTimer = null; 

        public TimerBackUpForm() {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            timerBackUpL.Columns.Add("主机名", 100, HorizontalAlignment.Left);
            timerBackUpL.Columns.Add("IP地址", 120, HorizontalAlignment.Left);
            timerBackUpL.Columns.Add("登录名", 120, HorizontalAlignment.Left);
            timerBackUpL.Columns.Add("登录方式", 80, HorizontalAlignment.Left);
            beginTimePicker.Value = beginTimePicker.MinDate = DateTime.Now;
            beginTimePicker.MaxDate = DateTime.Now + new TimeSpan(365, 0, 0, 0);
            //Host dfs = DBhelper.GetDefaultUpLoadServer();
            //if (dfs != null) {
            //    remoser_re.Tag = dfs;
            //    remoser_re.Text = dfs.hostname;
            //}
            EnableTimerItems(false);
            EnableUploadItems(false);
        }

        private void moveRightB_t_Click(object sender, EventArgs e) {
            if (!StaticFun.AddHostListToListViewTag(HostsForm.allhostsform.GetSelectHosts(), timerBackUpL))
                return;
            Host th;
            foreach (ListViewItem downh in timerBackUpL.Items) {
                if (downh.Text.Length > 0) continue;
                th = downh.Tag as Host;
                downh.Text = th.hostname;
                downh.SubItems.Add(th.ipaddress);
                downh.SubItems.Add(th.loginname);
                if (th.loginmode == 0)
                    downh.SubItems.Add("Telnet");
                else
                    downh.SubItems.Add("SSH2");
            }
        }

        public override void AddHost(Host h = null) {
            moveRightB_t_Click(null, null);
        }

        private void moveLeftB_t_Click(object sender, EventArgs e) {
            if (timerBackUpL.SelectedItems.Count == 0) return;
            for (int p = timerBackUpL.SelectedItems.Count - 1; p >= 0; --p)
                timerBackUpL.Items.Remove(timerBackUpL.SelectedItems[p]);
        }

        private void selectAllB_Click(object sender, EventArgs e) {
            StaticFun.SelectAll_ListView(timerBackUpL);
        }

        private bool BeginBackUp(ref System.Threading.Timer t, Host upserver) {
            TimeSpan beginTime = new TimeSpan();
            if (beginTimePicker.Value > DateTime.Now)
                beginTime = beginTimePicker.Value - DateTime.Now;
            if(dayUpDown.Value == 0 && hourUpDown.Value == 0 && minuteUpDown.Value == 0){
                MessageBox.Show("没有设置间隔时间！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            TimeSpan span = new TimeSpan(Decimal.ToInt32(dayUpDown.Value)
                , Decimal.ToInt32(hourUpDown.Value)
                , Decimal.ToInt32(minuteUpDown.Value)
                , 0);
            List<Host> hostlist = new List<Host>();
            foreach (object item in timerBackUpL.Items) {
                hostlist.Add((item as ListViewItem).Tag as Host);
            }
            
            TimerConfGeter tgeter = new TimerConfGeter();
            TimerStruct ts = new TimerStruct();
            ts.hosts = hostlist;
            ts.upLoadServer = upserver;

            t = new System.Threading.Timer(new TimerCallback(tgeter.fun), ts, beginTime, span);
            return true;
        }

        private void GetConfiguration_Timer() {
            if (this.timerBackUpL.Items.Count <= 0) {
                MessageBox.Show("没有要备份的主机！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isbegin = false;

            if (isUpLoad_re.Checked)
                isbegin = BeginBackUp(ref this.locTimer, remoser_re.Tag as Host);
            else
                isbegin = BeginBackUp(ref this.locTimer, null);
            if (!isbegin) return;
            this.stopLocal.Enabled = true;
            this.getConfB.Enabled = false;
            SetPicSta(true);
        }

        //private void timerRemBu_Click(object sender, EventArgs e) {
        //    if (this.timerBackUpL.Items.Count <= 0) {
        //        MessageBox.Show("没有要备份的主机！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    FileTransfer tranHost = new FileTransfer();
        //    tranHost.ShowDialog();
        //    if (tranHost.DialogResult != DialogResult.OK) return;

        //    if (!BeginBackUp(ref this.remoteTimer, tranHost.GetServer())) return;
        //    this.stopRemote.Enabled = true;
        //    this.timerRemBu.Enabled = false;
        //    SetLocalCircle(Color.Green);
        //}

        private void stopLocal_Click(object sender, EventArgs e) {
            if (locTimer == null) return;
            this.locTimer.Dispose();
            this.stopLocal.Enabled = false;
            this.getConfB.Enabled = true;
            SetPicSta(false);
        }

        //private void stopRemote_Click(object sender, EventArgs e) {
        //    this.remoteTimer.Dispose();
        //    this.stopRemote.Enabled = false;
        //    this.timerRemBu.Enabled = true;
        //    SetRemoteCircle(SystemColors.Control);
        //}


        private void SetPicSta(bool dis) {
            this.localIsRunningPic.Image =
                dis ? global::BScrip.Properties.Resources.run
                : global::BScrip.Properties.Resources.norun;
        }

        //private void SetRemoteCircle(Color c) {
        //    remoteColor = c;
        //    remoteIsRunningPic.Invalidate();
        //}

        private void DrawPicBoxCircle(PictureBox pb, Graphics g, Color c) {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush bush = new SolidBrush(c);
            g.FillEllipse(bush, 0, 0, pb.Size.Width - 1, pb.Size.Height - 1);
        }



        //private void remoteIsRunningPic_Paint(object sender, PaintEventArgs e) {
        //    DrawPicBoxCircle(sender as PictureBox, e.Graphics, remoteColor);
        //}

        private void selserver_re_Click(object sender, EventArgs e) {
            FileTransfer tranHost = new FileTransfer();
            tranHost.ShowDialog();
            if (tranHost.DialogResult != DialogResult.OK) return;
            Host ser = tranHost.GetServer();
            remoser_re.Tag = ser;
            remoser_re.Text = ser.hostname;
        }

        private void EnableUploadItems(bool en) {
            label2.Enabled = en;
            remoser_re.Enabled = en;
            selserver_re.Enabled = en;
        }

        private void isUpLoad_re_CheckedChanged(object sender, EventArgs e) {
            if (!(sender as CheckBox).Checked) {
                EnableUploadItems(false);
                return;
            }
            EnableUploadItems(true);
            if (remoser_re.Tag != null) return;
            selserver_re_Click(sender, e);
            if (remoser_re.Tag == null)
                isUpLoad_re.Checked = false;
        }

        private void getConfB_Click(object sender, EventArgs e) {
            if (isTimercheckbox.Checked)
                GetConfiguration_Timer();
            else
                GetConfiguration();
        }

        private void GetConfiguration() {
            if (timerBackUpL.Items.Count <= 0) {
                MessageBox.Show("没有要备份的主机！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Host> hostlist = new List<Host>();
            foreach (object item in timerBackUpL.Items) {
                hostlist.Add((item as ListViewItem).Tag as Host);
            }
            //Host _server = null;
            //if (isUpLoad_re.Checked) _server = remoser_re.Tag as Host;
            //BSThread.ConfThread confth = new BSThread.ConfThread(hostlist, _server);
            //Thread logThread = new Thread(new ThreadStart(confth.GetConfNoThread));
            //logThread.Start();
        }

        private void EnableTimerItems(bool en) {
            this.label1.Enabled = en;
            this.beginTimePicker.Enabled = en;
            this.groupBox1.Enabled = en;
            this.stopLocal.Enabled = false;
            //this.localIsRunningPic.Image =
            //    en ? global::BScrip.Properties.Resources.run
            //    : global::BScrip.Properties.Resources.norun;
        }

        private void isTimercheckbox_CheckedChanged(object sender, EventArgs e) {
            EnableTimerItems((sender as CheckBox).Checked);
        }
    }

    public class TimerStruct {
        public List<Host> hosts;
        public Host upLoadServer;
    }

    public class TimerConfGeter {
        private static object locker = new object();
        private static int threadcount = 0;

        public void fun(object sender) {
            lock (locker) {
                if (threadcount > 0) return;
                ++threadcount;
            }

            TimerStruct ts = sender as TimerStruct;
            //BSThread.ConfThread conf = new BSThread.ConfThread(ts.hosts, ts.upLoadServer);
            //conf.GetConfNoThread();

            lock (locker) {
                --threadcount;
            }
        }
    }   
}
