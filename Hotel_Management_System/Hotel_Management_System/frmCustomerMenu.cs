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
            Hotel_Management_System.Display_Logs dl = new Hotel_Management_System.Display_Logs();
            this.Hide();
            dl.Show();
        }
    }
}
