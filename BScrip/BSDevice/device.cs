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

    public class DeviceBaseInfo {
        public string brand;
        public string devicetype;
        public string model;
        public string softver;
        public string runtime;
    }

    public abstract class Device {
        //public DeviceType TYPE;
        //public string VERSION;//型号
        //public BrandType BRAND;
        public Dictionary<string, string> comdic = new Dictionary<string, string>();
        protected Linker lin = null;
        public string SuperPassWord = null;
        protected bool isSuper = false;
        public DeviceBaseInfo baseInfo;

        public string CONFIGURATION_STR {
            get { return comdic["CONFIGURATION_STR"]; }
        }
        public string USERVTY_STR {
            get { return comdic["USERVTY_STR"]; }
        }
        public string SCRLEN0_STR {
            get { return comdic["SCRLEN0_STR"]; }
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

        public static Device DeviceFactory(Linker lin) {
            if (lin.Connect().Contains("User Access Verification"))
                return new CiscoSwitch(lin);
            return new HuaweiDevice(lin);
        }
        
        public virtual Device ClassFactory() { return null; }
        public virtual void SuperMe() { }        
        public abstract string GetConfiguration();
        protected abstract string GetMessage(string com);
        public abstract string GetVersion();

        public virtual void Close() {
            lin.Close();
            lin = null;
        }
    }

    public class HuaweiDevice : Device {
        public HuaweiDevice(Linker _lin) {
            base.lin = _lin;
            baseInfo.brand = "HUAWEI";
            baseInfo.model = "BASE";
            string classname = null;
            StaticFun.GetCommandDicAndClassName(baseInfo.brand, baseInfo.model
                , ref comdic, ref classname);
        }

        protected override string GetMessage(string com) {
            lin.Send(SYS_MARK_STR);
            lin.Read();
            string r = lin.ToSuperUserInterface();
            if (!r.TrimEnd().EndsWith(LEVEL3_MARK_STR))
                throw new Exception("Failed WaitFor: " + LEVEL3_MARK_STR);
            lin.Send(USERVTY_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(SCRLEN0_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(com);
            string message = lin.Read().TrimEnd();

            while (!message.Contains(CONFIGEND_MARK_STR)) {
                message += lin.Read().TrimEnd();
            }

            lin.Send(UNDOSCRLEN_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(QUIT_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            return message;
        }

        public override string GetConfiguration() {
            return GetMessage(CONFIGURATION_STR);
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

        public override string GetVersion() {
            return GetMessage(VERSION_STR);
        }
    }

    public class CiscoSwitch : Device {
        public CiscoSwitch(Linker _lin) {
            DataTable comtab = DBhelper.ExecuteDataTable(
                "select key,value from devicecommand where devicetype="
                + (int)(DeviceType.Switch) + " and brandtype="
                + (int)(Brand.Cisco), null);
            foreach (DataRow row in comtab.Rows) {
                comdic.Add(row["key"].ToString(), row["value"].ToString());
            }

            base.lin = _lin;
        }

        public override string GetConfiguration() {
            lin.Send(SYS_MARK_STR);
            lin.Read();
            string r = lin.ToUserInterface();
            if (!r.TrimEnd().EndsWith(LEVEL3_MARK_STR))
                throw new Exception("Failed WaitFor: " + LEVEL3_MARK_STR);
            lin.Send(CONFIGURATION_MODE_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(USERVTY_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(SCRLEN0_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(QUIT_STR);
            lin.WaitFor(LEVEL3_MARK_STR);
            lin.Send(QUIT_STR);
            lin.WaitFor(LEVEL3_MARK_STR);


            lin.Send(CONFIGURATION_STR);
            string sessionLog = lin.Read().TrimEnd();

            while (!sessionLog.Contains(CONFIGEND_MARK_STR)) {
                sessionLog += lin.Read().TrimEnd();
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
            return sessionLog;
        }

        protected override string GetMessage(string com) {
            throw new NotImplementedException();
        }

        public override string GetVersion() {
            throw new NotImplementedException();
        }
    }

}
