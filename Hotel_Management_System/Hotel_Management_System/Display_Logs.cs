using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Display_Logs : Form
    {
        public Display_Logs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void back_menu_button_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Generate_Report_Button_Click(object sender, EventArgs e)
        {

            if (start_date_picker.Value.Date > end_date_picker.Value.Date)
            {
                MessageBox.Show("Error, invalid dates");
            }
            else
            {

                DateTime start_date = start_date_picker.Value.Date;
                DateTime end_date = end_date_picker.Value.Date;


                /*SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }


                SqlCommand query = new SqlCommand("SELECT * FROM Logs", connection);

                SqlDataReader sqlReader = query.ExecuteReader();

                while (sqlReader.Read())
                {

                    string userId = (string)sqlReader["user_id"];
                    string actionDate = (string)sqlReader["Action_date"];
                    string userType = (string)sqlReader["user_type"];
                    string actionType = (string)sqlReader["action_type"];

                    string item = string.Format(userId + actionDate + userType + actionType);

                    logResults.Items.Add(item);
                }

                connection.Close();
            }*/



                Logging logging = new Logging(start_date, end_date);

                DataTable table = logging.displayLogs();

                logResults.DisplayMember = "user_id";
                logResults.ValueMember = "user_id";
                logResults.DataSource = table;
            }
        }
    }
}
