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
                if (devstrs.Length < 8 || devstrs[2].Length == 1 || devstrs[7].Length != 2) continue;
                SoltInfo.Rows.Add(devstrs);
            }
            return SoltInfo;
        }

        private ResourcesUtilization GetOneCpuUsage(string cpuu) {
            StreamReader strreader = StaticFun.StrToStream(cpuu);
            string str;
            while (!(str = strreader.ReadLine()).Contains("Max:")) ;
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
            while (!(str = strreader.ReadLine()).Contains('%'));
            ResourcesUtilization ru = new ResourcesUtilization();
            ru.max = Int32.Parse(str.Substring(str.IndexOf('%') - 3, 3).Trim());
            return ru;
        }

        public override List<ResourcesUtilization> GetCpuUsage() {
            try {
                List<ResourcesUtilization> rulist = new List<ResourcesUtilization>();
                StringBuilder comdb = new StringBuilder();
                comdb.Append("dis cpu-usage").Append(System.Environment.NewLine)
                    .Append('q').Append(System.Environment.NewLine);

                DataTable solts = GetSoltInfo();
                foreach (DataRow solt in solts.Rows)
                    comdb.Append("dis cpu-usage slot ").Append(solt["Slot"].ToString())
                        .Append(System.Environment.NewLine)
                        .Append('q');

                string rm = GetMessage(comdb.ToString(), 5);
                ResourcesUtilization ru = GetOneCpuUsage(rm);
                ru.slotname = "Main";
                rulist.Add(ru);

                foreach (DataRow solt in solts.Rows) {
                    rm = rm.Substring(rm.IndexOf("slot " + solt["Slot"]));
                    ru = GetOneCpuUsage(rm);
                    ru.slotname = solt["Slot"].ToString() + '-' + solt["Type"].ToString();
                    rulist.Add(ru);
                }

                return rulist;
            }
            catch (Exception exc) {
                throw exc;
            }

        }

        public override List<ResourcesUtilization> GetMemUsage() {
            try {
                List<ResourcesUtilization> rulist = new List<ResourcesUtilization>();
                StringBuilder comdb = new StringBuilder();
                comdb.Append("dis memory-usage");

                DataTable solts = GetSoltInfo();
                foreach (DataRow solt in solts.Rows)
                    comdb.Append(System.Environment.NewLine).Append("dis memory-usage slot ")
                        .Append(solt["Slot"].ToString());
                //Console.WriteLine("******************************************");
                string rm = GetMessage(comdb.ToString());
                ResourcesUtilization ru = GetOneMemUsage(rm);
                ru.slotname = "Main";
                rulist.Add(ru);
                //Console.WriteLine("******************************************");
                foreach (DataRow solt in solts.Rows) {
                    rm = rm.Substring(rm.IndexOf("slot " + solt["Slot"]));
                    ru = GetOneMemUsage(rm);
                    ru.slotname = solt["Slot"].ToString() + '-' + solt["Type"].ToString();
                    rulist.Add(ru);
                }
                return rulist;
            }
            catch (Exception exc) {
                throw exc;
            }
        }

        public override DataTable GetInterfaceBrif() {
            try {
                DataTable intInfo = new DataTable();
                intInfo.Columns.Add("端口", typeof(string));
                intInfo.Columns.Add("物理链路", typeof(string));
                intInfo.Columns.Add("数据链路", typeof(string));
                intInfo.Columns.Add("输入流量", typeof(string));
                intInfo.Columns.Add("输出流量", typeof(string));
                //intInfo.Columns.Add("备注", typeof(string));

                string intmsg = GetMessage("display int brief");
                StreamReader devinforeader = StaticFun.StrToStream(intmsg);
                string str;
                while ((str = devinforeader.ReadLine()).IndexOf("Interface") < 0);
                string[] intfarray;
                while (!devinforeader.EndOfStream) {
                    if ((str = devinforeader.ReadLine()).IndexOf(LEVEL3_MARK_STR) >= 0) break;
                    intfarray = str.Split(new char[] { ' ' }, 5, System.StringSplitOptions.RemoveEmptyEntries);
                    intfarray[4] = intfarray[4].Substring(0, intfarray[4].IndexOf(' '));
                    intInfo.Rows.Add(intfarray);
                }

                //intmsg = GetMessage("display int description ");
                //devinforeader = StaticFun.StrToStream(intmsg);
                //while ((str = devinforeader.ReadLine()).IndexOf("Interface") < 0);
                //while (!devinforeader.EndOfStream) {
                //    if ((str = devinforeader.ReadLine()).IndexOf(LEVEL3_MARK_STR) >= 0) break;
                //    intfarray = str.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

                //    intfarray[4] = intfarray[4].Substring(0, intfarray[4].IndexOf(' '));
                //    intInfo.Rows.Add(intfarray);
                //}

                return intInfo;
            }
            catch(Exception exc) {
                throw exc;
            }
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
            string cpuu = GetMessage("dis cpu");
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

            string meminfo = GetMessage(comstrb.ToString());
            StreamReader strreader = StaticFun.StrToStream(meminfo);
            string str;
            foreach (DataRow solt in solts.Rows) {
                while (!(str = strreader.ReadLine()).Contains('%'));
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

            StreamReader devinforeader = StaticFun.StrToStream(GetMessage("dis bri int"));
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
