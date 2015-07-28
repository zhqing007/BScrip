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
            timerBackUpL.Columns.Add("备份间隔(天)", 120, HorizontalAlignment.Left);
            timerBackUpL.Columns.Add("登录方式", 80, HorizontalAlignment.Left);
            Host[] buhosts = StaticFun.serverclient.GetBackUpHosts();
            foreach (Host h in buhosts) {
                ListViewItem listitem = new ListViewItem();
                listitem.Tag = h;
                listitem.Text = h.hostname;
                listitem.SubItems.Add(h.ipaddress);
                listitem.SubItems.Add(h.loginname);
                listitem.SubItems.Add((new TimeSpan(h.tspan)).TotalDays.ToString());
                if (h.loginmode == 0)
                    listitem.SubItems.Add("Telnet");
                else
                    listitem.SubItems.Add("SSH2");
                timerBackUpL.Items.Add(listitem);
            }
        }

        private void moveRightB_t_Click(object sender, EventArgs e) {
            List<Host> lh = HostsForm.allhostsform.GetSelectHosts();
            if(lh.Count == 0) return;
            AddHostToEdit(lh[0]);
        }

        public override void AddHost(Host h = null) {
            moveRightB_t_Click(null, null);
        }

        private void stopLocal_Click(object sender, EventArgs e) {
            if (timerBackUpL.SelectedItems.Count <= 0) return;
            Host h = timerBackUpL.SelectedItems[0].Tag as Host;
            h.tspan = 0;
            if (h.userid != StaticFun.loginID) {
                MessageBox.Show("所要选定的主机由其它用户添加，请联系对方修改！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(MessageBox.Show("确定停止所选主机'" + h.hostname + "'的定期备份么？", "确认"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            StaticFun.serverclient.UpdateHost(h);
            timerBackUpL.SelectedItems[0].Remove();
        }

        private void addToBU_Click(object sender, EventArgs e) {
            Host h = namebox.Tag as Host;
            long ticks = (new TimeSpan((int)(dayUpDown.Value), 0, 0, 0)).Ticks;
            int index = -1;
            foreach (ListViewItem item in timerBackUpL.Items) {
                Host listh = item.Tag as Host;
                if (h.ipaddress == listh.ipaddress) {
                    index = item.Index;
                    if (ticks == listh.tspan) {
                        MessageBox.Show("所要备份的主机已添加！", "重复", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (h.userid != listh.userid) {
                        MessageBox.Show("所要备份的主机已由其它用户添加，请联系对方修改！", "重复", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            h.tspan = ticks;

            StaticFun.serverclient.UpdateHost(h);     
            if (index != -1)
                timerBackUpL.Items[index].SubItems[3].Text = (new TimeSpan(h.tspan)).TotalDays.ToString();
            else{
                ListViewItem listitem = new ListViewItem();
                listitem.Tag = h;
                listitem.Text = h.hostname;
                listitem.SubItems.Add(h.ipaddress);
                listitem.SubItems.Add(h.loginname);
                listitem.SubItems.Add((new TimeSpan(h.tspan)).TotalHours.ToString());
                if (h.loginmode == 0)
                    listitem.SubItems.Add("Telnet");
                else
                    listitem.SubItems.Add("SSH2");
                timerBackUpL.Items.Add(listitem);
            }
        }

        private void AddHostToEdit(Host item) {
            item.userid = StaticFun.loginID;
            namebox.Tag = item;
            namebox.Text = item.hostname;
            ipbox.Text = item.ipaddress;
            TimeSpan ts = new TimeSpan(item.tspan);
            dayUpDown.Value = (decimal)ts.TotalDays;
            this.stopLocal.Enabled = true;
        }

        private void timerBackUpL_SelectedIndexChanged(object sender, EventArgs e) {
            if (timerBackUpL.SelectedItems.Count <= 0)
                return;
            AddHostToEdit(timerBackUpL.SelectedItems[0].Tag as Host);
        }

        //private void GetConfiguration() {
        //    if (timerBackUpL.Items.Count <= 0) {
        //        MessageBox.Show("没有要备份的主机！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    List<Host> hostlist = new List<Host>();
        //    foreach (object item in timerBackUpL.Items) {
        //        hostlist.Add((item as ListViewItem).Tag as Host);
        //    }
        //Host _server = null;
        //if (isUpLoad_re.Checked) _server = remoser_re.Tag as Host;
        //BSThread.ConfThread confth = new BSThread.ConfThread(hostlist, _server);
        //Thread logThread = new Thread(new ThreadStart(confth.GetConfNoThread));
        //logThread.Start();
        //}

        //private bool BeginBackUp(ref System.Threading.Timer t, Host upserver) {
        //    TimeSpan beginTime = new TimeSpan();
        //    if (beginTimePicker.Value > DateTime.Now)
        //        beginTime = beginTimePicker.Value - DateTime.Now;
        //    if(dayUpDown.Value == 0 && hourUpDown.Value == 0 && minuteUpDown.Value == 0){
        //        MessageBox.Show("没有设置间隔时间！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    TimeSpan span = new TimeSpan(Decimal.ToInt32(dayUpDown.Value)
        //        , Decimal.ToInt32(hourUpDown.Value)
        //        , Decimal.ToInt32(minuteUpDown.Value)
        //        , 0);
        //    List<Host> hostlist = new List<Host>();
        //    foreach (object item in timerBackUpL.Items) {
        //        hostlist.Add((item as ListViewItem).Tag as Host);
        //    }
            
        //    TimerConfGeter tgeter = new TimerConfGeter();
        //    TimerStruct ts = new TimerStruct();
        //    ts.hosts = hostlist;
        //    ts.upLoadServer = upserver;

        //    t = new System.Threading.Timer(new TimerCallback(tgeter.fun), ts, beginTime, span);
        //    return true;
        //}

        //private void GetConfiguration_Timer() {
        //    if (this.timerBackUpL.Items.Count <= 0) {
        //        MessageBox.Show("没有要备份的主机！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    bool isbegin = false;

        //    isbegin = BeginBackUp(ref this.locTimer, null);
        //    if (!isbegin) return;
        //    this.stopLocal.Enabled = true;
        //    this.getConfB.Enabled = false;
        //    SetPicSta(true);
        //}

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

        //private void DrawPicBoxCircle(PictureBox pb, Graphics g, Color c) {
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //    Brush bush = new SolidBrush(c);
        //    g.FillEllipse(bush, 0, 0, pb.Size.Width - 1, pb.Size.Height - 1);
        //}

        //private void isUpLoad_re_CheckedChanged(object sender, EventArgs e) {
        //if (!(sender as CheckBox).Checked) {
        //    EnableUploadItems(false);
        //    return;
        //}
        //EnableUploadItems(true);
        //if (remoser_re.Tag != null) return;
        //selserver_re_Click(sender, e);
        //if (remoser_re.Tag == null)
        //    isUpLoad_re.Checked = false;
        //}
                
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
