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
        User user = new User();

        private void fill_data_grid_view()
        {
            DataTable x = new DataTable();
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
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
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
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
                            roomTypeBox.Items.Add(x[1].ToString());
                        }
                    }
                }
            }
        }

        private void Populate_hotel_combo_box()
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
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
            Populate_hotel_combo_box();
            Populate_room_type_combo_box();
        }
        public room_management_page(User u)
        {
            InitializeComponent();
            user = u;
            fill_data_grid_view();
            Populate_hotel_combo_box();
            Populate_room_type_combo_box();

            
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
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                Connection.Open();

                try
                {
                    using (SqlCommand query = new SqlCommand("UPDATE Room SET Maintenance_status =@MaintStatus WHERE Room_number =@RoomNum AND Hotel_id =@HotelId", Connection))
                    {
                        query.Parameters.AddWithValue("@MaintStatus", room.status);
                        query.Parameters.AddWithValue("@RoomNum", room.number);
                        query.Parameters.AddWithValue("@HotelId", room.hotel);
                        query.ExecuteNonQuery();

                        MessageBox.Show("Updates completed!");
                    }
                    fill_data_grid_view();
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

            // JOHN - logging stuff here ---------------------------------------------------------------------------------------
            Logging logging = new Logging();
            logging.roomLog(user, room.number, room.status);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            roomNumberBox.ResetText();
            roomTypeBox.ResetText();
            hotelBox.ResetText();
            maintenance_combo_box.ResetText();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AccountManagementInterface.frmEmployeeMenu objReturnEmployeeMenu = new AccountManagementInterface.frmEmployeeMenu(user);
            this.Hide();
            objReturnEmployeeMenu.Show();
        }

        private void roomListBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Transferring Data from Data grid view to textbox
            if (roomListBox.CurrentRow.Index >= 0)
            {
                //update room object
                room.number = Convert.ToInt32(roomListBox.CurrentRow.Cells[1].Value);
                room.type = Convert.ToString(roomListBox.CurrentRow.Cells[2].Value);
                room.hotel = Convert.ToInt32(roomListBox.CurrentRow.Cells[3].Value);
                room.status = Convert.ToString(roomListBox.CurrentRow.Cells[4].Value);

                //update input boxes
                roomNumberBox.Value = room.number;
                
                foreach (var item in hotelBox.Items)
                {
                    string[] hotelId = item.ToString().Split(' ');
                    if (Convert.ToInt32(hotelId[0]) == Convert.ToInt32(roomListBox.CurrentRow.Cells[3].Value))
                    {

                        hotelBox.Text = item.ToString();
                        break;
                    }
                }
                
                foreach (var item in roomTypeBox.Items)
                {
                    string[] roomType = item.ToString().Split(' ');
                    if (Convert.ToString(roomType[0]) == Convert.ToString(roomListBox.CurrentRow.Cells[2].Value))
                    {
                        roomTypeBox.Text = item.ToString();
                        break;
                    }
                }
                
                foreach (var item in maintenance_combo_box.Items)
                {
                    string[] maint = item.ToString().Split(' ');
                    if (Convert.ToString(maint[0]) == Convert.ToString(roomListBox.CurrentRow.Cells[4].Value))
                    {
                        maintenance_combo_box.Text = item.ToString();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Index out of range");
            }
        }

        private void maintenance_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.status = maintenance_combo_box.Text;
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
