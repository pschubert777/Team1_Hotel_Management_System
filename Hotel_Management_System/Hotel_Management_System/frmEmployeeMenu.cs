using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManagementInterface
{
    public partial class frmEmployeeMenu : Form
    {
        public frmEmployeeMenu()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.Display_Logs objDisplay_Logs = new Hotel_Management_System.Display_Logs();
            this.Hide();
            objDisplay_Logs.Show();
        }

        private void btnMetricsPage_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.Metrics_Page objMetrics_Page = new Hotel_Management_System.Metrics_Page();
            this.Hide();
            objMetrics_Page.Show();
        }

        private void btnManageReservation_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.reservation_page objreservation_page = new Hotel_Management_System.reservation_page();
            this.Hide();
            objreservation_page.Show();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.room_management_page objroom_management_page = new Hotel_Management_System.room_management_page();
            this.Hide();
            objroom_management_page.Show();
        }

        private void btnManageCustomerAccount_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.frmManageCustomerAccount objfrmManageCustomerAccount = new Hotel_Management_System.frmManageCustomerAccount();
            this.Hide();
            objfrmManageCustomerAccount.Show();
        }

        private void btnManageEmployeeAccount_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.frmManageEmployeeAccount objfrmManageEmployeeAccount = new Hotel_Management_System.frmManageEmployeeAccount();
            this.Hide();
            objfrmManageEmployeeAccount.Show();
        }
    }
}
