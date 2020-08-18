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
            /*
            if (user.User_type.Equals("Customer"))
                lblName.Text = user.name;
            else if (user.User_type.Equals("Employee"))
                lblName.Text = user.name;
                */

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
                lblName.Text = (string)dtblCustomer.Rows[0]["Name"];
                lblLocation.Text = (string)dtblCustomer.Rows[0]["Location"];
                lblPassword.Text = (string)dtblCustomer.Rows[0]["Password"];
            }
            else
            {
                lblName.Text = (string)dtblEmployee.Rows[0]["Name"];
                lblLocation.Text = (string)dtblEmployee.Rows[0]["Location"];
                lblPassword.Text = (string)dtblEmployee.Rows[0]["Password"];
            }
        }



        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void frmAccountInfo_Load(object sender, EventArgs e)
        {
            /*
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
                lblName.Text = (string)dtblCustomer.Rows[0]["Name"];
                lblLocation.Text = (string)dtblCustomer.Rows[0]["Location"];
                lblPassword.Text = (string)dtblCustomer.Rows[0]["Password"];
            }
            else
            {
                lblName.Text = (string)dtblEmployee.Rows[0]["Name"];
                lblLocation.Text = (string)dtblEmployee.Rows[0]["Location"];
                lblPassword.Text = (string)dtblEmployee.Rows[0]["Password"];
            }

            if (user.User_type.Equals("Customer"))
            {
                sdaCustomer.Fill(dtblCustomer);
                if(dtblCustomer.Rows.Count == 1)
                {
                    lblName.Text = (string)dtblCustomer.Rows[0]["Name"];
                    lblLocation.Text = (string)dtblCustomer.Rows[0]["Location"];
                    lblPassword.Text = (string)dtblCustomer.Rows[0]["Password"];
                }
            }
            else
            {
                sdaEmployee.Fill(dtblEmployee);
                if(dtblEmployee.Rows.Count == 1)
                {
                    lblName.Text = (string)dtblEmployee.Rows[0]["Name"];
                    lblLocation.Text = (string)dtblEmployee.Rows[0]["Location"];
                    lblPassword.Text = (string)dtblEmployee.Rows[0]["Password"];
                }
            }
            */


        }
    }
}
