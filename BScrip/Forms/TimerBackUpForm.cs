using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BScrip {
    public partial class TimerBackUpForm : Form {
        private System.Threading.Timer timersTimer;

        public TimerBackUpForm() {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            timerBackUpL.Columns.Add("主机名", 100, HorizontalAlignment.Left);
            timerBackUpL.Columns.Add("IP地址", 120, HorizontalAlignment.Left);
            timerBackUpL.Columns.Add("登录名", 120, HorizontalAlignment.Left);
            timerBackUpL.Columns.Add("登录方式", 80, HorizontalAlignment.Left);
            beginTimePicker.Value = beginTimePicker.MinDate = DateTime.Now;
            beginTimePicker.MaxDate = DateTime.Now + new TimeSpan(365, 0, 0, 0);
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

        private void moveLeftB_t_Click(object sender, EventArgs e) {
            if (timerBackUpL.SelectedItems.Count == 0) return;
            for (int p = timerBackUpL.SelectedItems.Count - 1; p >= 0; --p)
                timerBackUpL.Items.Remove(timerBackUpL.SelectedItems[p]);
        }

        private void selectAllB_Click(object sender, EventArgs e) {
            StaticFun.SelectAll_ListView(timerBackUpL);
        }

        private void timerLocBu_Click(object sender, EventArgs e) {
            TimeSpan beginTime = new TimeSpan();
            if (beginTimePicker.Value > DateTime.Now)
                beginTime = beginTimePicker.Value - DateTime.Now;
            TimeSpan span = new TimeSpan(Decimal.ToInt32(dayUpDown.Value)
                , Decimal.ToInt32(hourUpDown.Value)
                , Decimal.ToInt32(minuteUpDown.Value));
            TimerConfGeter tgeter = new TimerConfGeter();

            List<Host> hostlist = new List<Host>();
            foreach (object item in timerBackUpL.Items) {
                hostlist.Add((item as ListViewItem).Tag as Host);
            }

            TimerStruct ts = new TimerStruct();
            ts.hosts = hostlist;
            ts.logbox = this.timerLogTBox;

            this.timersTimer = new System.Threading.Timer(new TimerCallback(tgeter.fun), ts, beginTime, span);
            this.stopLocal.Enabled = true;
            this.timerLocBu.Enabled = false;
        }

        private void timerRemBu_Click(object sender, EventArgs e) {
            
        }

        private void stopLocal_Click(object sender, EventArgs e) {
            this.timersTimer.Dispose();
            this.stopLocal.Enabled = false;
            this.timerLocBu.Enabled = true;
        }
    }

    public class TimerStruct {
        public List<Host> hosts;
        public TextBox logbox;
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
            GetConfThread conf = new GetConfThread(ts.logbox, ts.hosts);
            conf.GetConfNoThread();

            lock (locker) {
                --threadcount;
            }
        }
    }   
}
