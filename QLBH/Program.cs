using DAL;
using QLBH.Pages.Goods;
using QLBH.Resources;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLBH
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
