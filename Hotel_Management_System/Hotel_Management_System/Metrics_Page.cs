using System;
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
    public partial class Metrics_Page : Form
    {
        public Metrics_Page()
        {
            InitializeComponent();
        }

        private void Generate_Report_Button_Click(object sender, EventArgs e)
        {
            if (start_date_picker.Value.Date > end_date_picker.Value.Date)
            {
                Display_error_message();
            }
            else
            {
                // SqlConnection connection = new SqlConnection(@"Data Source= "):
                try
                {
                    /*  if (connection.State == ConnectionState.Closed)
                      {
                          connection.Open();
                      }*/
                    if (Rewards_summary_button.Checked)
                    {
                       // SqlDataAdapter command = new SqlDataAdapter("CustomerDataManipulation", connection);
                    }
                    else if (Occupancy_Summary_button.Checked)
                    {
                        // SqlDataAdapter command = new SqlDataAdapter("CustomerDataManipulation", connection);
                    }
                    else if (Customer_Report_button.Checked)
                    {
                        // SqlDataAdapter command = new SqlDataAdapter("CustomerDataManipulation", connection);
                    }
                    else
                    {
                        Display_error_message();
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    //connection.Close();
                }

            }
        }

        private void Display_error_message()
        {
            MessageBox.Show("Invalid Data! Please Try Again!");
        }
    }
}
