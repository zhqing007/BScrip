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
    }
}
