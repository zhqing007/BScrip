using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Reflection;

namespace BScrip.BSDevice {
    public enum DeviceType {
        Switch = 10,
        Router = 20,
        FireWall = 30
    }

    public enum Brand {
        Huawei = 10,
        H3C = 20,
        Cisco = 30
    }

    public struct ResourcesUtilization {
        public string slotname;
        public int s5;
        public int m1;
        public int m5;
        public int max;
        public string maxtime;
    }

    public class DeviceBaseInfo {
        public string brand;
        public string devicetype;
        public string model;
        public string softver;
        public string runtime;
        public string other;

        public override string ToString() {
            StringBuilder strb = new StringBuilder();
            strb.Append("厂商:").Append(brand).Append("\t型号:").Append(model)
                .Append(Environment.NewLine).Append("系统版本:").Append(softver)
                .Append(Environment.NewLine).Append("运行时间:").Append(runtime);
            return strb.ToString();
        }
    }

    public abstract class Device {
        //public DeviceType TYPE;
        //public string VERSION;//型号
        //public BrandType BRAND;
        protected static string End = "BScrip_End";
        public Dictionary<string, string> comdic = new Dictionary<string, string>();
        protected Linker lin = null;
        public string SuperPassWord = null;
        protected bool isSuper = false;
        public DeviceBaseInfo baseInfo;
        public DataTable SoltInfo;

        public virtual void Init(Linker _lin, Dictionary<string, string> _comdic, string brand, string model){
            lin = _lin;
            baseInfo = new DeviceBaseInfo();
            baseInfo.brand = brand;
            baseInfo.model = model;
            if (_comdic == null)
                comdic = StaticFun.GetCommandDic(baseInfo.brand, baseInfo.model);
            else {
                comdic = _comdic;
                StaticFun.AddCommandDic(baseInfo.brand, baseInfo.model, ref comdic);
            }
        }

        public string CONFIGURATION_STR {
            get { return comdic["CONFIGURATION_STR"]; }
        }
        public string USERVTY_STR {
            get { return comdic["USERVTY_STR"]; }
        }
        public string SCRLEN_STR {
            get { return comdic["SCRLEN_STR"]; }
        }
        public string UNDOSCRLEN_STR {
            get { return comdic["UNDOSCRLEN_STR"]; }
        }
        public string QUIT_STR {
            get { return comdic["QUIT_STR"]; }
        }
        public string VERSION_STR {
            get { return comdic["VERSION_STR"]; }
        }
        public string LOGIN_MARK_STR {
            get { return comdic["LOGIN_MARK_STR"]; }
        }
        public string PASSWORD_MARK_STR {
            get { return comdic["PASSWORD_MARK_STR"]; }
        }
        public string SUPERPW_MARK_STR {
            get { return comdic["SUPERPW_MARK_STR"]; }
        }
        public string SYS_MARK_STR {
            get { return comdic["SYS_MARK_STR"]; }
        }
        public string CONFIGEND_MARK_STR {
            get { return comdic["CONFIGEND_MARK_STR"]; }
        }
        public string LEVEL1_MARK_STR {
            get { return comdic["LEVEL1_MARK_STR"]; }
        }
        public string LEVEL3_MARK_STR {
            get { return comdic["LEVEL3_MARK_STR"]; }
        }
        public string CONFIGURATION_MODE_STR {
            get { return comdic["CONFIGURATION_MODE_STR"]; }
        }
        public string DEVICE_STR {
            get { return comdic["DEVICE_STR"]; }
        }

        public static Device DeviceFactory(Linker lin) {
            if (lin.Connect().Contains("User Access Verification"))
                return StaticFun.CiscoFactory(lin);
            return StaticFun.HuaWeiFactory(lin);
        }

        protected abstract string GetMessage(string com, int line = 0);
        public abstract DeviceBaseInfo GetBaseInfo();

        public virtual string GetConfiguration() { return GetMessage(CONFIGURATION_STR); }
        public virtual string GetVersion() { return GetMessage(VERSION_STR,7); }
        public virtual string GetDeviceInfo() { return GetMessage(DEVICE_STR); }
        public virtual List<ResourcesUtilization> GetCpuUsage() { return null; }
        public virtual List<ResourcesUtilization> GetMemUsage() { return null; }
        public virtual DataTable GetInterfaceBrif() { return null; }
        public virtual void SuperMe() { }
        public virtual DataTable GetSoltInfo() { return SoltInfo; }

        public virtual void Close() {
            lin.Close();
            lin = null;
        }
    }

    public class HuaweiDevice : Device {
        public HuaweiDevice(Linker _lin, Dictionary<string, string> _comdic = null){
            Init(_lin, _comdic, "HUAWEI", "BASE");
        }

        public HuaweiDevice(Linker _lin, Dictionary<string, string> _comdic, string brand, string model) {
            Init(_lin, _comdic, brand, model);
        }

