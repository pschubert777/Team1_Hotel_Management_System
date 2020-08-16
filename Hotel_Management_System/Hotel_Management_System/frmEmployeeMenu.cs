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

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            Display_Logs dl = new Display_Logs(user);
            this.Hide();
            dl.Show();
        }
    }
}
