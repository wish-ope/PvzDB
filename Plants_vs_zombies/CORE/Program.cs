﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PvZ
{
    static class Program
    {
        /// <summary>
        /// Điểm nhập chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _Form1());
        }
    }
}
