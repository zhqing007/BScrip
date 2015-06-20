using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            BSForms.BScripMDIParent.onlyOneMDI = new BSForms.BScripMDIParent();
            Application.Run(BSForms.BScripMDIParent.onlyOneMDI);

            //Application.Run(new BScrip.BSForms.FiveLittle());
        }
    }
}
