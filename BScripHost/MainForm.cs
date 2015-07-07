using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace BScripHost {
    public partial class MainForm : Form {
        ServiceHost host;

        public MainForm() {
            InitializeComponent();
            host = null;
        }

        private void start_Click(object sender, EventArgs e) {
            if (host != null && host.State == CommunicationState.Opened) {
                MessageBox.Show("服务正在运行！");
                return;
            }
            host = new ServiceHost(typeof(BScripServiceLibrary.BSService));
            host.Opened += delegate { MessageBox.Show("服务已经启动！"); };
            host.Closed += delegate { MessageBox.Show("服务已经停止！"); };
            host.Open();
        }

        private void stop_Click(object sender, EventArgs e) {
            if (host != null && host.State == CommunicationState.Opened)
                host.Close();
            else
                MessageBox.Show("服务没有运行！");
        }
    }
}
