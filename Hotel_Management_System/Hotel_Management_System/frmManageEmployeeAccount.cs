using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class frmManageEmployeeAccount : Form
    {
        private User user;
        public frmManageEmployeeAccount()
        {
            InitializeComponent();
        }
        public frmManageEmployeeAccount(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "Select * from Employee Where id = '" + tboxCustomerID.Text.Trim() + "'";
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand();
            sqlcon.Open();
            cmd.Connection = sqlcon;
            cmd.CommandText = query;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["password"]);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AccountManagementInterface.frmEmployeeMenu objEmployeeMenu = new AccountManagementInterface.frmEmployeeMenu(user);
            this.Hide();
            objEmployeeMenu.Show();
        }

        private void tboxCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
