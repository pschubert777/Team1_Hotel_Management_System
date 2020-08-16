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
    public partial class frmCustomerMenu : Form
    {
        private User user;
        public frmCustomerMenu()
        {
            InitializeComponent();
        }
        public frmCustomerMenu(User u)
        {
            InitializeComponent();
            user = u;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin objFrmLogin = new frmLogin();
            this.Hide();
            objFrmLogin.Show();
        }


        private void btnActivityLog_Click_1(object sender, EventArgs e)
        {
            Hotel_Management_System.Display_Logs dl = new Hotel_Management_System.Display_Logs(user);
            this.Hide();
            dl.Show();
        }

        private void btnAccountInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
