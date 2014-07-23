﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MusicPlayer_1._0
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

            LoginForm fLogin = new LoginForm();
            Application.Run(fLogin);

            if (fLogin.isLoginSucessfull)
            {
                Application.Run(new frmMain());
            }
        }
    }
}
