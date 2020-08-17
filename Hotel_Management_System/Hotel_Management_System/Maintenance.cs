using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_Management_System
{
    class Maintenance
    {

        public Maintenance()
        {

        }
        public void read_file()
        {
            try
            {
                using (StreamReader readFile = new StreamReader(@"C:\Users\peterschubert\Documents\FilesTest\Maintenance.txt"))
                {
                    string maintenance_input = "";

                    while ((maintenance_input = readFile.ReadLine()) != null)
                    {





                    }
                }

            }
            catch (Exception error)
            {
                using (StreamWriter writer = File.AppendText(@"C:\Users\peterschubert\Documents\FilesTest\Errors.txt"))
                {
                    writer.WriteLine($"Cannot Read Maintenance File! {DateTime.Now}");
                    writer.WriteLine(error.Message);
                    writer.Close();
                }

            }




        }




        private int search_room_id(int room_number, int hotel_id)
        {
            int room_id = 0;
            using (SqlConnection Connection= new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                Connection.Open();

                using (SqlCommand query = new SqlCommand("Select Id from Room Where Room_number = @RoomNum AND Hotel_id = @HotelID", Connection))
                {
                    query.Parameters.AddWithValue("@RoomNum", room_number);
                    query.Parameters.AddWithValue("@HotelID", hotel_id);

                   room_id= Convert.ToInt32(query.ExecuteScalar());

                }

            }

            return room_id;
        }



    }
}
