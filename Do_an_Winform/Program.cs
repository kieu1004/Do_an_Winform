﻿using Do_an_Winform.PL.DangNhap;
using Do_an_Winform.PL.Nhanvien;
using Do_an_Winform.PL.Quanly;
using Do_an_Winform.PL.Quanly.QLBC;
using Do_an_Winform.PL.Quanly.QLSP;
using Do_an_Winform.PL.Quanly.QLTQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Loading());
        }
    }
}
