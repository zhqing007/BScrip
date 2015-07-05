﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Runtime.Serialization;
using BScripServiceLibrary.BSDevice;

namespace BScripServiceLibrary {
    public static class DBhelper {
        private static SQLiteConnection sqlconn;
        private static SQLiteCommand sqlcmd;

        static DBhelper() {
            sqlconn = new SQLiteConnection("Data Source=E:\\MYCPP\\BScrip\\BScripServiceLibrary\\BScripServer.db;Password=zhqing");
            sqlconn.Open();
            sqlcmd = sqlconn.CreateCommand();
        }

        private static object GetConfiguration(string key) {
            DataTable data = ExecuteDataTable(
                "select value from configuration where key='" + key + "'", null);
            if (data.Rows.Count == 0) return null;
            return data.Rows[0][0];
        }

        private static void SetConfiguration(string key, string value) {
            ExecuteSQL("update configuration set value='" +
                value + "' where key='" + key + "'");
        }

        public static void SaveCpuMemOccupy(Host h, List<ResourcesUtilization> cpuo, List<ResourcesUtilization> memo) {

            DateTime now = DateTime.Now;
            for (int i = 0; i < cpuo.Count; ++i) {
                SQLiteParameter[] p = {new SQLiteParameter("@hn", h.hostname)
                                     , new SQLiteParameter("@sn", cpuo[i].slotname)
                                     , new SQLiteParameter("@cpu", cpuo[i].s5)
                                     , new SQLiteParameter("@mem", memo[i].max)
                                     , new SQLiteParameter("@tt", "m")
                                     , new SQLiteParameter("@st", now.ToString("yyyy-MM-dd HH:mm:ss"))};
                DBhelper.ExecuteSQL("insert into resourceoccupy " + 
                    "(hostname, slotname, cpu, mem, timetype, savetime)" +
                    "values (@hn, @sn, @cpu, @mem, @tt, @st)", p);
            }

            LevelUpOccupy(h.hostname, cpuo, now, false);
            LevelUpOccupy(h.hostname, cpuo, now, true);            
        }

        private static void LevelUpOccupy(string hn, List<ResourcesUtilization> cpuo, DateTime now, bool today) {
            DateTime qt = new DateTime(now.Year, now.Month, now.Day, now.Hour, 0, 0);

            SQLiteParameter[] p1 = new SQLiteParameter[3];
            p1[0].ParameterName = "@hn";
            p1[0].Value = hn;
            p1[1].ParameterName = "@st";
            p1[1].Value = qt.ToString("yyyy-MM-dd HH:mm:ss");
            string timetype = today ? "h" : "m";

            foreach (ResourcesUtilization ru in cpuo) {
                p1[0].ParameterName = "@sl";
                p1[0].Value = ru.slotname;
                DataTable reso = DBhelper.ExecuteDataTable("select * from resourceoccupy where hostname=@hn " +
                    "and slotname=@sl and timetype ='" + timetype + "' and savetime<@st", p1);
                if (reso.Rows.Count == 0) continue;
                int cpuoccupy = 0, memoccupy = 0;
                foreach (DataRow row in reso.Rows) {
                    cpuoccupy += Int32.Parse(row["cpu"].ToString());
                    memoccupy += Int32.Parse(row["mem"].ToString());
                }

                DBhelper.ExecuteSQL("delete from resourceoccupy where hostname=@hn " +
                    "and slotname=@sl and timetype ='" + timetype + "' and savetime<@st", p1);

                SQLiteParameter[] p2 = {new SQLiteParameter("@hn", hn)
                                      , new SQLiteParameter("@sn", ru.slotname)
                                      , new SQLiteParameter("@cpu", cpuoccupy / reso.Rows.Count)
                                      , new SQLiteParameter("@mem", memoccupy / reso.Rows.Count)
                                      , new SQLiteParameter("@tt", today ? "d" : "h")
                                      , new SQLiteParameter("@st", now.ToString("yyyy-MM-dd HH:mm:ss"))};
                DBhelper.ExecuteSQL("insert into resourceoccupy " +
                    "(hostname, slotname, cpu, mem, timetype, savetime)" +
                    "values (@hn, @sn, @cpu, @mem, @tt, @st)", p2);
            }
        }

