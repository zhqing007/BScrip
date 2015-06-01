using System;
using System.Collections;

namespace BScripServiceLibrary
{
	/// <summary>
	/// Summary description for Util.
	/// </summary>
	public class Util
	{
		/// <summary>
		/// Get input from the user
		/// </summary>
		public static SshConnectionInfo GetLoginInfo(Host server)
		{
			SshConnectionInfo info = new SshConnectionInfo();
            info.Host = server.ipaddress;
            info.User = server.loginname;

            //Console.Write("Use publickey authentication? [Yes|No] :");
            //string resp = Console.ReadLine();
            //if(resp.ToLower().StartsWith("y"))
            //{
            //    Console.Write("Enter identity key filename: ");
            info.IdentityFile = null;
            //}
            //else
            //{
            //    Console.Write("Enter Password: ");
            info.Pass = server.password;
            //}
            //Console.WriteLine();
			return info;
		}
	}

	public struct SshConnectionInfo
	{
		public string Host;
		public string User;
		public string Pass;
		public string IdentityFile;
	}
}
