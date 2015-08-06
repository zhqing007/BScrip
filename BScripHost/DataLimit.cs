using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Management;

namespace BScripHost {
    public class Encryption {
        public static string EncryPW(string Pass, string Key) {
            return DesEncrypt(Pass, Key);
        }
        public static string DisEncryPW(string strPass, string Key) {
            return DesDecrypt(strPass, Key);
        }
        /////////////////////////////////////////////////////////////////////   

        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="encryptString"></param>
        /// <returns></returns>
        public static string DesEncrypt(string encryptString, string key) {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, 8));
            byte[] keyIV = keyBytes;
            byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, provider.CreateEncryptor(keyBytes, keyIV), CryptoStreamMode.Write);
            cStream.Write(inputByteArray, 0, inputByteArray.Length);
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.ToArray());
        }
        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="decryptString"></param>
        /// <returns></returns>
        public static string DesDecrypt(string decryptString, string key) {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, 8));
            byte[] keyIV = keyBytes;
            byte[] inputByteArray = Convert.FromBase64String(decryptString);
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, provider.CreateDecryptor(keyBytes, keyIV), CryptoStreamMode.Write);
            cStream.Write(inputByteArray, 0, inputByteArray.Length);
            cStream.FlushFinalBlock();
            return Encoding.UTF8.GetString(mStream.ToArray());
        }
        //////////////////////////////////////////////////////
    }

    class TimeClass {
        public static int InitRegedit() {
            /*检查注册表*/
            string SericalNumber = ReadSetting("", "SerialNumber", "-1");    // 读取注册表， 检查是否注册 -1为未注册
            if (SericalNumber == "-1") {
                return 1;
            }
            /* 比较CPUid */
            string CpuId = GetSoftEndDateAllCpuId(1, SericalNumber);   //从注册表读取CPUid
            string CpuIdThis = GetCpuId();           //获取本机CPUId         
            if (CpuId != CpuIdThis) {
                return 2;
            }
            /* 比较时间 */
            string NowDate = TimeClass.GetNowDate();
            string EndDate = TimeClass.GetSoftEndDateAllCpuId(0, SericalNumber);
            if (Convert.ToInt32(EndDate) - Convert.ToInt32(NowDate) < 0) {
                return 3;
            }
            return 0;
        }

        /*CPUid*/
        public static string GetCpuId() {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            string strCpuID = null;
            foreach (ManagementObject mo in moc) {
                strCpuID = mo.Properties["ProcessorId"].Value.ToString();
                break;
            }
            return strCpuID;
        }
        /*当前时间*/
        public static string GetNowDate() {
            string NowDate = DateTime.Now.ToString("yyyyMMdd"); //.Year + DateTime.Now.Month + DateTime.Now.Day).ToString();
                                                                //     DateTime date = Convert.ToDateTime(NowDate, "yyyy/MM/dd");
            return NowDate;
        }
        /* 生成序列号 */
        public static string CreatSerialNumber() {
            string SerialNumber = GetCpuId() + "-" + "20110915";
            return SerialNumber;
        }
        /* 
         * i=1 得到 CUP 的id 
         * i=0 得到上次或者 开始时间 
         */
        public static string GetSoftEndDateAllCpuId(int i, string SerialNumber) {
            if (i == 1) {
                string cupId = SerialNumber.Substring(0, SerialNumber.LastIndexOf("-")); // .LastIndexOf("-"));
                return cupId;
            }
            if (i == 0) {
                string dateTime = SerialNumber.Substring(SerialNumber.LastIndexOf("-") + 1);
                //  dateTime = dateTime.Insert(4, "/").Insert(7, "/");
                //  DateTime date = Convert.ToDateTime(dateTime);
                return dateTime;
            }
            else {
                return string.Empty;
            }
        }
        /*写入注册表*/
        public static void WriteSetting(string Section, string Key, string Setting)  // name = key  value=setting  Section= path
        {
            string text1 = Section;
            RegistryKey key1 = Registry.CurrentUser.CreateSubKey("Software\\MyTest_ChildPlat\\ChildPlat"); // .LocalMachine.CreateSubKey("Software\\mytest");
            if (key1 == null) {
                return;
            }
            try {
                key1.SetValue(Key, Setting);
            }
            catch (Exception exception1) {
                return;
            }
            finally {
                key1.Close();
            }
        }
        /*读取注册表*/
        public static string ReadSetting(string Section, string Key, string Default) {
            if (Default == null) {
                Default = "-1";
            }
            string text2 = Section;
            RegistryKey key1 = Registry.CurrentUser.OpenSubKey("Software\\MyTest_ChildPlat\\ChildPlat");
            if (key1 != null) {
                object obj1 = key1.GetValue(Key, Default);
                key1.Close();
                if (obj1 != null) {
                    if (!(obj1 is string)) {
                        return "-1";
                    }
                    string obj2 = obj1.ToString();
                    obj2 = Encryption.DisEncryPW(obj2, "ejiang11");
                    return obj2;
                }
                return "-1";
            }

            return Default;
        }
    }
}

//int res = TimeClass.InitRegedit();
//            if (res == 0)
//            {
//                Application.Run(new Form1());
//            }
//            else if(res == 1)
//            {
//                MessageBox.Show("软件尚未注册，请注册软件！");
//            }
//            else if (res == 2)
//            {
//                MessageBox.Show("注册机器与本机不一致,请联系管理员！");
//            }
//            else if (res == 3)
//            {
//                MessageBox.Show("软件试用已到期！");
//            }
//            else
//            {
//                MessageBox.Show("软件运行出错，请重新启动！");
//            }