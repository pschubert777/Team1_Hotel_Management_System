﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
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
            //comment out below lines to prevent a certain page from opening
            //Application.Run(new Metrics_Page());
            //reservation page will open after the metrics page closes
            Application.Run(new reservation_page());
            //Application.Run(new check_in_out_page());
        }
    }
}
