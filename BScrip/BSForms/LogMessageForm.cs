using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip.BSForms {
    public partial class LogMessageForm : Form {
        public static LogMessageForm logForm = null;

        public LogMessageForm() {
            InitializeComponent();
        }

        public void AddLog(Host item, string str) {
            ListViewItem logitem = new ListViewItem();
            logitem.Text = (loglist.Items.Count + 1).ToString();
            logitem.SubItems.Add(DateTime.Now.GetDateTimeFormats('g')[0].ToString());
            logitem.SubItems.Add(item.ipaddress);
            logitem.SubItems.Add(str);
            this.loglist.Items.Add(logitem);
        }
    }
}
