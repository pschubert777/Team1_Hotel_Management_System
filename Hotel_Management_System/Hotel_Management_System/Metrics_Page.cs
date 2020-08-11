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
                
                   
                    if (Rewards_summary_button.Checked)
                    {
                    RewardsSummary summary = new RewardsSummary(start_date_picker.Value.Date, end_date_picker.Value.Date);
                    summary.Calculate_rewards_outstanding();
                    summary.Calculate_rewards_earned();
                    summary.Calculate_rewards_redeemed();
                    summary.Export_file();

                    }
                    else if (Occupancy_Summary_button.Checked)
                    {
                    // SqlDataAdapter command = new SqlDataAdapter("CustomerDataManipulation", connection);
                    OccupancySummary summary = new OccupancySummary(start_date_picker.Value.Date, end_date_picker.Value.Date);
                    summary.calculateRoomsOccupied_Unoccupied();
                    summary.calculateTotalRevenue();
                    summary.ExportFile();
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
        }

        private void Display_error_message()
        {
            MessageBox.Show("Invalid Data! Please Try Again!");
        }
    }
}
