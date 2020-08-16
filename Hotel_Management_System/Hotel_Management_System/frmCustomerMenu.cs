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
    public partial class frmCustomerMenu : Form
    {
        public frmCustomerMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.reservation_page objFrmLogin = new Hotel_Management_System.reservation_page();
            this.Hide();
            objFrmLogin.Show();
        }

        private void btnTransactionAndReward_Click(object sender, EventArgs e)
        {

        }
    }
}
