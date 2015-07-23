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
using System.Windows.Forms.DataVisualization.Charting;

namespace BScrip.BSForms {
    public partial class DeviceViewer : Form {
        private Host devicehost = null;
        //private DeviceBaseInfo dbi;
        //private List<ResourcesUtilization> cpurulist;
        //private List<ResourcesUtilization> memrulist;
        private TimeSpan refreshtimespan;
        //private Device dev;
        private delegate void UpdateDelegate();
        private List<UpdateDelegate> tasklist = new List<UpdateDelegate>();
        
        private static object locker = new object();
        private static object timelocker = new object();
        private bool quit = false;
        UpdateDelegate refresh_c;
        UpdateDelegate refresh_m;
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        public DeviceViewer() {
            InitializeComponent();
            refresh_c = new UpdateDelegate(RefreshCpuUsage);
            refresh_m = new UpdateDelegate(RefreshMemUsage);
        }

        public string GetDeviceName() {
            return devicehost.hostname;
        }

        private void interfaceGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Value.ToString().Contains('%')) {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
                string percent = e.Value.ToString().Trim();
                float wightpercent = Int32.Parse(percent.Substring(0, percent.Length - 1));
                Rectangle percentrect = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2
                    , (int)((e.CellBounds.Width - 4) * wightpercent / 100)
                    , e.CellBounds.Height - 4);
                Color bc;
                if (wightpercent <= 50)
                    bc = Color.FromArgb(0, (int)(wightpercent / 50 * 255), (int)((1 - wightpercent / 50) * 255));
                else
                    bc = Color.FromArgb((int)((wightpercent / 50 - 1) * 255), (int)((2 - wightpercent / 50) * 255), 0);

