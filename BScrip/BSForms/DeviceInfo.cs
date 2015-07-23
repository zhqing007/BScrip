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
    public partial class DeviceInfo : BSForm {
        private Host devicehost = null;
        private DataTable intfinfo = null;
        private delegate void UpdateDelegate();
        private BSMessageBox msgbox = null;
        private System.Threading.Semaphore semlock = null;

        public DeviceInfo(Host sw) {
            InitializeComponent();
            semlock = new System.Threading.Semaphore(0, 1);
            msgbox = new BSMessageBox("正在查询，请稍后！");
            AddHost(sw);
            msgbox.Show();
        }

        private void refresh_Click(object sender, EventArgs e) {
            interfaceWorker.RunWorkerAsync();
        }

        private void baseinfoWorker_DoWork(object sender, DoWorkEventArgs e) {
            devbaseinfo.Text = StaticFun.serverclient.GetBaseInfo(devicehost);
            semlock.Release();
        }

        private void DisplayInterfaceInfo() {
            if (intfinfo != null)
                interfaceGridView.DataSource = intfinfo;
        }

        private void interfaceWorker_DoWork(object sender, DoWorkEventArgs e) {
            intfinfo = StaticFun.serverclient.GetInterfaceInfo(devicehost);
            UpdateDelegate fc = new UpdateDelegate(DisplayInterfaceInfo);
            interfaceGridView.Invoke(fc);
            this.refresh.Enabled = true;
            semlock.WaitOne();
            msgbox.Close();
        }

        public override void AddHost(Host sw = null) {
            this.devicehost = sw;
            baseinfoWorker.RunWorkerAsync();
            refresh_Click(null, null);
        }
    }
}
