using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BScrip.BSForms;

namespace BScrip
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WelcomeForm fw = new WelcomeForm();
            if (fw.ShowDialog() == DialogResult.Abort) return;
            BSForms.BScripMDIParent.onlyOneMDI = new BSForms.BScripMDIParent();
            Application.Run(BSForms.BScripMDIParent.onlyOneMDI);

            //Application.Run(new BScrip.BSForms.FiveLittle());
        }
    }
}
