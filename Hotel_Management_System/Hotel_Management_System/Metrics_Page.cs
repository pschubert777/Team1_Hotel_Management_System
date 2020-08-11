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
        private string user_id {get; set;}
        private string user_type { get; set; }
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
                        // SqlDataAdapter query1_1 = new SqlDataAdapter("Select SUM(Reward_Points) from Customer", connection);
                        // SqlDataAdapter query1_2 = new SqlDataAdapter("Select SUM(Reward_points_spent) from Transactions Where Transaction_date Between @StartDate AND @EndDate", connection);
                        //query2.Parameters.AddWithValue("@StartDate", start_date_picker.Text);
                        //query2.Parameters.AddWithValue("@EndDate", end_date_picker.Text);
                        //Int total_reward_points =Convert.ToInt32 (query1.ExecuteScalar());
                        //int total
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

        private void Start_date_label_Click(object sender, EventArgs e)
        {

        }

        private void Metrics_Page_Load(object sender, EventArgs e)
        {

        }

        private void back_menu_button_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_date_picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void end_date_picker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
