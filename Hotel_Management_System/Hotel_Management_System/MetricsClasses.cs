using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    class RewardsSummary
    {
        private string Start_date;
        private string End_date;
        private string today_date;
        public int Rewards_outstanding_start_date { get; set; }
        public int Rewards_outstanding_end_date { get; set; }
        public int Rewards_redeemed { get; set; }
        public int Num_customers { get; set; }
        public int Rewards_earned { get; set; }

        private SqlConnection Connection;
        

        public RewardsSummary(string start_date, string end_date)
        {
            Start_date = start_date;
            End_date = end_date;
            today_date = DateTime.UtcNow.ToString("yyyy-MM-dd");

            Rewards_earned = 0;
            Rewards_redeemed = 0;
            Num_customers = 0;

            Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        public void Calculate_rewards_outstanding()
        {
            int Customer_rewards_present = 0, Customer_Rewards_spent = 0, Customer_Rewards_gained = 0;
            if (Connection.State == ConnectionState.Closed)
                     {
                         Connection.Open();
                    }
                // retrieving a rewards points summed up
                SqlCommand query1_1 = new SqlCommand("Select SUM(Reward_Points) from Customer", Connection);
                Customer_rewards_present = Convert.ToInt32(query1_1.ExecuteScalar());

                // retrieving reward points spent between begin date and today's date
                SqlCommand query1_2 = new SqlCommand("Select SUM(Reward_points_spent) from Transactions Where Transaction_date Between @StartDate AND @TodayDate", Connection);
                query1_2.Parameters.AddWithValue("@StartDate", Start_date);
                query1_2.Parameters.AddWithValue("@TodayDate", today_date);
                Customer_Rewards_spent = Convert.ToInt32(query1_2.ExecuteScalar());


                // retrieving reward points gained between begin date and today's date
                SqlCommand query1_3 = new SqlCommand("Select SUM(Reward_points_gained) from Transactions Where Transaction_date Between @StartDate AND @TodayDate", Connection);
                query1_3.Parameters.AddWithValue("@StartDate", Start_date);
                query1_3.Parameters.AddWithValue("@TodayDate", today_date);
                Customer_Rewards_gained = Convert.ToInt32(query1_3.ExecuteScalar());

                Rewards_outstanding_start_date = (Customer_rewards_present - Customer_Rewards_gained) + Customer_Rewards_spent;


            // retrieving reward points spent between end date and today's date
               SqlCommand query2_2 = new SqlCommand("Select SUM(Reward_points_spent) from Transactions Where Transaction_date Between @EndDate AND @TodayDate", Connection);
               query2_2.Parameters.AddWithValue("@EndDate", End_date);
               query2_2.Parameters.AddWithValue("@TodayDate", today_date);
               Customer_Rewards_spent = Convert.ToInt32(query2_2.ExecuteScalar());


               // retrieving reward points gained between end date and today's date
               SqlCommand query2_3 = new SqlCommand("Select SUM(Reward_points_gained) from Transactions Where Transaction_date Between @StartDate AND @TodayDate", Connection);
               query2_3.Parameters.AddWithValue("@EndDate", End_date);
               query2_3.Parameters.AddWithValue("@TodayDate", today_date);
               Customer_Rewards_gained = Convert.ToInt32(query2_3.ExecuteScalar());


            Rewards_outstanding_end_date = (Customer_rewards_present - Customer_Rewards_gained) + Customer_Rewards_spent;


            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }



        }
        // Rewards earned during the time period start date and end date
        public void Calculate_rewards_earned()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand query1 = new SqlCommand("Select SUM(Reward_points_spent) from Transactions Where Transaction_date Between @StartDate AND @EndDate", Connection);
            query1.Parameters.AddWithValue("@StartDate", Start_date);
            query1.Parameters.AddWithValue("@EndDate", End_date);
            Rewards_earned = Convert.ToInt32(query1.ExecuteScalar());



            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        // Rewards earned during the time period start date and end date
        public void Calculate_rewards_redeemed()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand query1 = new SqlCommand("Select SUM(Reward_points_spent) from Transactions Where Transaction_date Between @StartDate AND @EndDate", Connection);
            query1.Parameters.AddWithValue("@StartDate", Start_date);
            query1.Parameters.AddWithValue("@EndDate", End_date);
            Rewards_redeemed = Convert.ToInt32(query1.ExecuteScalar());



            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public void Export_file()
        {

            StreamWriter writer = new StreamWriter(@"C:\Users\peterschubert\Documents\FilesTest\Test.txt");
            writer.WriteLine($"Rewards as of {Start_date}: {Rewards_outstanding_start_date}");
            writer.WriteLine($"Rewards as of {End_date}: {Rewards_outstanding_end_date}");
            writer.WriteLine($"Total Rewards Earned: {Rewards_earned}");
            writer.WriteLine($"Total Rewards Spent: {Rewards_redeemed}");
            writer.Close();
         


        }
      
    }


    class OccupancySummary
    {
        private string Start_date;
        private string End_date;
        private string today_date;
        private SqlConnection Connection;

        public int TotalRevenue { get; set; }
        public double Rooms_Occupied;
        public double Rooms_Unoccupied;
        public double Rooms_Unoccupied_maintenance;
        public int TotalRooms { get; set; }

        public OccupancySummary(string start_date, string end_date)
        {
            Start_date = start_date;
            End_date = end_date;
            today_date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
           
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand query1 = new SqlCommand("Select Count(*) From Room", Connection);
            TotalRooms = Convert.ToInt32(query1.ExecuteScalar());



            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }

        }

        public void calculateRoomsOccupied()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            SqlCommand query1 = new SqlCommand("Select Count(*) from Reservation INNER Join Transaction on Reservation.Id = Transactions.Reservation_Id where Transactions.Transaction_date BETWEEN @StartDate AND @EndDate AND Reservation.Reservation_status <> @Status ");
            query1.Parameters.AddWithValue("@Status", "Cancelled");
            query1.Parameters.AddWithValue("@StartDate", Start_date);
            query1.Parameters.AddWithValue("@EndDate", End_date);
            Rooms_Occupied = Convert.ToInt32(query1.ExecuteScalar());




            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public void calculateRoomsUnOccupied()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }


            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public void calculateTotalRevenue()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand query1 = new SqlCommand("Select SUM(Transactions.Money_Spent)FROM Transactions INNER JOIN Reservation ON Transactions.Reservation_Id = Reservation.Id WHERE Reservation.Check_out = @value AND Transactions.Transaction_date Between @StartDate AND @EndDate", Connection);
            query1.Parameters.AddWithValue("@StartDate", Start_date);
            query1.Parameters.AddWithValue("@EndDate", End_date);
            query1.Parameters.AddWithValue("@ID", "true");
            TotalRevenue = Convert.ToInt32(query1.ExecuteScalar());

            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

    }
}
