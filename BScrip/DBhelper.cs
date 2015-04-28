using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace BScrip {
    public static class DBhelper {
        private static SQLiteConnection sqlconn;
        private static SQLiteCommand sqlcmd;

        static DBhelper() {
            sqlconn = new SQLiteConnection("Data Source=..\\..\\BScrip.db;Password=zhqing");
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


        public static void SaveDeviceConfiguration(Host h, string conf) {
            SQLiteParameter[] p = {new SQLiteParameter("@hn", h.hostname)
                                      , new SQLiteParameter("@st", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                                      , new SQLiteParameter("@co", conf)};
            DBhelper.ExecuteSQL("insert into deviceconfiguration (hostname, savetime, configuration) values (@hn, @st, @co)", p);
        }

        public static Host GetDefaultUpLoadServer() {
            string hostName = GetConfiguration("default_upload_server") as string;
            if(hostName == null) return null;
            Host rh = new Host(hostName);
            rh.GetFromName();
            return  rh;
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

    public class Host {
        public string ipaddress;
        public string hostname;
        public string loginname;
        public int loginmode;
        public string password;
        public string superpw;
        public int type = 0;

        public Host(string name) {
            hostname = name;
        }
        
        //type: 0为交换机，1为服务器
        public static List<Host> GetAllHosts(int type) {
            DataTable data = DBhelper.ExecuteDataTable("select * from hosts where type=" + type, null);
            List<Host> hosts = new List<Host>();
            foreach (DataRow row in data.Rows) {
                Host h = new Host(row["name"].ToString());
                h.ipaddress = row["ipaddress"].ToString();
                h.loginname = row["loginname"].ToString();
                h.loginmode = Int32.Parse(row["loginmode"].ToString());
                h.password = row["password"].ToString();
                h.superpw = row["superpw"] as String;

                hosts.Add(h);
            }
            return hosts;
        }
        
        public static List<Host> GetAllHosts() {
            return GetAllHosts(0);
        }

        public static List<Host> GetAllServer() {
            return GetAllHosts(1);
        }

        public bool GetFromName() {
            if (hostname == null || hostname.Trim().Length == 0) return false;
            DataTable data = DBhelper.ExecuteDataTable("select * from hosts where name='" + hostname + 
                "' and type=0", null);
            if (data.Rows.Count == 0) return false;

            ipaddress = data.Rows[0]["ipaddress"].ToString();
            loginname = data.Rows[0]["loginname"].ToString();
            loginmode = Int32.Parse(data.Rows[0]["loginmode"].ToString());
            password = data.Rows[0]["password"].ToString();
            superpw = data.Rows[0]["superpw"] as String;

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

            SQLiteParameter[] p = {new SQLiteParameter("@ip", ipaddress)
                                      , new SQLiteParameter("@hn", hostname)
                                      , new SQLiteParameter("@ln", loginname)
                                      , new SQLiteParameter("@mode", loginmode)
                                      , new SQLiteParameter("@pw", password)
                                      , new SQLiteParameter("@spw", superpw)
                                      , new SQLiteParameter("@type", type)};

            DBhelper.ExecuteSQL("insert into hosts" +
                        "(ipaddress, name, loginname, loginmode, password, superpw, type) " +
                        "values(@ip, @hn, @ln, @mode, @pw, @spw, @type)", p);
            return true;
        }

        public bool Update() {
            if (hostname == null || hostname.Trim().Length == 0) return false;
            if (!Exist()) return false;

            SQLiteParameter[] p = {new SQLiteParameter("@ip", ipaddress)
                                      , new SQLiteParameter("@hn", hostname)
                                      , new SQLiteParameter("@ln", loginname)
                                      , new SQLiteParameter("@mode", loginmode)
                                      , new SQLiteParameter("@pw", password)
                                      , new SQLiteParameter("@spw", superpw)
                                      , new SQLiteParameter("@type", type)};

            DBhelper.ExecuteSQL("update hosts " +
                        "set ipaddress=@ip, loginname=@ln, loginmode=@mode, password=@pw, " +
                        "superpw=@spw, type=@type where name=@hn", p);
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
