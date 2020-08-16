﻿using System;
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
    public partial class frmCreateAccount : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (rdiobtnCustomer.Checked) // customer account creation
            {
                if (tboxPassword.Text != tboxConfirmPassword.Text) // password validation
                {
                    MessageBox.Show("Passwords do not match.");
                }
                else
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into customer (Name, Location, Password) values ('" + tboxUsername.Text + "', '" + tboxLocation.Text + "', '" + tboxPassword.Text + "')";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT TOP 1 * FROM Customer ORDER BY ID DESC";
                    Int32 newId = (Int32)cmd.ExecuteScalar();

                    sqlcon.Close(); // close connection

                    User user = new User ( tboxUsername.Text, "C", newId );

                    Logging logging = new Logging();
                    logging.createAccountLog(user);

                    MessageBox.Show("Account created successfully. Please login now.");
                    frmLogin objFrmLogin = new frmLogin();
                    this.Hide();
                    objFrmLogin.Show();
                }
            }
            else if (rdiobtnEmployee.Checked) // employee account creation
            {
                if (tboxPassword.Text != tboxConfirmPassword.Text) // password validation
                {
                    MessageBox.Show("Passwords do not match.");
                }
                else
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into employee (Name, Location, Password) values ('" + tboxUsername.Text + "', '" + tboxLocation.Text + "', '" + tboxPassword.Text + "')";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT TOP 1 * FROM employee ORDER BY ID DESC";
                    Int32 newId = (Int32)cmd.ExecuteScalar();

                    sqlcon.Close(); // close connection

                    User user = new User(tboxUsername.Text, "E", newId);

                    Logging logging = new Logging();
                    logging.createAccountLog(user);

                    MessageBox.Show("Account created successfully. Please login now.");
                    frmLogin objFrmLogin = new frmLogin();
                    this.Hide();
                    objFrmLogin.Show();
                }
               
            }
            else //no account type selected
            {
                MessageBox.Show("Please check a button for what kidn of account you are making.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin objFrmLogin = new frmLogin();
            this.Hide();
            objFrmLogin.Show();
        }
    }
}
