using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace BScrip.BSDevice {
    class HuaweiDeviceS9700 : HuaweiDevice {
        public HuaweiDeviceS9700(Linker _lin, Dictionary<string, string> _comdic = null)
            : base(_lin, _comdic, "HUAWEI", "Quidway S9700"){ }

        public override DataTable GetSoltInfo() {
            if(SoltInfo != null) return SoltInfo;
            SoltInfo = new DataTable();
            SoltInfo.Columns.Add("Slot", typeof(string));
            SoltInfo.Columns.Add("Sub", typeof(string));
            SoltInfo.Columns.Add("Type", typeof(string));
            SoltInfo.Columns.Add("Online", typeof(string));
            SoltInfo.Columns.Add("Power", typeof(string));
            SoltInfo.Columns.Add("Register", typeof(string));
            SoltInfo.Columns.Add("Alarm", typeof(string));
            SoltInfo.Columns.Add("Primary", typeof(string));

            StreamReader devinfo = StaticFun.StrToStream(GetDeviceInfo());
            while (!devinfo.ReadLine().Contains("- - - -")) ;
            string[] devstrs;
            while (!devinfo.EndOfStream) {
                devstrs = devinfo.ReadLine().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                if (devstrs[2].Length == 1 || devstrs[7].Length != 2) continue;
                SoltInfo.Rows.Add(devstrs);
            }
            return SoltInfo;
        }

        private ResourcesUtilization GetOneCpuUsage(string cpuu) {
            StreamReader strreader = StaticFun.StrToStream(cpuu);
            strreader.ReadLine();
            strreader.ReadLine();
            string str = strreader.ReadLine();
            ResourcesUtilization ru = new ResourcesUtilization();
            ru.max = Int32.Parse(str.Substring(str.IndexOf("Max:") + 4, 3).Trim());
            strreader.ReadLine();
            str = strreader.ReadLine();
            ru.s5 = Int32.Parse(str.Substring(str.IndexOf("five seconds:") + 13, 3).Trim());
            ru.m1 = Int32.Parse(str.Substring(str.IndexOf("one minute:") + 11, 3).Trim());
            ru.m5 = Int32.Parse(str.Substring(str.IndexOf("five minutes:") + 13, 3).Trim());
            str = strreader.ReadLine();
            ru.maxtime = str.Substring(str.IndexOf("Time :") + 6).Trim();
            return ru;
        }

        private ResourcesUtilization GetOneMemUsage(string memu) {
            StreamReader strreader = StaticFun.StrToStream(memu);
            string str;
            while ((str = strreader.ReadLine()).IndexOf('%') < 0) ;
            ResourcesUtilization ru = new ResourcesUtilization();
            ru.max = Int32.Parse(str.Substring(str.IndexOf('%') - 3, 3).Trim());
            return ru;
        }

        public override List<ResourcesUtilization> GetCpuUsage() {
            List<ResourcesUtilization> rulist = new List<ResourcesUtilization>();
            ResourcesUtilization ru = GetOneCpuUsage(GetMessage("dis cpu-usage", LEVEL3_MARK_STR));
            ru.slotname = "Main";
            rulist.Add(ru);

            DataTable solts = GetSoltInfo();
            foreach (DataRow solt in solts.Rows) {
                ru = GetOneCpuUsage(GetMessage("dis cpu-usage slot " + solt["Slot"].ToString(), LEVEL3_MARK_STR));
                ru.slotname = solt["Slot"].ToString() + '-' + solt["Type"].ToString();
                rulist.Add(ru);
            }

            return rulist;
        }

        public override List<ResourcesUtilization> GetMemUsage() {
            List<ResourcesUtilization> rulist = new List<ResourcesUtilization>();
            ResourcesUtilization ru = GetOneMemUsage(GetMessage("display memory-usage", LEVEL3_MARK_STR));
            ru.slotname = "Main";
            rulist.Add(ru);

            DataTable solts = GetSoltInfo();
            foreach (DataRow solt in solts.Rows) {
                ru = GetOneMemUsage(GetMessage("display memory-usage slot " + solt["Slot"].ToString(), LEVEL3_MARK_STR));
                ru.slotname = solt["Slot"].ToString() + '-' + solt["Type"].ToString();
                rulist.Add(ru);
            }

            return rulist;
        }

        public override DataTable GetInterfaceBrif() {
            DataTable intInfo = new DataTable();
            intInfo.Columns.Add("端口", typeof(string));
            intInfo.Columns.Add("物理链路", typeof(string));
            intInfo.Columns.Add("数据链路", typeof(string));
            intInfo.Columns.Add("输入流量", typeof(string));
            intInfo.Columns.Add("输出流量", typeof(string));

            StreamReader devinforeader = StaticFun.StrToStream(GetMessage("display int brief", LEVEL3_MARK_STR));
            string str;
            while ((str = devinforeader.ReadLine()).IndexOf("Interface") < 0) ;
            string[] intfarray;
            while (!devinforeader.EndOfStream) {
                if ((str = devinforeader.ReadLine()).IndexOf(LEVEL3_MARK_STR) >= 0) break;                
                intfarray = str.Split(new char[] { ' ' }, 5, System.StringSplitOptions.RemoveEmptyEntries);
                intfarray[4] = intfarray[4].Substring(0, intfarray[4].IndexOf(' '));
                intInfo.Rows.Add(intfarray);
            }
            return intInfo;
        }
    }

    class HuaweiDeviceS8500 : HuaweiDevice {
        public HuaweiDeviceS8500(Linker _lin, Dictionary<string, string> _comdic = null)
            : base(_lin, _comdic, "HUAWEI", "Quidway S8500") { }

        public override DataTable GetSoltInfo() {
            if(SoltInfo != null) return SoltInfo;
            SoltInfo = new DataTable();
            SoltInfo.Columns.Add("Slot", typeof(string));
            SoltInfo.Columns.Add("Type", typeof(string));
            SoltInfo.Columns.Add("Status", typeof(string));
            SoltInfo.Columns.Add("Subslot", typeof(string));
            SoltInfo.Columns.Add("SftVer", typeof(string));

            StreamReader devinfo = StaticFun.StrToStream(GetDeviceInfo());
            while (!devinfo.ReadLine().Contains("Slot No.")) ;
            string[] devstrs;
            while (!devinfo.EndOfStream) {
                devstrs = devinfo.ReadLine().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                if (devstrs[2].Equals("Absent")) continue;
                SoltInfo.Rows.Add(devstrs);
            }
            return SoltInfo;
        }

        public override List<ResourcesUtilization> GetCpuUsage() {
            List<ResourcesUtilization> rulist = new List<ResourcesUtilization>();
            string cpuu = GetMessage("dis cpu", LEVEL3_MARK_STR);
            StreamReader strreader = StaticFun.StrToStream(cpuu);
            DataTable solts = GetSoltInfo();
            foreach (DataRow row in solts.Rows) {
                while (!strreader.ReadLine().Contains("Board")) ;
                ResourcesUtilization ru = new ResourcesUtilization();
                ru.slotname = row["Slot"].ToString() + '-' + row["Type"].ToString();
                string str = strreader.ReadLine().Trim();
                ru.s5 = Int32.Parse(str.Substring(0, str.IndexOf('%')));
                str = strreader.ReadLine().Trim();
                ru.m1 = Int32.Parse(str.Substring(0, str.IndexOf('%')));
                str = strreader.ReadLine().Trim();
                ru.m5 = Int32.Parse(str.Substring(0, str.IndexOf('%')));
                rulist.Add(ru);
            }
            return rulist;
        }

        public override List<ResourcesUtilization> GetMemUsage() {
            List<ResourcesUtilization> rulist = new List<ResourcesUtilization>();
            DataTable solts = GetSoltInfo();
            StringBuilder comstrb = new StringBuilder();
            foreach (DataRow solt in solts.Rows) {
                comstrb.Append("dis memory solt ").Append(solt["Slot"].ToString())
                    .Append(System.Environment.NewLine);
            }
            comstrb.Append(Device.End);

            string meminfo = GetMessage(comstrb.ToString(), Device.End);
            StreamReader strreader = StaticFun.StrToStream(meminfo);
            string str;
            foreach (DataRow solt in solts.Rows) {
                while (!(str = strreader.ReadLine()).Contains('%')) ;
                ResourcesUtilization ru = new ResourcesUtilization();
                ru.slotname = solt["Slot"].ToString() + '-' + solt["Type"].ToString();
                ru.max = Int32.Parse(str.Substring(str.IndexOf('%') - 3, 3).Trim());
                rulist.Add(ru);
            }
            return rulist;
        }

        public override DataTable GetInterfaceBrif() {
            DataTable intInfo = new DataTable();
            intInfo.Columns.Add("端口", typeof(string));
            intInfo.Columns.Add("链路", typeof(string));
            intInfo.Columns.Add("速度", typeof(string));
            intInfo.Columns.Add("双工", typeof(string));
            intInfo.Columns.Add("类型", typeof(string));
            intInfo.Columns.Add("PVID", typeof(string));
            intInfo.Columns.Add("描述", typeof(string));

            StreamReader devinforeader = StaticFun.StrToStream(GetMessage("dis bri int", LEVEL3_MARK_STR));
            string str;
            while ((str = devinforeader.ReadLine()).IndexOf("------------") < 0) ;
            string[] intfarray;
            while (!devinforeader.EndOfStream) {
                if ((str = devinforeader.ReadLine()).Contains(LEVEL3_MARK_STR)) break;
                intfarray = str.Split(new char[] { ' ' }, 7, System.StringSplitOptions.RemoveEmptyEntries);
                intInfo.Rows.Add(intfarray);
            }
            return intInfo;
        }
    }
}
