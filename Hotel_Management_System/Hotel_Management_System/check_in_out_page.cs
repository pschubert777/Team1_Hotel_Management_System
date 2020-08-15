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
    public partial class check_in_out_page : Form
    {
        public bool checkedIn = false;
        public check_in_out_page()
        {
            InitializeComponent();
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
            if (checkedIn)
                MessageBox.Show("Checked In");
            else if (!checkedIn)
                MessageBox.Show("Checked Out");
        }

        private void resultsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reservationIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {

        }
    }
}
