using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4G记录仪北斗平台位置推送
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
            //Application.Run(new frmMain());
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(2000);
            th.Abort();
            //Thread.Sleep(1000);
            Application.Run(new frmMain());
        }






        private static void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
        }
    }
}
