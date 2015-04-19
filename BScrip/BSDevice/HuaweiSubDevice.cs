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
            devinfo.ReadLine();
            devinfo.ReadLine();
            devinfo.ReadLine();
            string[] devstrs;
            while (!devinfo.EndOfStream) {
                devstrs = devinfo.ReadLine().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                SoltInfo.Rows.Add(devstrs);
            }
            return SoltInfo;
        }

        private ResourcesUtilization GetOneCpuUsage(string cpuu) {
            StreamReader strreader = StaticFun.StrToStream(cpuu);
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
            intInfo.Columns.Add("Interface", typeof(string));
            intInfo.Columns.Add("PHY", typeof(string));
            intInfo.Columns.Add("Protocol", typeof(string));
            intInfo.Columns.Add("InUti", typeof(string));
            intInfo.Columns.Add("OutUti", typeof(string));

            StreamReader devinforeader = StaticFun.StrToStream(GetMessage("display int brief", LEVEL3_MARK_STR));
            string str;
            while ((str = devinforeader.ReadLine()).IndexOf("Interface") < 0) ;
            devinforeader.ReadLine();
            string[] intfarray;
            while (!devinforeader.EndOfStream) {
                intfarray = devinforeader.ReadLine().Split(new char[] { ' ' }, 5, System.StringSplitOptions.RemoveEmptyEntries);
                intInfo.Rows.Add(intfarray);
            }
            return intInfo;
        }

    }
}
