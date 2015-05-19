using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoorManaging
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
            Application.ThreadExit += new EventHandler(Application_ThreadExit);
            HardDeviceManaging.Initial();
            Application.Run(new Forms.MainWithGrid());
        }

        static void Application_ThreadExit(object sender, EventArgs e)
        {
            HardDeviceManaging.PortClose();
        }
    }
}