        protected override string GetMessage(string com, int line = 0) {
            StringBuilder comb = new StringBuilder();
            comb.Append(SYS_MARK_STR).Append(System.Environment.NewLine)
                .Append(USERVTY_STR).Append(System.Environment.NewLine)
                .Append(SCRLEN_STR).Append(' ').Append(line).Append(System.Environment.NewLine)
                .Append(com).Append(System.Environment.NewLine)
                .Append(Device.End).Append(Device.End);
            //lin.Send(SYS_MARK_STR);
            //lin.Read();
            //string r = lin.ToSuperUserInterface();
            //if (!r.TrimEnd().EndsWith(LEVEL3_MARK_STR))
            //    throw new Exception("Failed WaitFor: " + LEVEL3_MARK_STR);
            //lin.Send(USERVTY_STR);
            //lin.WaitFor(LEVEL3_MARK_STR);
            //lin.Send(SCRLEN_STR);
            //lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(comb.ToString());
            string message = lin.Read().TrimEnd();
            while (!message.Contains(Device.End)) {
                message += lin.Read().TrimEnd();
            }

            comb.Clear();
            comb.Append(UNDOSCRLEN_STR).Append(System.Environment.NewLine)
                .Append(QUIT_STR);
            lin.Send(comb.ToString());
            lin.ToUserInterface();

            Console.WriteLine(message);
            return message;

            //lin.Send(UNDOSCRLEN_STR);
            //lin.WaitFor(LEVEL3_MARK_STR);
            //lin.Send(QUIT_STR);
            //lin.WaitFor(LEVEL3_MARK_STR);
            //return message;
        }

        public override void SuperMe() {
            if (lin == null) return;
            //if(lin.ToUserInterface().Contains(LEVEL3_MARK_STR)) return;
            if (SuperPassWord == null || SuperPassWord.Length == 0) return;
            if (isSuper) return;

            lin.Send(SUPERPW_MARK_STR);
            string r = lin.Read();
            if (!r.TrimEnd().EndsWith(PASSWORD_MARK_STR))
                throw new Exception("Failed WaitFor: " + PASSWORD_MARK_STR);
            lin.Send(SuperPassWord);
            r = lin.Read();
            if (!r.TrimEnd().EndsWith(LEVEL1_MARK_STR)
                && !r.TrimEnd().EndsWith(LEVEL3_MARK_STR))
                throw new Exception("Failed WaitFor: LEVEL_MARK_STR");
            isSuper = true;
        }
        
        public override DeviceBaseInfo GetBaseInfo() {
            StreamReader txtreader = StaticFun.StrToStream(GetVersion());
            string txtline;
            string runtime = "uptime is ";
            string softw = "software, Version ";
            string model = null;

            while (!txtreader.EndOfStream) {
                txtline = txtreader.ReadLine();
                int flag = txtline.IndexOf(softw);
                if (flag > 0)
                    baseInfo.softver = txtline.Substring(flag + softw.Length);

                flag = txtline.IndexOf(runtime);
                if (flag > 0) {
                    model = txtline.Substring(0, flag - 1).Trim();
                    baseInfo.runtime = txtline.Substring(flag + runtime.Length);
                    break;
                }
            }
            while (!(txtline = txtreader.ReadLine()).Contains(LEVEL3_MARK_STR))
                baseInfo.other += txtline;
            
            string[] devarr = model.Split(' ');
            baseInfo.model = devarr[0] + ' ' + devarr[1];
            GetSoltInfo();
            return baseInfo;
        }
    }

    public class CiscoDevice : Device {
        public CiscoDevice(Linker _lin, Dictionary<string, string> _comdic = null){
            Init(_lin, _comdic, "Cisco", "BASE");
        }

        protected override string GetMessage(string com, int line = 0) {
            lin.Send(SYS_MARK_STR);
            lin.Read();
            string r = lin.ToUserInterface();
            if (!r.TrimEnd().EndsWith(LEVEL3_MARK_STR))
                throw new Exception("Failed WaitFor: " + LEVEL3_MARK_STR);
            lin.Send(CONFIGURATION_MODE_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(USERVTY_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(SCRLEN_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(QUIT_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(QUIT_STR);
            lin.WaitFor(LEVEL3_MARK_STR);


            lin.Send(com);
            string message = lin.Read().TrimEnd();

            while (!message.Contains(Device.End)) {
                message += lin.Read().TrimEnd();
            }

            lin.Send(CONFIGURATION_MODE_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(USERVTY_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(UNDOSCRLEN_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(QUIT_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(QUIT_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            return message;
        }

        public override DeviceBaseInfo GetBaseInfo() {
            string txt = GetVersion();
            Stream txtstr = new MemoryStream(ASCIIEncoding.Default.GetBytes(txt));
            StreamReader txtreader = new StreamReader(txtstr);
            string txtline;
            string runtime = "uptime is ";
            string softw = "software ";
            string model = null;

            while (!txtreader.EndOfStream) {
                txtline = txtreader.ReadLine();
                int flag = txtline.IndexOf(softw);
                if (flag > 0)
                    baseInfo.softver = txtline.Substring(flag + softw.Length).Trim();

                flag = txtline.IndexOf(runtime);
                if (flag > 0)
                    baseInfo.runtime = txtline.Substring(flag + runtime.Length).Trim();

                flag = txtline.IndexOf("processor");
                if (flag > 0) {
                    model = txtline.Substring(0, flag - 1).Trim();
                    break;
                }
            }
            string[] devarr = model.Split(' ');
            baseInfo.model = devarr[0] + ' ' + devarr[1];
            return baseInfo;
        }
    }
}
