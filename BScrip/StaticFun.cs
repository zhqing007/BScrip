using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using BScrip.BSDevice;
using System.IO;

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

        public static void GetCommandDicAndClassName(string brand, string model, ref Dictionary<string, string> comdic, ref string classname) {
            StringBuilder sqlb = new StringBuilder();
            sqlb.Append("select key,value,class from devicecommand left join devicebrand ")
                .Append("on devicecommand.comid=devicebrand.comid where brand='")
                .Append(brand).Append("' and model='")
                .Append(model).Append("'");
            DataTable comtab = DBhelper.ExecuteDataTable(sqlb.ToString(), null);
            comdic = new Dictionary<string, string>();
            foreach (DataRow row in comtab.Rows) {
                comdic.Add(row["key"].ToString(), row["value"].ToString());
            }
            classname = comtab.Rows[0]["class"].ToString();
        }

        public static void AddCommandDic(string brand, string model, ref Dictionary<string, string> comdic) {
            StringBuilder sqlb = new StringBuilder();
            sqlb.Append("select key,value from devicecommand left join devicebrand ")
                .Append("on devicecommand.comid=devicebrand.comid where brand='")
                .Append(brand).Append("' and model='")
                .Append(model).Append("'");
            DataTable comtab = DBhelper.ExecuteDataTable(sqlb.ToString(), null);
            foreach (DataRow row in comtab.Rows) {
                if (comdic.ContainsKey(row["key"].ToString()))
                    comdic[row["key"].ToString()] = row["value"].ToString();
                else
                    comdic.Add(row["key"].ToString(), row["value"].ToString());
            }
        }

        public static Dictionary<string, string> GetCommandDic(string brand, string model) {
            Dictionary<string, string> comdic = new Dictionary<string, string>();
            StringBuilder sqlb = new StringBuilder();
            sqlb.Append("select key,value from devicecommand left join devicebrand ")
                .Append("on devicecommand.comid=devicebrand.comid where brand='")
                .Append(brand).Append("' and model='")
                .Append(model).Append("'");
            DataTable comtab = DBhelper.ExecuteDataTable(sqlb.ToString(), null);
            foreach (DataRow row in comtab.Rows) {
                comdic.Add(row["key"].ToString(), row["value"].ToString());
            }

            return comdic;
        }

        public static string GetClassName(string brand, string model) {
            StringBuilder sqlb = new StringBuilder();
            sqlb.Append("select class from devicebrand where brand='")
                .Append(brand).Append("' and model='")
                .Append(model).Append("'");
            DataTable comtab = DBhelper.ExecuteDataTable(sqlb.ToString(), null);

            return comtab.Rows[0]["class"].ToString();
        }

        public static StreamReader StrToStream(string txt) {
            Stream txtstr = new MemoryStream(ASCIIEncoding.Default.GetBytes(txt));
            return new StreamReader(txtstr);
        }

        public static BSDevice.Device HuaWeiFactory(Linker _linker) {
            if (_linker == null) return null;
            HuaweiDevice devhua = new HuaweiDevice(_linker);
            DeviceBaseInfo devinfo = devhua.GetBaseInfo();

            Type type = Type.GetType(GetClassName(devinfo.brand, devinfo.model));
            Device dev = System.Activator.CreateInstance(type, new object[] { _linker, devhua.comdic }) as Device;
            dev.SuperMe();
            return dev;
        }

        public static BSDevice.Device CiscoFactory(Linker _linker) {
            if (_linker == null) return null;
            CiscoDevice devcisco = new CiscoDevice(_linker);
            DeviceBaseInfo devinfo = devcisco.GetBaseInfo();

            Type type = Type.GetType(GetClassName(devinfo.brand, devinfo.model));
            Device dev = System.Activator.CreateInstance(type, new object[] { _linker, devcisco.comdic }) as Device;
            dev.SuperMe();
            return dev;
        }
    }
}
