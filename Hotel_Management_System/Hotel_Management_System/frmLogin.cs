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
using Hotel_Management_System;

namespace AccountManagementInterface
{
    public partial class frmLogin : Form
    {
        private User person = new User();
        public frmLogin()
        {
            InitializeComponent();
        }
        

            private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string queryCustomer = "Select * from Customer Where name = '" + tboxUsername.Text.Trim() + "' and Password = '" + tboxPassword.Text.Trim() + "'";
            string queryEmployee = "Select * from Employee Where name = '" + tboxUsername.Text.Trim() + "' and Password = '" + tboxPassword.Text.Trim() + "'";
            string customerInfo = "SELECT * Name from Customer";
            string employeeInfo = "select * Name from Employee";
            SqlDataAdapter sdaCustomer = new SqlDataAdapter(queryCustomer, sqlcon);
            SqlDataAdapter sdaEmployee = new SqlDataAdapter(queryEmployee, sqlcon);
            DataTable dtblCustomer = new DataTable();
            DataTable dtblEmployee = new DataTable();
            SqlDataReader rdr;
            
            if (rdiobtnCustomer.Checked){ //if user checked customer box
                sdaCustomer.Fill(dtblCustomer);

                if (dtblCustomer.Rows.Count == 1) // search in customer table, return == 1 if account exists
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(customerInfo);
                    cmd.Connection = sqlcon;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        person.name = rdr["Name"].ToString();
                    }
                    person.User_type = "Customer";

                    frmCustomerMenu objFrmCustomerMenu = new frmCustomerMenu(person);
                    this.Hide();
                    objFrmCustomerMenu.Show();

                }
                else
                {
                    MessageBox.Show("Your Username or password is incorrect.");
                }
            }
            else if(rdiobtnEmployee.Checked) { // if user checked employee box
                sdaEmployee.Fill(dtblEmployee);

                if (dtblEmployee.Rows.Count == 1) // search in employee table
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(employeeInfo, sqlcon);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = customerInfo;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        person.name = rdr["name"].ToString();
                    }
                    person.User_type = "Employee";


                    frmEmployeeMenu objFrmEmployeeMenu = new frmEmployeeMenu();
                    this.Hide();
                    objFrmEmployeeMenu.Show();

                }
                else // user did not check any box
                {
                    MessageBox.Show("Your Username or password is incorrect.");
                }
            }
            else // bad credentials
            {
                MessageBox.Show("Please check either the employee or customer checkbox.");
            }
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            frmCreateAccount objFrmCreateAccount = new frmCreateAccount();
            this.Hide();
            objFrmCreateAccount.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