        public static void SaveDeviceConfiguration(Host h, string conf) {
            SQLiteParameter[] p = {new SQLiteParameter("@hn", h.hostname)
                                      , new SQLiteParameter("@st", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                                      , new SQLiteParameter("@co", conf)};
            DBhelper.ExecuteSQL("insert into deviceconfiguration (hostname, savetime, configuration) values (@hn, @st, @co)", p);
        }

        public static DataTable GetDeviceConfTime(string hostname, DateTime begin, DateTime end) {
            SQLiteParameter[] p = {new SQLiteParameter("@hn", hostname)
                                      , new SQLiteParameter("@begin", begin.ToString("yyyy-MM-dd HH:mm:ss"))
                                      , new SQLiteParameter("@end", end.ToString("yyyy-MM-dd HH:mm:ss"))};
            DataTable deconf = ExecuteDataTable(
                "select savetime from deviceconfiguration where hostname=@hn and savetime>=@begin and savetime<=@end"
                , p);
            return deconf;
        }

        public static string GetDeviceConfiguration(string hostname, DateTime save) {
            SQLiteParameter[] p = {new SQLiteParameter("@hn", hostname)
                                      , new SQLiteParameter("@save", save.ToString("yyyy-MM-dd HH:mm:ss"))};
            DataTable deconf = ExecuteDataTable(
                "select configuration from deviceconfiguration where hostname=@hn and savetime=@save"
                , p);
            if (deconf.Rows.Count <= 0) return null;
            return deconf.Rows[0][0].ToString();
        }

        public static int GetDeviceBackUpCount(string hostname, DateTime begin, DateTime end) {
            SQLiteParameter[] p = {new SQLiteParameter("@hn", hostname)
                                      , new SQLiteParameter("@begin", begin.ToString("yyyy-MM-dd HH:mm:ss"))
                                      , new SQLiteParameter("@end", end.ToString("yyyy-MM-dd HH:mm:ss"))};
            DataTable deconf = ExecuteDataTable(
                @"select count(*) as cou from deviceconfiguration where hostname=@hn 
                    and savetime>=@begin and savetime<=@end", p);
            return Int32.Parse(deconf.Rows[0][0].ToString());
        }

        public static Host GetDefaultUpLoadServer() {
            //string hostName = GetConfiguration("default_upload_server") as string;
            //if(hostName == null) return null;
            //Host rh = new Host(hostName);
            //rh.GetFromName();
            //return  rh;

            return null;
        }

        public static void SetDefaultUpLoadServer(string ser) {
            SetConfiguration("default_upload_server", ser);
        }

        public static void ExecuteSQL(string sql) {
            sqlcmd.CommandText = sql;
            sqlcmd.ExecuteNonQuery();
        }

        public static void ExecuteSQL(string sql, SQLiteParameter[] parameters) {
            sqlcmd.CommandText = sql;
            if (parameters != null) {
                sqlcmd.Parameters.AddRange(parameters);
            }
            sqlcmd.ExecuteNonQuery();
        }

        public static SQLiteDataReader ExecuteReader(string sql, SQLiteParameter[] parameters) {
            sqlcmd.CommandText = sql;
            if (parameters != null) {
                sqlcmd.Parameters.AddRange(parameters);
            }
            return sqlcmd.ExecuteReader();
        }

        public static DataTable ExecuteDataTable(string sql, SQLiteParameter[] parameters) {
            sqlcmd.CommandText = sql;
            if (parameters != null) {
                sqlcmd.Parameters.AddRange(parameters);
            }
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlcmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
    }

    [DataContract]
    public class Host {
        private string _ipaddress;
        private string _hostname;
        private string _loginname;
        private int _loginmode;
        private string _password;
        private string _superpw;
        private int _type = 0;
        private long _tspan = 0;
        private long _monitor = 0;
        private int _userid;

        public Host(int userid, string name) {
            hostname = name;
            _userid = userid;
        }

        private Host() {}

        [DataMember]
        public int userid {
            get { return _userid; }
            set { _userid = value; }
        }

        [DataMember]
        public string ipaddress {
            get { return _ipaddress; }
            set { _ipaddress = value; }
        }

        [DataMember]
        public string hostname {
            get { return _hostname; }
            set { _hostname = value; }
        }

        [DataMember]
        public string loginname {
            get { return _loginname; }
            set { _loginname = value; }
        }

        [DataMember]
        public int loginmode {
            get { return _loginmode; }
            set { _loginmode = value; }
        }

        [DataMember]
        public string password {
            get { return _password; }
            set { _password = value; }
        }

        [DataMember]
        public string superpw {
            get { return _superpw; }
            set { _superpw = value; }
        }

        [DataMember]
        public int type {
            get { return _type; }
            set { _type = value; }
        }

        [DataMember]
        public long tspan {
            get { return _tspan; }
            set { _tspan = value; }
        }

        [DataMember]
        public long monitor {
            get { return _monitor; }
            set { _monitor = value; }
        }

        private static List<Host> GetHostsFromSQL(string sql) {
            DataTable data = DBhelper.ExecuteDataTable(sql, null);
            List<Host> hosts = new List<Host>();
            foreach (DataRow row in data.Rows) {
                Host h = new Host();
                h.userid = Int32.Parse(row["userid"].ToString());
                h.hostname = row["name"].ToString();
                h.ipaddress = row["ipaddress"].ToString();
                h.loginname = row["loginname"].ToString();
                h.loginmode = Int32.Parse(row["loginmode"].ToString());
                h.password = row["password"].ToString();
                h.superpw = row["superpw"] as String;
                h.tspan = Int64.Parse(row["timespan"].ToString());
                h.monitor = Int64.Parse(row["monitor"].ToString());
                hosts.Add(h);
            }
            return hosts;
        }

        //type: 0为交换机，1为服务器
        public static List<Host> GetAllHosts(int userid, int type) {
            return GetHostsFromSQL("select * from hosts where userid=" + userid + " and type="
                + type + " order by name");
        }

        public static List<Host> GetTimeHosts() {
            return GetHostsFromSQL("select * from hosts where timespan!=0");
        }

        public static List<Host> GetCpuMemHosts() {
            return GetHostsFromSQL("select * from hosts where monitor!=0");
        }

        public static List<Host> GetAllHosts(int userid) {
            return GetAllHosts(userid, 0);
        }

        public static List<Host> GetAllServer(int userid) {
            return GetAllHosts(userid, 1);
        }

        public bool GetFromName() {
            if (hostname == null || hostname.Trim().Length == 0) return false;
            List<Host> hosts = GetHostsFromSQL("select * from hosts where userid=" + userid + " and name='" + hostname +
                "' and type=0");
            if (hosts.Count == 0) return false;

            ipaddress = hosts[0].ipaddress;
            loginname = hosts[0].loginname;
            loginmode = hosts[0].loginmode;
            password = hosts[0].password;
            superpw = hosts[0].superpw;
            tspan = hosts[0].tspan;
            return true;
        }

        public bool Exist() {
            if (hostname == null || hostname.Trim().Length == 0) return false;
            DataTable data = DBhelper.ExecuteDataTable("select * from hosts where name='" + hostname +
                "' and type=" + type , null);
            if (data.Rows.Count == 0) return false;
            return true;
        }

        //loginmode: 0为telnet, 1为SSH2
        public bool Save() {
            if (hostname == null || hostname.Trim().Length == 0) return false;
            if (Exist()) return false;

            SQLiteParameter[] p = {new SQLiteParameter("@uid", userid)
                                      , new SQLiteParameter("@ip", ipaddress)
                                      , new SQLiteParameter("@hn", hostname)
                                      , new SQLiteParameter("@ln", loginname)
                                      , new SQLiteParameter("@mode", loginmode)
                                      , new SQLiteParameter("@pw", password)
                                      , new SQLiteParameter("@spw", superpw)
                                      , new SQLiteParameter("@type", type)
                                      , new SQLiteParameter("@tspan", tspan)};

            DBhelper.ExecuteSQL("insert into hosts" +
                        "(userid, ipaddress, name, loginname, loginmode, password, superpw, type, timespan) " +
                        "values(@uid, @ip, @hn, @ln, @mode, @pw, @spw, @type, @tspan)", p);
            return true;
        }

        public bool Update() {
            if (hostname == null || hostname.Trim().Length == 0) return false;
            if (!Exist()) return false;

            SQLiteParameter[] p = {new SQLiteParameter("@uid", userid)
                                      , new SQLiteParameter("@ip", ipaddress)
                                      , new SQLiteParameter("@hn", hostname)
                                      , new SQLiteParameter("@ln", loginname)
                                      , new SQLiteParameter("@mode", loginmode)
                                      , new SQLiteParameter("@pw", password)
                                      , new SQLiteParameter("@spw", superpw)
                                      , new SQLiteParameter("@type", type)
                                      , new SQLiteParameter("@tspan", tspan)};

            DBhelper.ExecuteSQL("update hosts " +
                        "set ipaddress=@ip, loginname=@ln, loginmode=@mode, password=@pw, " +
                        "superpw=@spw, type=@type, timespan=@tspan where name=@hn and userid=@uid", p);
            return true;
        }

        public void Del() {
            if (hostname == null || hostname.Trim().Length == 0) return;
            DBhelper.ExecuteSQL("delete from hosts where name='" + hostname.Trim() + "' and type=0");
        }

        public override string ToString() {
            return this.hostname;
        }

        //public override bool Equals(object obj) {
        //    if (!(obj is Host)) return false;
        //    Host h = obj as Host;
        //    if (this.hostname == h.hostname
        //        && this.ipaddress == h.ipaddress
        //        && this.loginmode == h.loginmode
        //        && this.loginname == h.loginname
        //        && this.password == h.password
        //        && this.superpw == h.superpw)
        //    return true;
        //    return false;
        //}
    }
}
