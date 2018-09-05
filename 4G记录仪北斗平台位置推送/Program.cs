using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        /// 


        [DllImport("user32.dll")]
        private static extern bool FlashWindow(IntPtr hWnd, bool bInvert);
        [DllImport("user32.dll")]
        private static extern bool FlashWindowEx(int pfwi);

       


        [STAThread]
        static void Main()
        {


            bool runone;
            System.Threading.Mutex run = new System.Threading.Mutex(true, "single_test", out runone);

            if (runone)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmMain());
                Thread th = new Thread(new ThreadStart(DoSplash));
                th.Start();
                Thread.Sleep(2000);
                th.Abort();
                Thread.Sleep(500);
                Application.Run(new frmMain());
            }
            else
            {
                MessageBox.Show("该程序已经运行!", "已运行", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

           
        }






        private static void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
        }
    }
}
