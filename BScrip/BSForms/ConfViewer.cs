using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BScrip.BScripService;

namespace BScrip.BSForms {
    public partial class ConfViewer : BSForm {
        private Host devicehost;
        bool isloaded = false;

        public ConfViewer(Host sw) {
            InitializeComponent();
            AddHost(sw);
        }

        private void FindConf() {
            //DataTable conftime = DBhelper.GetDeviceConfTime(devicehost.hostname
            //    , beginTimePicker.Value, endTimePicker.Value);

            //foreach (DataRow row in conftime.Rows)
            //    configlist.Items.Add(row[0]);
        }

        private void datelist_SelectedIndexChanged(object sender, EventArgs e) {
            //if(configlist.SelectedItem != null)
            //    confrichtb.Text = DBhelper.GetDeviceConfiguration(devicehost.hostname, (DateTime)(configlist.SelectedItem));
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            if (confrichtb.SelectedText.Length > 0) contextMenuCopy.Enabled = true;
            else contextMenuCopy.Enabled = false;
        }

        private void contextMenuCopy_Click(object sender, EventArgs e) {
            Clipboard.SetText(confrichtb.SelectedText.Replace("\n", "\r\n"));//复制内容到剪切板
        }

        private void beginTimePicker_ValueChanged(object sender, EventArgs e) {
            if (isloaded) {
                configlist.Items.Clear();
                confrichtb.Clear();
                FindConf();
            }
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e) {
            if (isloaded) {
                configlist.Items.Clear();
                confrichtb.Clear();
                FindConf();
            }
        }

        public override void AddHost(Host sw) {
            isloaded = false;
            devicehost = sw;

            StringBuilder dinfo = new StringBuilder();
            dinfo.Append("设备名称：").Append(devicehost.hostname)
                .Append("\tIP地址：").Append(devicehost.ipaddress);
            hostinfotb.Text = dinfo.ToString();

            endTimePicker.Value = DateTime.Now;
            isloaded = true;
            beginTimePicker.Value = endTimePicker.Value.AddMonths(-1);
        }

        private void saveto_Click(object sender, EventArgs e) {
            if (configlist.SelectedItem == null) {
                MessageBox.Show("请选择配置！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            StringBuilder fileN = new StringBuilder(devicehost.hostname);
            fileN.Append('_').Append(devicehost.ipaddress.Replace('.', '_'))
                .Append('_').Append(DateTime.Now.ToString("yyyyMMddHHmm"));
            fileDialog.FileName = fileN.ToString();
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            
            System.IO.StreamWriter sw = System.IO.File.CreateText(fileDialog.FileName);
            //sw.Write(DBhelper.GetDeviceConfiguration(devicehost.hostname, (DateTime)(configlist.SelectedItem)));
            sw.Close();
            LogMessageForm.logForm.AddLog(devicehost, "已导出配置文件：" + fileDialog.FileName);
        }

        private void upto_Click(object sender, EventArgs e) {
            FileTransfer tranHost = new FileTransfer();
            tranHost.ShowDialog();
            if (tranHost.DialogResult != DialogResult.OK) return;
            Host server = tranHost.GetServer();

            //DateTime savetime = (DateTime)(configlist.SelectedItem);
            //BScrip.BSThread.ConfThread.HostConfigStruct hc = new BSThread.ConfThread.HostConfigStruct();
            //hc.device = devicehost;
            //hc.filename = savetime.ToString("yyyyMMddHHmm") + ".txt";
            //hc.config = DBhelper.GetDeviceConfiguration(devicehost.hostname, (DateTime)(configlist.SelectedItem));

            //BScrip.BSThread.ConfThread.UploadAConfigToServer(server, hc);            
        }
    }
}
