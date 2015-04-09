using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip {
    public partial class FileTransfer : Form {
        public const int NOTSAVE = 0;
        public const int NEWSERVER = 1;
        public const int UPDATESERVER = 2;

        public FileTransfer() {
            InitializeComponent();
            List<Host> serverList = Host.GetAllServer();
            foreach(Host server in serverList){
                serverBox.Items.Add(server);
            }
        }

        private void OKButton_Click(object sender, EventArgs e) {
            if (StaticFun.CheckHostInfo(serverBox.Text, ipBox.Text, loginNameBox.Text, PWBox.Text))
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            //MessageBox.Show("" + serverBox.SelectedIndex);
            this.DialogResult = DialogResult.Cancel;
        }

        public Host GetServer() {
            Host h = new Host(serverBox.Text.Trim());
            h.ipaddress = ipBox.Text.Trim();
            h.loginmode = 1; //SSH2
            h.loginname = loginNameBox.Text.Trim();
            h.password = PWBox.Text;
            h.type = 1; //服务器
            return h;
        }
        
        private void serverBox_SelectionChangeCommitted(object sender, EventArgs e) {
            Host selectServer = serverBox.SelectedItem as Host;
            ipBox.Text = selectServer.ipaddress;
            loginNameBox.Text = selectServer.loginname;
            PWBox.Text = selectServer.password;
        }

        //0: 不保存；1：新建；2：更新
        public int SaveOrNot() {
            if (!savedServer.Checked) return NOTSAVE;
            string hostname = serverBox.Text.Trim();
            object obj = null;
            foreach (object o in serverBox.Items) {
                if (hostname.Equals(o.ToString())) {
                    obj = o;
                    break;
                }
            }
            if (obj == null) return NEWSERVER;
            if (obj == GetServer()) return NOTSAVE;
            return UPDATESERVER;
        }
    }
}
