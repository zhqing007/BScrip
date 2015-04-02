﻿using System;
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

        public Host(string name) {
            hostname = name;
        }
        
        public static List<Host> GetAllHosts() {
            DataTable data = DBhelper.ExecuteDataTable("select * from hosts", null);
            List<Host> hosts = new List<Host>();
            foreach (DataRow row in data.Rows) {
                Host h = new Host(row["name"].ToString());
                h.ipaddress = row["ipaddress"].ToString();
                h.loginname = row["loginname"].ToString();
                h.loginmode = Int32.Parse(row["loginmode"].ToString());
                h.password = row["password"].ToString();
                h.superpw = data.Rows[0]["superpw"] as String;

                hosts.Add(h);
            }
            return hosts;
        }

        public bool GetFromName() {
            if (hostname == null || hostname.Trim().Length == 0) return false;
            DataTable data = DBhelper.ExecuteDataTable("select * from hosts where name = '" + hostname + "'", null);
            if (data.Rows.Count == 0) return false;

            ipaddress = data.Rows[0]["ipaddress"].ToString();
            loginname = data.Rows[0]["loginname"].ToString();
            loginmode = Int32.Parse(data.Rows[0]["loginmode"].ToString());
            password = data.Rows[0]["password"].ToString();
            superpw = data.Rows[0]["superpw"] as String;

            return true;
        }

        public bool Save() {
            if (hostname == null || hostname.Trim().Length == 0) return false;
            if (GetFromName() == false) return false;

            SQLiteParameter[] p = {new SQLiteParameter("@ip", ipaddress),
                                      new SQLiteParameter("@hn", hostname),
                                      new SQLiteParameter("@ln", loginname),
                                      new SQLiteParameter("@mode", loginmode),
                                      new SQLiteParameter("@pw", password),
                                      new SQLiteParameter("@spw", superpw)};

            DBhelper.ExecuteSQL("insert into hosts" +
                        "(ipaddress, name, loginname, loginmode, password, superpw) " +
                        "values(@ip, @hn, @ln, @mode, @pw, @spw)", p);
            return true;
        }

        public bool Update() {
            if (hostname == null || hostname.Trim().Length == 0) return false;
            Host th = new Host(hostname);
            if (!th.GetFromName()) return false;

            SQLiteParameter[] p = {new SQLiteParameter("@ip", ipaddress),
                                      new SQLiteParameter("@hn", hostname),
                                      new SQLiteParameter("@ln", loginname),
                                      new SQLiteParameter("@mode", loginmode),
                                      new SQLiteParameter("@pw", password),
                                      new SQLiteParameter("@spw", superpw)};

            DBhelper.ExecuteSQL("update hosts " +
                        "set ipaddress=@ip, loginname=@ln, loginmode=@mode, password=@pw, " +
                        "superpw=@spw where name=@hn", p);
            return true;
        }

        public void Del() {
            if (hostname == null || hostname.Trim().Length == 0) return;
            DBhelper.ExecuteSQL("delete from hosts where name='" + hostname.Trim() + "'");
        }

        public override string ToString() {
            return this.hostname;
        }
    }
}