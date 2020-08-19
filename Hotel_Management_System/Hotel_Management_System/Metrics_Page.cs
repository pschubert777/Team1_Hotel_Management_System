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
        private User user;
        private int user_id {get; set;}
        private string user_type { get; set; }
        public Metrics_Page()
        {
            InitializeComponent();
            //user = new User("John", "E", 1); // test user
        }
        public Metrics_Page(User u)
        {
            InitializeComponent();
            user = u;
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
                        try
                        {
                        RewardsSummary summary = new RewardsSummary(start_date_picker.Value.Date, end_date_picker.Value.Date);
                        summary.Calculate_rewards_outstanding();
                        summary.Calculate_rewards_earned();
                        summary.Calculate_rewards_redeemed();
                        summary.Export_file();

                        }  
                        catch(Exception error)
                        {
                        MessageBox.Show(error.Message);
                        }

                    }
                    else if (Occupancy_Summary_button.Checked)
                    {
                    // SqlDataAdapter command = new SqlDataAdapter("CustomerDataManipulation", connection);
                        try
                        {
                        OccupancySummary summary = new OccupancySummary(start_date_picker.Value.Date, end_date_picker.Value.Date);
                        summary.calculateRoomsOccupied_Unoccupied();
                        summary.calculateTotalRevenue();
                        summary.ExportFile();
                        }
                        catch (Exception error)
                        {
                        MessageBox.Show(error.Message);
                        }
                    }
                    else if (Customer_Report_button.Checked)
                    {
                    // SqlDataAdapter command = new SqlDataAdapter("CustomerDataManipulation", connection);
                    try
                    {
                        CustomerSummary summary = new CustomerSummary(start_date_picker.Value.Date, end_date_picker.Value.Date);
                        summary.Caculate_Repeat_customer();
                        summary.Calculate_Reservations_made();
                        summary.Calculate_num_cancellations();
                        summary.ExportFile();
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    }
                    else
                    {
                        Display_error_message();
                    }
                

                // ***JOHN** Put logs query here****
                Logging logging = new Logging();
                logging.metricsLog(user);

                clear();
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
            AccountManagementInterface.frmEmployeeMenu objEmployeeMenuReturn = new AccountManagementInterface.frmEmployeeMenu(user);
            this.Hide();
            objEmployeeMenuReturn.Show();
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


        public void clear()
        {
            Rewards_summary_button.Checked = false;
            Occupancy_Summary_button.Checked = false;
            Customer_Report_button.Checked = false;
            end_date_picker.Value = DateTime.Now.Date;
            start_date_picker.Value = DateTime.Now.Date;

        }
    }
}
