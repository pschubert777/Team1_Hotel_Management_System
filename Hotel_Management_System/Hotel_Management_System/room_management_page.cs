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

        private void Populate_room_type_combo_box()
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }

                using (SqlCommand query = new SqlCommand("Select * From Room", Connection))
                {
                    using (SqlDataReader x = query.ExecuteReader())
                    {
                        while (x.Read())
                        {
                            hotelBox.Items.Add(x[1].ToString());
                        }
                    }
                }
            }
        }

        private void Populate_hotel_combo_box()
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }

                using (SqlCommand query = new SqlCommand("Select * From Hotel", Connection))
                {
                    using (SqlDataReader x = query.ExecuteReader())
                    {
                        while (x.Read())
                        {
                            string hotel_id = x[0].ToString();
                            string hotel_name = x[1].ToString();
                            string hotel_location = x[2].ToString();

                            string combined_data = $"{hotel_id} {hotel_name} {hotel_location}";
                            hotelBox.Items.Add(combined_data);
                        }
                    }
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
            string[] getID = hotelBox.Text.Split(' ');
            room.hotel = Convert.ToInt32(getID[0]);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                Connection.Open();

                try
                {
                    //using (SqlCommand query = new SqlCommand("UPDATE Room SET  WHERE Id = ", Connection))
                    //{
                    //    
                    //}
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

        private void button1_Click(object sender, EventArgs e)
        {
            AccountManagementInterface.frmEmployeeMenu objReturnEmployeeMenu = new AccountManagementInterface.frmEmployeeMenu();
            this.Hide();
            objReturnEmployeeMenu.Show();
        }
    }

    public struct roomType
    {
        public decimal number { get; set; }
        public string type { get; set; }
        public int hotel { get; set; }
        public string status { get; set; }
    }
}
