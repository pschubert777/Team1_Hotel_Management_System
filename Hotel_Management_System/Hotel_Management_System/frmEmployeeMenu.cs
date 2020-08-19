using Hotel_Management_System;
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

        private User user;
        public frmEmployeeMenu()
        {
            InitializeComponent();
        }
        public frmEmployeeMenu(User u)
        {
            InitializeComponent();
            user = u;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin objFrmLogin = new frmLogin();
            this.Hide();
            objFrmLogin.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnManageCustomerAccount_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.frmManageCustomerAccount objManageCustomerAccount = new Hotel_Management_System.frmManageCustomerAccount(user);
            this.Hide();
            objManageCustomerAccount.Show();
        }

        private void btnManageEmployeeAccount_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.frmManageEmployeeAccount objManageEmployeeAccount = new Hotel_Management_System.frmManageEmployeeAccount(user);
            this.Hide();
            objManageEmployeeAccount.Show();
        }

        private void btnMetricsPage_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.Metrics_Page objMetrics_Page = new Hotel_Management_System.Metrics_Page(user);
            this.Hide();
            objMetrics_Page.Show();
        }

        private void btnManageReservation_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.reservation_page objReservation_Page = new Hotel_Management_System.reservation_page(user);
            this.Hide();
            objReservation_Page.Show();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.room_management_page objRoom_management_page = new Hotel_Management_System.room_management_page(user);
            this.Hide();
            objRoom_management_page.Show();
        }



        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            Display_Logs dl = new Display_Logs(user);
            this.Hide();
            dl.Show();
        }

        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            frmAccountInfo objAccountInfo = new frmAccountInfo(user);
            this.Hide();
            objAccountInfo.Show();
        }

        private void btnCheckinOut_Click(object sender, EventArgs e)
        {
            check_in_out_page objCheckInOut = new check_in_out_page(user);
            this.Hide();
            objCheckInOut.Show();
        }
    }
}
