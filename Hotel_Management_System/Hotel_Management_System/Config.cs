using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{

    struct Hotel
    {
        DateTime date { get; set; }
        string name { get; set; }
        string location { get; set; }
        int id { get; set; }


    }
    struct Room
    {
        string Room_type;
        int numberOfGuests, cost;

    }
    class Config
    {

        public Config()
        {


        }

        public void readHotel()
        {

            DateTime date;
            string name, city, state, package = "";
            int hotelId = 0, occupancy, roomNumber, i = 0; ;
            double cost;

            var lines = File.ReadLines(@"C:\Users\ncare\Documents\HMS_ExportFiles\Hotels.txt");

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            foreach (var line in lines)
            {
                string[] words = line.Split(' '); // split where spaces are
                
                    if (words[i].Equals("D"))
                    {

                        //date = Convert.ToDateTime(words[i++]);   
                        continue;

                        // Add logging sql statement here?
                    }
                    else if (words[i].Equals("H"))
                    {
                        hotelId = Convert.ToInt32(words[++i]);
                        name = words[++i];
                        city = words[++i];
                        state = words[++i];

                        // sql statement to insert to hotels
                        command.CommandText = "INSERT INTO Hotel (Name, Location)" +
                                            " VALUES ( '" +
                                            name + "', " + " '" +
                                            city + " " +
                                            state + "')";
                        command.ExecuteNonQuery();
                    }
                    else if (words[i].Equals("R"))
                    {
                        roomNumber = int.Parse(words[++i]);
                        i++;    // skips occupancy action code
                        occupancy = int.Parse(words[++i]);
                        i++;    // skips cost action code
                        double.TryParse(words[++i].Substring(1), out cost);
                        i++;    // skips package action code

                        while (i < words.Length - 1)
                        {
                            package += words[++i] + " ";
                        }

                    // sql statement to insert to Rooms
                    command.CommandText = "INSERT INTO Room " +
                                    " (Room_type, Room_number, Num_guests_max, Monetary_cost, Hotel_id) " +
                                    "VALUES ('" +
                                    package + "', " +
                                    roomNumber + ", " +
                                    occupancy + ", " +
                                    cost + ", " +
                                    hotelId + ")";

                        command.ExecuteNonQuery();
                    }
                

                cost = 0;
                name = city = state = package = "";
                i= occupancy = 0;

            }

            connection.Close();
        }
        public void readPromotions()
        {
            int Package_number = 0, i = 0;
            string Package_name = "", amenities = "";
            float Cost = 0;

            var lines = File.ReadLines(@"C:\Users\ncare\Documents\HMS_ExportFiles\Promotions.txt");

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            foreach (var line in lines)
            {

                string[] words = line.Split(' '); // split where spaces are
                    
                if (words[i].Equals("P"))
                {
                    if (amenities.Equals(""))
                    {
                        Package_number = Convert.ToInt32(words[++i]);
                        Package_name = words[++i];
                        float.TryParse(words[++i].Substring(1), out Cost);
                    }
                    else
                    {


                        // sql statement to insert to hotels
                        command.CommandText = "INSERT INTO Package (Package_number, Package_name, Cost, Description_amenities)" +
                                            " VALUES ( " +
                                            Package_number + ", '" +
                                            Package_name + "', " +
                                            Cost + ", '" +
                                            amenities + "')";
                        command.ExecuteNonQuery();

                        Package_number = Convert.ToInt32(words[++i]);
                        Package_name = words[++i];
                        float.TryParse(words[++i].Substring(1), out Cost);
                        amenities = "";
                    }
                    
                }
                else if (words[i].Equals("A")) 
                {
                    amenities += words[++i] + " ";
                }
                else // first line holding date leads here, possibly add logging here
                {

                }

                i = 0;

                
            }

            if (Package_number != 0 && !amenities.Equals(""))
            {
                // sql statement to insert to hotels
                command.CommandText = "INSERT INTO Package (Package_number, Package_name, Cost, Description_amenities)" +
                                    " VALUES ( " +
                                    Package_number + ", '" +
                                    Package_name + "', " +
                                    Cost + ", '" +
                                    amenities + "')";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}
