using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAnMon_QuanLyBanHang
{
    static class Program
    {
        public static frmMain mainForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new frmDangNhap());
        }
    }
}