                Brush brush = new SolidBrush(bc);//填充的颜色
                e.Graphics.FillRectangle(brush, percentrect);
                e.Graphics.DrawString("sdfgsdgsd", e.CellStyle.Font, Brushes.Black,
                            e.CellBounds.Left + 5, e.CellBounds.Top + 5, StringFormat.GenericDefault);
                e.Handled = true;
            }
        }

        public void SetTimeSpan(TimeSpan span) {
            lock (timelocker) {
                refreshtimespan = span;
            }
        }

        private void RefreshCpuUsage() {
            //LogMessageForm.logForm.AddLog(devicehost, "正在读取设备CPU占用率");
            //cpurulist = dev.GetCpuUsage();
            //LogMessageForm.logForm.AddLog(devicehost, "读取设备CPU占用率结束");

            //if (this.cpuresourceschart.Series.Count == 0)
            //    foreach (ResourcesUtilization cpuu in cpurulist) {
            //        Series slotser = new Series();
            //        slotser.BorderWidth = 3;
            //        slotser.ChartArea = this.cpuresourceschart.ChartAreas[0].Name;
            //        slotser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //        slotser.Legend = this.cpuresourceschart.Legends[0].Name;
            //        slotser.Name = cpuu.slotname;
            //        this.cpuresourceschart.Series.Add(slotser);
            //    }

            //for (int i = 0; i < cpurulist.Count; ++i) {
            //    cpuresourceschart.Series[i].Points.AddY(cpurulist[i].s5);
            //    if (cpuresourceschart.Series[i].Points.Count > cpuresourceschart.ChartAreas[0].AxisX.Maximum)
            //        cpuresourceschart.Series[i].Points.RemoveAt(0);
            //}
        }

        private void RefreshMemUsage() {
            //LogMessageForm.logForm.AddLog(devicehost, "正在读取设备内存占用率");
            //memrulist = dev.GetMemUsage();
            //LogMessageForm.logForm.AddLog(devicehost, "读取设备内存占用率结束");

            //if (memresourceschart.Series.Count == 0)
            //    foreach (ResourcesUtilization memu in memrulist) {
            //        Series slotser = new Series();
            //        slotser.BorderWidth = 3;
            //        slotser.ChartArea = this.cpuresourceschart.ChartAreas[0].Name;
            //        slotser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //        slotser.Legend = this.cpuresourceschart.Legends[0].Name;
            //        slotser.Name = memu.slotname;
            //        this.memresourceschart.Series.Add(slotser);
            //    }

            //for (int i = 0; i < memrulist.Count; ++i) {
            //    memresourceschart.Series[i].Points.AddY(memrulist[i].max);
            //    if (memresourceschart.Series[i].Points.Count > memresourceschart.ChartAreas[0].AxisX.Maximum)
            //        memresourceschart.Series[i].Points.RemoveAt(0);
            //}
        }

        private void addhostButton_Click(object sender, EventArgs e) {
            List<Host> lh = HostsForm.allhostsform.GetSelectHosts();
            if (lh.Count == 0) return;
            DateTime begin = new DateTime(monthPicker.Value.Year, monthPicker.Value.Month,1);
            DateTime end = new DateTime(monthPicker.Value.Year, monthPicker.Value.Month + 1, 1);
            int i = 0;
            int cpuo = 0;
            int memo = 0;
            foreach(Host h in lh){
                ROccupy[] occupy = StaticFun.serverclient.GetCpuMemOccupy(h, begin, end);
                if (occupy.Length == 0) continue;
                ListViewItem vitem = new ListViewItem();
                vitem.Tag = occupy;
                vitem.Text = (++i).ToString();
                foreach(ROccupy ro in occupy){
                    cpuo += ro.CpuOccupy;
                    memo += ro.MemOccupy;
                }

                cpuo /= occupy.Length;
                memo /= occupy.Length;

                vitem.SubItems.Add(h.hostname);
                vitem.SubItems.Add(h.ipaddress);
                vitem.SubItems.Add("" + cpuo + "%");
                vitem.SubItems.Add("" + memo + "%");
                resutilizelist_v.Items.Add(vitem);
            }
        }

        private void removehostButton_Click(object sender, EventArgs e) {
            for(int i = resutilizelist_v.SelectedItems.Count - 1; i >= 0; --i)
                resutilizelist_v.Items.Remove(resutilizelist_v.SelectedItems[i]);
        }

        private void export_Click(object sender, EventArgs e) {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "xls文件|*.xls";
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            DataTable dt = StaticFun.listViewToDataTable(resutilizelist_v);
            dt.TableName = DateTime.Now.ToString("yyyy年MM月dd日");
            NPOIHelper.ExportDataTableToExcel(dt, fileDialog.FileName);
        }

        private void backupinfo_Click(object sender, EventArgs e) {
            if (resutilizelist_v.Items.Count == 0) {
                MessageBox.Show("没有选择设备！"
                    , "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Host> hosts = new List<Host>();
            foreach (ListViewItem h in resutilizelist_v.Items) {
                Host hos = new Host();
                hos.ipaddress = h.SubItems[1].Text;
                hosts.Add(hos);
            }
            DateTime begin = new DateTime(monthPicker.Value.Year, monthPicker.Value.Month, 1);
            DateTime end = new DateTime(monthPicker.Value.Year, monthPicker.Value.Month + 1, 1);
            (new BackUpAnaForm(hosts, begin, end)).ShowDialog();
        }

        private void resutilizelist_v_SelectedIndexChanged(object sender, EventArgs e) {
            if(resutilizelist_v.SelectedItems.Count == 0) return;
            slotlistview.Items.Clear();
            ROccupy[] occupy = (ROccupy[])(resutilizelist_v.SelectedItems[0].Tag);
            for(int i= 0; i < occupy.Length; ++i) {
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(occupy[i].SlotName);
                item.SubItems.Add("" + occupy[i].CpuOccupy + "%");
                item.SubItems.Add("" + occupy[i].MemOccupy + "%");
                slotlistview.Items.Add(item);
            }
        }

        private void timespanset_Click(object sender, EventArgs e) {
            CPUMemTimeSpan cmsetbox = new CPUMemTimeSpan();
            cmsetbox.ShowDialog();
        }
    }
}
