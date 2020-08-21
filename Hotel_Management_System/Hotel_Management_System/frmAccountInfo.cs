using System;
using Hotel_Management_System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AccountManagementInterface;

namespace Hotel_Management_System
{
    public partial class frmAccountInfo : Form
    {

        private User user;
        public frmAccountInfo()
        {
            InitializeComponent();
            
        }
        public frmAccountInfo(User u)
        {
            InitializeComponent();
            user = u;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string queryCustomer = "Select * from Customer Where name = '" + user.name + "'";
            string queryEmployee = "Select * from Employee Where name = '" + user.name + "'";
            SqlDataAdapter sdaCustomer = new SqlDataAdapter(queryCustomer, sqlcon);
            SqlDataAdapter sdaEmployee = new SqlDataAdapter(queryEmployee, sqlcon);
            DataTable dtblCustomer = new DataTable();
            DataTable dtblEmployee = new DataTable();



            //get user credentials here
            if (user.User_type.Equals("Customer"))
            {
                sdaCustomer.Fill(dtblCustomer);
                if (dtblCustomer.Rows.Count == 1)
                {
                    lblID.Text = user.id.ToString();
                    lblName.Text = user.name;
                    lblLocation.Text = (string)dtblCustomer.Rows[0]["Location"];
                    lblPassword.Text = (string)dtblCustomer.Rows[0]["Password"];
                    lblRewards.Text = (string)dtblCustomer.Rows[0]["Reward_points"].ToString();
                }
            }
            else
            {
                sdaEmployee.Fill(dtblEmployee);
                if (dtblEmployee.Rows.Count == 1)
                {
                    lblID.Text = user.id.ToString();
                    lblName.Text = user.name;
                    lblLocation.Text = (string)dtblEmployee.Rows[0]["Location"];
                    lblPassword.Text = (string)dtblEmployee.Rows[0]["Password"];
                }
            }
        }



        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void frmAccountInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(user.User_type.Equals("Customer"))
            {
                frmCustomerMenu objFrmCustomerMenu = new frmCustomerMenu(user);
                this.Hide();
                objFrmCustomerMenu.Show();
            }
            else
            {
                frmEmployeeMenu objFrmEmployeeMenu = new frmEmployeeMenu(user);
                this.Hide();
                objFrmEmployeeMenu.Show();
            }
        }
    }
}
