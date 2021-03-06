﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
//using System.Windows.Forms;
using System.IO;
using BScripServiceLibrary.BSDevice;

namespace BScripServiceLibrary.BSThread {
    public class ConfThread {
        private List<Host> hosts;
        private Host server;
        private List<string> filenames = new List<string>();

        public ConfThread(List<Host> hostl, Host _server = null) {
            server = _server;
            hosts = hostl;
        }

        //private void StaticFun.AddLog(Host item, string str) {
        //    StringBuilder strb = new StringBuilder();
        //    if (item == null)
        //        strb.Append(str).Append(System.Environment.NewLine);
        //    else {
        //        strb.Append(DateTime.Now.GetDateTimeFormats('g')[0].ToString());
        //        if (item != null)
        //            strb.Append('：').Append(item.hostname).Append("--");
        //        strb.Append(str).Append(System.Environment.NewLine);
        //    }
        //    tbox.AppendText(strb.ToString());
        //}

        public static HostConfigStruct SaveHostConf(Host item) {
            Device dev = null;
            try {
                if (item.loginmode == 0) {
                    dev = Device.DeviceFactory(new TelnetLinker(item.ipaddress, item.loginname, item.password)
                        , item.superpw);
                    StaticFun.AddLog(item, "Telnet登录");
                }
                else {
                    dev = Device.DeviceFactory(new SSH2Linker(item.ipaddress, item.loginname, item.password)
                        , item.superpw);
                    StaticFun.AddLog(item, "SSH2登录");
                }

                HostConfigStruct hc = new HostConfigStruct();
                hc.device = item;
                hc.config = dev.GetConfiguration();
                if (hc.config != null && hc.config.Trim().Length > 0) {
                    StaticFun.AddLog(item, "导出配置成功");
                    DBhelper.SaveDeviceConfiguration(item, hc.config);
                }
                else
                    StaticFun.AddLog(item, "导出配置失败");
                dev.Close();
                return hc;
            }
            catch (Exception exc) {
                StaticFun.AddLog(item, "导出配置出现异常：" + exc.StackTrace);
                return null;
            }                
        }

        public void GetConfNoThread() {
            List<HostConfigStruct> hcList = new List<HostConfigStruct>();
            foreach (Host item in hosts) {
                HostConfigStruct hc = SaveHostConf(item);
                if (server != null && hc != null)
                    hcList.Add(hc);
            }
            if (hcList.Count == 0) return;
            UploadToServer(server, hcList);
        }

        public class HostConfigStruct {
            public Host device;
            public string config;
            public string filename;
        }

        public static bool UploadAConfigToServer(Host server, HostConfigStruct config) {
            List<HostConfigStruct> configlist = new List<HostConfigStruct>();
            configlist.Add(config);

            return UploadToServer(server, configlist);
        }

        public static bool UploadToServer(Host server, List<HostConfigStruct> configlist) {
            List<string> filenames = new List<string>();
            try {
                foreach (HostConfigStruct con in configlist) {
                    StringBuilder fileN = new StringBuilder(con.device.hostname);
                    fileN.Append('_').Append(con.device.ipaddress.Replace('.', '_'));
                    StringBuilder filePath = new StringBuilder("/");
                    filePath.Append(fileN.ToString());
                    if (!Directory.Exists(fileN.ToString())) 
                        Directory.CreateDirectory(fileN.ToString());
                    fileN = new StringBuilder(Path.GetFullPath(fileN.ToString()));
                    if(con.filename == null)
                        con.filename = DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";
                    fileN.Append('\\').Append(con.filename);
                    filePath.Append('/').Append(con.filename);
                    filenames.Add(filePath.ToString());

                    StreamWriter sw = File.CreateText(fileN.ToString());
                    StaticFun.AddLog(con.device, "写入文件 " + fileN);
                    sw.Write(con.config);
                    sw.Close();
                    StaticFun.AddLog(con.device, "文件写入完成");
                }
                SshFileTransfer.PutFileListSFTP(server, filenames);
                StaticFun.AddLog(server, "上传文件完成");
                foreach (string file in filenames) {
                    File.Delete(file.Substring(1));
                }
                StaticFun.AddLog(server, "本地文件已删除");
                return true;
            }
            catch (Exception ex) {
                Console.Write(ex.StackTrace);
                StaticFun.AddLog(server, "上传文件失败");
                return false;
            }
        }

        //public void GetConfInThread() {
        //    //myResetEvent.WaitOne();
        //    GetConfNoThread();
        //    //logF.ReDoButtons(true);
        //}
    }
}
