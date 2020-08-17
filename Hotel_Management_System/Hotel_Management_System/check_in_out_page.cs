﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class check_in_out_page : Form
    {
        public bool checkedIn { get; set; }
        public bool CheckedOut { get; set; }
        private int user_id { get; set; }

        private string reservationSearchID { get; set; }

        private void fill_data_grid_view()
        {
            DataTable x = new DataTable();
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }

                using (SqlDataAdapter query = new SqlDataAdapter("Select * From Reservation", Connection))
                {
                    query.Fill(x);
                    resultsBox.DataSource = x;
                }
            }
        }

        public check_in_out_page()
        {
            InitializeComponent();

            checkedIn = false;
            user_id = 0;
            reservationSearchID = "";

            fill_data_grid_view();
        }

        private void checkInOutStatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkInOutStatusBox.SelectedIndex == 0)
                checkedIn = true;
            else if (checkInOutStatusBox.SelectedIndex == 1)
                checkedIn = false;
        }

        private void statusSubmitButton_Click(object sender, EventArgs e)
        {

            string reservationID = resultsBox.CurrentRow.Cells[0].Value.ToString();

            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                Connection.Open();

                try
                {
                    using (SqlCommand query = new SqlCommand("UPDATE Reservation SET Check_in = @checkedIn, Check_out = @checkedOut WHERE Id = @ResID", Connection))
                    {
                        //query.Parameters.AddWithValue("@Startdate", startDate);
                        query.Parameters.AddWithValue("@checkedIn", checkedIn);
                        query.Parameters.AddWithValue("@checkedOut", checkedOut);
                        query.Parameters.AddWithValue("@ResID", reservationID);
                        query.ExecuteNonQuery();

                        MessageBox.Show("Updates completed!");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }

            fill_data_grid_view();
        }

        private void resultsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reservationIdBox_TextChanged(object sender, EventArgs e)
        {
            reservationSearchID = reservationIdBox.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataTable table = new DataTable();

            if (Connection.State == ConnectionState.Closed) { Connection.Open(); }

            try
            {
                if (reservationSearchID != "")
                {

                    SqlDataAdapter query = new SqlDataAdapter("Select * From Reservation Where Id =@resID", Connection);
                    query.SelectCommand.Parameters.AddWithValue("@resID", Convert.ToInt32(reservationSearchID));
                    query.Fill(table);
                    resultsBox.DataSource = table;

                }
                else if (reservationSearchID == "")
                {

                    SqlDataAdapter query = new SqlDataAdapter("Select * From Reservation", Connection);
                    query.Fill(table);
                    resultsBox.DataSource = table;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Connection.Close();
            }
            fill_data_grid_view();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            AccountManagementInterface.frmEmployeeMenu objReturnEmployeeMenu = new AccountManagementInterface.frmEmployeeMenu();
            this.Hide();
            objReturnEmployeeMenu.Show();
        }

        private void getStatus()
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (Connection.State == ConnectionState.Closed) { Connection.Open(); }

            SqlCommand query = new SqlCommand("Select Count(*) from Reservation where Check_in = @checkedIn, Check_out = @checkedOut WHERE Id = @ResID");
            query.Parameters.AddWithValue("@checkedIn", checkedIn);
            query.Parameters.AddWithValue("@checkedOut", checkedOut);
            //TODO: not sure if this bit actually works correctly ^

            Connection.Close();
        }
    }
}
