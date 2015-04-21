using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BScrip.BSDevice;
using System.Windows.Forms.DataVisualization.Charting;

namespace BScrip.BSForms {
    public partial class DeviceViewer : Form {
        private Host devicehost = null;
        private DeviceBaseInfo dbi;
        private List<ResourcesUtilization> cpurulist;
        private List<ResourcesUtilization> memrulist;
        private DataTable intfinfo;
        private TimeSpan refreshtimespan;
        private Device dev;


        public DeviceViewer(Host sw) {
            InitializeComponent();
            devicehost = sw;
            refreshtimespan = new TimeSpan(0, 0, 5);
            loadbasebg.RunWorkerAsync();
        }

        private void bGWorker_DoWork(object sender, DoWorkEventArgs e) {
            try {
                if (devicehost.loginmode == 0) {
                    dev = Device.DeviceFactory(new TelnetLinker(devicehost.ipaddress, devicehost.loginname, devicehost.password));
                    //Addstr(_server, "Telnet登录");
                }
                else {
                    dev = Device.DeviceFactory(new SSH2Linker(devicehost.ipaddress, devicehost.loginname, devicehost.password));
                    //Addstr(_server, "SSH2登录");
                }
                dev.SuperPassWord = devicehost.superpw;
                dbi = dev.GetBaseInfo();
                cpurulist = dev.GetCpuUsage();
                memrulist = dev.GetMemUsage();
                intfinfo = dev.GetInterfaceBrif();
                foreach (ResourcesUtilization cpuu in cpurulist) {
                    Series slotser = new Series();
                    slotser.BorderWidth = 3;
                    slotser.ChartArea = this.cpuresourceschart.ChartAreas[0].Name;
                    slotser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    slotser.Legend = this.cpuresourceschart.Legends[0].Name;
                    slotser.Name = cpuu.slotname;
                    this.cpuresourceschart.Series.Add(slotser);
                    slotser = new Series();
                    slotser.BorderWidth = 3;
                    slotser.ChartArea = this.cpuresourceschart.ChartAreas[0].Name;
                    slotser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    slotser.Legend = this.cpuresourceschart.Legends[0].Name;
                    slotser.Name = cpuu.slotname;
                    this.memresourceschart.Series.Add(slotser);
                }

                RefreshData();
                devbaseinfo.AppendText(dbi.ToString());

                while (true) {
                    Thread.Sleep(refreshtimespan);
                    cpurulist = dev.GetCpuUsage();
                    memrulist = dev.GetMemUsage();
                    intfinfo = dev.GetInterfaceBrif();
                    RefreshData();
                }
                
            }
            catch (Exception exc) {
                //Addstr(_server, "导出配置出现异常：" + exc.StackTrace);
            }
        }

        private void bGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            
        }

        private void refreshinfobg_DoWork(object sender, DoWorkEventArgs e) {
            
        }

        private void RefreshData() {
            for (int i = 0; i < cpurulist.Count; ++i) {
                cpuresourceschart.Series[i].Points.AddY(cpurulist[i].s5);
                if (cpuresourceschart.Series[i].Points.Count > cpuresourceschart.ChartAreas[0].AxisX.Maximum)
                    cpuresourceschart.Series[i].Points.RemoveAt(0);
            }

            for (int i = 0; i < memrulist.Count; ++i) {
                memresourceschart.Series[i].Points.AddY(memrulist[i].max);
                if (memresourceschart.Series[i].Points.Count > memresourceschart.ChartAreas[0].AxisX.Maximum)
                    memresourceschart.Series[i].Points.RemoveAt(0);
            }
        }
    }
}
