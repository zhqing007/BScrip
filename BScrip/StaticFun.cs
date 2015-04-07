using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip {
    public class StaticFun {
        public static void SelectAll_ListView(ListView lv) {
            foreach (ListViewItem h in lv.Items)
                h.Selected = true;
            lv.Focus();
        }

        public static bool AddHostListToListViewTag(List<Host> hl, ListView lv) {
            if (hl.Count == 0) return false;
            bool befind = false;
            foreach (Host h in hl) {
                befind = false;
                foreach (ListViewItem downh in lv.Items)
                    if (h.hostname.Equals((downh.Tag as Host).hostname)) { befind = true; break; };
                if (befind) continue;

                ListViewItem lvi = new ListViewItem();
                lvi.Tag = h;
                lv.Items.Add(lvi);
            }
            return true;
        }

        public static bool IsIPAddress(string ip) {
            if (ip == null) return false;
            string regex = @"^(2[0-4]\d|25[0-5]|[01]?\d?\d)\." +
                    @"(2[0-4]\d|25[0-5]|[01]?\d?\d)\." +
                    @"(2[0-4]\d|25[0-5]|[01]?\d?\d)\." +
                    @"(2[0-4]\d|25[0-5]|[01]?\d?\d)$";
            return System.Text.RegularExpressions.Regex.IsMatch(ip.Trim(), regex);
        }

        public static bool CheckHostInfo(string name, string ip, string loginn, string pw) {
            if (name == null || name.Trim().Length == 0) {
                MessageBox.Show("没有填主机名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StaticFun.IsIPAddress(ip)) {
                MessageBox.Show("IP格式不对！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (loginn == null || loginn.Trim().Length == 0) {
                MessageBox.Show("没有填登录名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pw == null || pw.Length == 0) {
                MessageBox.Show("没有填密码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
