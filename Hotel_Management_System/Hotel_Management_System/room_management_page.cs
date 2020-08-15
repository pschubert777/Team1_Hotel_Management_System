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
    public partial class room_management_page : Form
    {
        roomType room = new roomType();
        public room_management_page()
        {
            InitializeComponent();
        }

        private void roomNumberBox_ValueChanged(object sender, EventArgs e)
        {
            room.number = roomNumberBox.Value;
        }

        private void roomTypeBox_TextChanged(object sender, EventArgs e)
        {
            room.type = roomTypeBox.Text;
        }

        private void hotelBox_TextChanged(object sender, EventArgs e)
        {
            room.hotel = hotelBox.Text;
        }

        private void statusBox_TextChanged(object sender, EventArgs e)
        {
            room.status = statusBox.Text;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public struct roomType
    {
        public decimal number { get; set; }
        public string type { get; set; }
        public string hotel { get; set; }
        public string status { get; set; }
    }
}
