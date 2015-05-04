using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace BScrip.BSDevice {
    class CiscoDeviceC4500 : CiscoDevice {
        public CiscoDeviceC4500(Linker _lin, Dictionary<string, string> _comdic = null)
            : base(_lin, _comdic, "Cisco", "C4500") { }

        public override DataTable GetSoltInfo() {
            if(SoltInfo != null) return SoltInfo;
            SoltInfo = new DataTable();
            SoltInfo.Columns.Add("Mod", typeof(string));
            SoltInfo.Columns.Add("Ports", typeof(string));
            SoltInfo.Columns.Add("Type", typeof(string));
            SoltInfo.Columns.Add("Model", typeof(string));
            SoltInfo.Columns.Add("Serial", typeof(string));

            StreamReader devinfo = StaticFun.StrToStream(GetDeviceInfo());
            while (!devinfo.ReadLine().Contains("---")) ;
            string[] devstrs = new string[5] ;
            string msg;
            while (!(msg = devinfo.ReadLine()).Contains("addresses")) {
                devstrs[0] = msg.Substring(0, 3).Trim();
                devstrs[1] = msg.Substring(4, 5).Trim();
                devstrs[2] = msg.Substring(10, 38).Trim();
                devstrs[3] = msg.Substring(49, 18).Trim();
                devstrs[4] = msg.Substring(68).Trim();
                SoltInfo.Rows.Add(devstrs);
            }
            return SoltInfo;
        }

        public override List<ResourcesUtilization> GetCpuUsage() {
            try {
                List<ResourcesUtilization> rulist = new List<ResourcesUtilization>();
                StringBuilder comdb = new StringBuilder();
                comdb.Append("show processes cpu").Append(System.Environment.NewLine)
                    .Append('q');
           
                StreamReader strreader = StaticFun.StrToStream(GetMessage(comdb.ToString(), 3));
                string str;
                while (!(str = strreader.ReadLine()).Contains("CPU utilization")) ;
                ResourcesUtilization ru = new ResourcesUtilization();
                int strbegin = str.IndexOf("five seconds:") + 13;
                char[] numb = new char[3];
                int i = 0;
                while (str[strbegin + i] != '%')
                    numb[i] = str[strbegin + i++];
                ru.s5 = Int32.Parse(new string(numb));                
                ru.slotname = "Process switching";
                rulist.Add(ru);

                ru = new ResourcesUtilization();
                strbegin = strbegin + i + 2;
                numb = new char[3];
                i = 0;
                while (str[strbegin + i] != '%')
                    numb[i] = str[strbegin + i++];
                ru.s5 = Int32.Parse(new string(numb));
                ru.slotname = "Interrupt switching";
                rulist.Add(ru);
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
                comdb.Append("show processes memory").Append(System.Environment.NewLine)
                    .Append('q');
                StreamReader strreader = StaticFun.StrToStream(GetMessage(comdb.ToString(), 3));
                string str;
                while (!(str = strreader.ReadLine()).Contains("Total:"));
                ResourcesUtilization ru = new ResourcesUtilization();
                int strbegin = str.IndexOf(':') + 1;
                char[] numb = new char[15];
                int i = 0;
                while (str[strbegin + i] != ',')
                    numb[i] = str[strbegin + i++];
                long totle = Int64.Parse(new string(numb));
                strbegin = strbegin + i + 7;
                numb = new char[15];
                i = 0;
                while (str[strbegin + i] != ',')
                    numb[i] = str[strbegin + i++];
                long used = Int64.Parse(new string(numb));
                ru.max = (int)(((float)used / totle) * 100);
                ru.slotname = "Main";
                rulist.Add(ru);
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
                intInfo.Columns.Add("备注", typeof(string));

                string intmsg = GetMessage("show int des");
                StreamReader devinforeader = StaticFun.StrToStream(intmsg);
                string str;
                while (!(str = devinforeader.ReadLine()).Contains("Interface")) ;
                string[] intfarray;
                while (!devinforeader.EndOfStream) {
                    if ((str = devinforeader.ReadLine()).Contains(Device.End)) break;
                    intfarray = str.Split(new char[] { ' ' }, 4, System.StringSplitOptions.RemoveEmptyEntries);
                    intInfo.Rows.Add(intfarray);
                }
                return intInfo;
            }
            catch(Exception exc) {
                throw exc;
            }
        }
    }
}
