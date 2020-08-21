using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace Hotel_Management_System
{
    class Maintenance
    {
        private string sqlString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Maintenance()
        {

        }
        public void read_file()
        {
            try
            {
                using (StreamReader readFile = new StreamReader(@"C:\Users\ncare\Documents\HMS_ExportFiles\Maintenance.txt"))
                {
                    string maintenance_input = "";
                    DateTime date = DateTime.Now.Date;
                    int hotel_id = 0;
                    while ((maintenance_input = readFile.ReadLine()) != null)
                    {
                        string[] maint_input = maintenance_input.Split(' ');
                        
                        if (string.Equals(maint_input[0], "D"))
                        {
                            continue;
                        }
                        else if(string.Equals(maint_input[0], "M"))
                        {
                            date =DateTime.ParseExact(maint_input[2], "yyyyMMdd", CultureInfo.InvariantCulture);
                        }
                        else if( string.Equals(maint_input[0], "H")){

                            hotel_id = Convert.ToInt32(hotel_id);
                        }
                        else if(string.Equals (maint_input[0], "R"))
                        {
                            int room_id = search_room_id(Convert.ToInt32(maint_input[1]), hotel_id);

                            if(!check_duplicates(room_id, date))
                            {
                                insert_into_maintenance(room_id, date);
                            }
                        }

                    }
                }

            }
            catch (Exception error)
            {
                using (StreamWriter writer = File.AppendText(@"C:\Users\ncare\Documents\HMS_ExportFiles\Errors.txt"))
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
            using (SqlConnection Connection= new SqlConnection(sqlString))
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

        // check if a already schedule maintenance for the room on a given date exists so we dont enter it in twice
        private bool check_duplicates(int room_id, DateTime date)
        {
            bool are_duplicates = false;
            using (SqlConnection Connection = new SqlConnection(sqlString))
            {
                Connection.Open();

                using (SqlCommand query = new SqlCommand("Select Count(*) from Maintenance Where Room_Id=@RoomId and Date_maintenance =@DateMaintenance", Connection))
                {
                    int count = 0;
                    query.Parameters.AddWithValue("@RoomId ", room_id);
                    query.Parameters.AddWithValue("@DateMaintenance", date.Date);
                    count = Convert.ToInt32(query.ExecuteScalar());
                    if (count > 0){are_duplicates = true; }
                    

                }

            }
            return are_duplicates;
        }
        private void insert_into_maintenance(int room_id, DateTime date)
        {
            using (SqlConnection Connection = new SqlConnection(sqlString))
            {
                Connection.Open();

                using (SqlCommand query = new SqlCommand("Insert into Maintenance (Room_Id, Date_maintenance) Values (@RoomId, @DateMaintenance)  ", Connection))
                {
                    query.Parameters.AddWithValue("@RoomId ", room_id);
                    query.Parameters.AddWithValue("@DateMaintenance", date);
                    query.ExecuteNonQuery();


                }

            }
        }


    }
}
