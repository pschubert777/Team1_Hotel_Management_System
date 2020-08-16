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

        private void fill_data_grid_view()
        {
            DataTable x = new DataTable();
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }

                using (SqlDataAdapter query = new SqlDataAdapter("Select * From Room", Connection))
                {
                    query.Fill(x);
                    roomListBox.DataSource = x;
                }
            }
        }
        public room_management_page()
        {
            InitializeComponent();

            fill_data_grid_view();
        }

        private void roomNumberBox_ValueChanged(object sender, EventArgs e)
        {
            room.number = roomNumberBox.Value;
        }

        private void roomTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.type = roomTypeBox.Text;
        }

        private void hotelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.hotel = hotelBox.Text;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (Connection.State == ConnectionState.Closed) { Connection.Open(); }

            string customerID = roomListBox.CurrentRow.Cells[1].Value.ToString();

            try
            {
                SqlDataAdapter query = new SqlDataAdapter("Select * from Room", Connection);

                
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            roomNumberBox.ResetText();
            roomTypeBox.ResetText();
            hotelBox.ResetText();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //return to menu
        }

        private void roomListBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //populate fields with data
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
