using AccountManagementInterface;
using System;
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

            Config config = new Config();
            config.readHotel();
            config.readPromotions();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //comment out below lines to prevent a certain page from opening
            //Application.Run(new Metrics_Page());
            //reservation page will open after the metrics page closes
            //ThirdPartyFile x = new ThirdPartyFile();
            //x.read_in_data();

            //Application.Run(new Metrics_Page());
            //Application.Run(new reservation_page());
            //Application.Run(new Display_Logs());
            //Application.Run(new reservation_page());
            Application.Run(new frmLogin());
        }
    }
}
