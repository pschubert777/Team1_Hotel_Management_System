using AccountManagementInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Display_Logs : Form
    {
        private User user;
        public Display_Logs()
        {
            InitializeComponent();
            user = new User("John", "C", 1);
        }
        public Display_Logs(User u)
        {
            InitializeComponent();
            user = u;

            if (user.User_type.Equals("C"))
                userInfo.Text = "ID: " + user.id + "\nName: " + user.name + "\nUser Type: Customer";
            else if (user.User_type.Equals("E"))
                userInfo.Text = "ID: " + user.id + "\nName: " + user.name + "\nUser Type: Employee";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void back_menu_button_Click(object sender, EventArgs e)
        {
           

            frmCustomerMenu frmCustomerMenu = new frmCustomerMenu(user);
            this.Hide();
            frmCustomerMenu.Show();
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

                logResults.Items.Clear();

                DateTime start_date = start_date_picker.Value.Date;
                DateTime end_date = end_date_picker.Value.Date;

                Logging logging = new Logging(start_date, end_date);

                DataTable table = logging.displayLogs(user);

                DataRow tempRow = null;

                foreach (DataRow temp in table.Rows)
                {

                    tempRow = temp;
                   
                    ListViewItem item = new ListViewItem(tempRow["Action_date"].ToString());
                    item.SubItems.Add(tempRow["Action_type"].ToString());

                    logResults.Items.Add(item); 
                }
            }
        }

        private void Display_Logs_Load(object sender, EventArgs e)
        {

        }
    }
}
