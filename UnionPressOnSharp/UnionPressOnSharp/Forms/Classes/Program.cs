using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace UnionPressOnSharp
{
    static class Program
    {
        //static int timeOut = 0;
       // static System.Threading.Timer myTimer;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //myTimer = new System.Threading.Timer(CallBack, null, 0, 1000);
            //Properties.Settings.Default.AppsTime = myTimer.ToString();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          
            Application.Run(new MainForm());
        }
        static void CallBack(object state)
        {
           // timeOut++;
           
            //if (timeOut == 10)
            //{
            //    Process.Start("shutdown", "/s /t 0");
            //}
        }
    }
}
