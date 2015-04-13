using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BScrip.BSDevice {
    public enum DeviceType {
        Switch = 10,
        Router = 20,
        FireWall = 30
    }

    public enum BrandType {
        Huawei = 10,
        H3C = 20,
        Cisco = 30
    }

    public class Device {
        //public DeviceType TYPE;
        //public string VERSION;//型号
        //public BrandType BRAND;
        protected Dictionary<string, string> comdic = new Dictionary<string, string>();

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

        public static Device DeviceFactory(string singal) {
            if(singal.Contains("User Access Verification"))
                return new CiscoSwitch();
            return new HuaweiSwitch();            
        }

    }

    public class HuaweiSwitch : Device {
        public HuaweiSwitch() {
            DataTable comtab = DBhelper.ExecuteDataTable(
                "select key,value from devicecommand where devicetype="
                + (int)(DeviceType.Switch) + " and brandtype="
                + (int)(BrandType.Huawei), null);
            foreach (DataRow row in comtab.Rows) {
                comdic.Add(row["key"].ToString(), row["value"].ToString());
            }
        }
    }

    public class CiscoSwitch : Device {
    }

}
