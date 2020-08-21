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
        private DateTime Start_date;
        private DateTime End_date;
        private DateTime today_date;
        public int Rewards_outstanding_start_date { get; set; }
        public int Rewards_outstanding_end_date { get; set; }
        public int Rewards_redeemed { get; set; }
        public int Num_customers { get; set; }
        public int Rewards_earned { get; set; }

        private SqlConnection Connection;
        

        public RewardsSummary(DateTime start_date, DateTime end_date)
        {
            Start_date = start_date.Date;
            End_date = end_date.Date;
            today_date = DateTime.Now.Date;

            Rewards_earned = 0;
            Rewards_redeemed = 0;
            Num_customers = 0;

            Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

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
            var result = query1_1.ExecuteScalar();
            Customer_rewards_present = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                // retrieving reward points spent between begin date and today's date
                SqlCommand query1_2 = new SqlCommand("Select SUM(Reward_points_spent) from Transactions Where Transaction_date Between @StartDate AND @TodayDate", Connection);
                query1_2.Parameters.AddWithValue("@StartDate", Start_date);
                query1_2.Parameters.AddWithValue("@TodayDate", today_date);
            var result1 = query1_2.ExecuteScalar();
            Customer_Rewards_spent = result1 != DBNull.Value ? Convert.ToInt32(result1) : 0;



            // retrieving reward points gained between begin date and today's date
            SqlCommand query1_3 = new SqlCommand("Select SUM(Reward_points_gained) from Transactions Where Transaction_date Between @StartDate AND @TodayDate", Connection);
                query1_3.Parameters.AddWithValue("@StartDate", Start_date);
                query1_3.Parameters.AddWithValue("@TodayDate", today_date);
            var result2 = query1_3.ExecuteScalar();
            Customer_Rewards_gained = result2 != DBNull.Value ? Convert.ToInt32(result2) : 0;

                Rewards_outstanding_start_date = (Customer_rewards_present - Customer_Rewards_gained) + Customer_Rewards_spent;


            // retrieving reward points spent between end date and today's date
               SqlCommand query2_2 = new SqlCommand("Select SUM(Reward_points_spent) from Transactions Where Transaction_date Between @EndDate AND @TodayDate", Connection);
               query2_2.Parameters.AddWithValue("@EndDate", End_date);
               query2_2.Parameters.AddWithValue("@TodayDate", today_date);
            var result3 = query2_2.ExecuteScalar();
            Customer_Rewards_spent = result3 != DBNull.Value ? Convert.ToInt32(result3) : 0;


               // retrieving reward points gained between end date and today's date
               SqlCommand query2_3 = new SqlCommand("Select SUM(Reward_points_gained) from Transactions Where Transaction_date Between @StartDate AND @TodayDate", Connection);
               query2_3.Parameters.AddWithValue("@EndDate", End_date);
               query2_3.Parameters.AddWithValue("@TodayDate", today_date);
            var result4 = query2_3.ExecuteScalar();
            Customer_Rewards_gained = result4 != DBNull.Value ? Convert.ToInt32(result4) : 0;


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

            using (StreamWriter writer = File.CreateText(@"C:\Users\ncare\Documents\HMS_ExportFiles\RewardsSummary.txt"))
            {


                writer.WriteLine($"Rewards Summary from {Start_date.ToShortDateString()} to {End_date.ToShortDateString()}");
                writer.WriteLine($"Rewards as of {Start_date}: {Rewards_outstanding_start_date}");
                writer.WriteLine($"Rewards as of {End_date}: {Rewards_outstanding_end_date}");
                writer.WriteLine($"Total Rewards Earned: {Rewards_earned}");
                writer.WriteLine($"Total Rewards Spent: {Rewards_redeemed}");
                writer.Close();

            }

        }
      
    }


    class OccupancySummary
    {
        private DateTime Start_date;
        private DateTime End_date;
       // private DateTime today_date;
        private int date_difference;
        private SqlConnection Connection;

        public int TotalRevenue { get; set; }
        public double TotalRooms { get; set; }
        private double Total_rooms_Occupied;
        private double Total_rooms_Unoccupied;
        private double Total_rooms_Unoccupied_maintenance;
        

        public OccupancySummary(DateTime start_date, DateTime end_date)
        {
            Start_date = start_date.Date;
            End_date = end_date.Date;
            date_difference = (start_date-End_date).Days == 0 ? 1 : (Start_date - End_date).Days;


            //today_date = DateTime.Now.Date;
            Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Total_rooms_Occupied = 0;
            Total_rooms_Unoccupied = 0;
            Total_rooms_Unoccupied_maintenance = 0;
            TotalRooms = 0;
           
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

        public void calculateRoomsOccupied_Unoccupied()
        {
            
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            //SqlCommand query1 = new SqlCommand("Select Count(*) from Reservation INNER Join Transaction on Reservation.Id = Transactions.Reservation_Id where Transactions.Transaction_date BETWEEN @StartDate AND @EndDate AND Reservation.Reservation_status <> @Status ");
            //query1.Parameters.AddWithValue("@Status", "Cancelled");
            //query1.Parameters.AddWithValue("@StartDate", Start_date);
            //query1.Parameters.AddWithValue("@EndDate", End_date);
            //Rooms_Occupied = Convert.ToInt32(query1.ExecuteScalar());

            for (var individual_date = Start_date; individual_date <= End_date; individual_date =individual_date.AddDays(1))
            {
                SqlCommand query2 = new SqlCommand("Select Count(*) From Reservation where Reservation_status NOT LIKE @Status AND @selectedDate Between Start_date and End_date", Connection);
                query2.Parameters.AddWithValue("@Status", "RD%");
                query2.Parameters.AddWithValue("@selectedDate", individual_date.Date);

                int Rooms_Occupied = Convert.ToInt32(query2.ExecuteScalar());

                Total_rooms_Unoccupied += Convert.ToDouble(TotalRooms -Rooms_Occupied);
                Total_rooms_Occupied += Convert.ToDouble(Rooms_Occupied);
            }
            SqlCommand query3 = new SqlCommand("Select Count(*) From Maintenance where Date_maintenance BETWEEN @StartDate AND @Enddate", Connection);
            query3.Parameters.AddWithValue("@StartDate", Start_date.Date);
            query3.Parameters.AddWithValue("@EndDate", End_date.Date);
            Total_rooms_Unoccupied_maintenance += Convert.ToDouble(query3.ExecuteScalar());


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
            query1.Parameters.AddWithValue("@value", "true");
            query1.Parameters.AddWithValue("@StartDate", Start_date);
            query1.Parameters.AddWithValue("@EndDate", End_date);
            //query1.Parameters.AddWithValue("@ID", "true");
            var result = query1.ExecuteScalar();
            TotalRevenue = result != DBNull.Value ? Convert.ToInt32(result) : 0;


            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }


        public void ExportFile()
        {
            using (StreamWriter writer = File.CreateText(@"C:\Users\ncare\Documents\HMS_ExportFiles\Occupancy.txt"))
            {


                writer.WriteLine($"Occupancy Summary from {Start_date.ToShortDateString()} to {End_date.ToShortDateString()}");
                writer.WriteLine($"Average Percentage of Occupied Rooms {Math.Round(((Total_rooms_Occupied / date_difference) / TotalRooms) * 100, 2)}%");
                writer.WriteLine($"Average Percentage of Unoccupied Rooms {Math.Round(((Total_rooms_Unoccupied / date_difference) / TotalRooms) * 100, 2)}%");
                writer.WriteLine($"Average Percentage of Unoccupied Rooms due to maintenance {Math.Round(((Total_rooms_Unoccupied_maintenance / date_difference) / TotalRooms) * 100, 2)}% ");
                writer.WriteLine($"Total Revenue based on check out status: ${TotalRevenue}");
                writer.Close();
            }
        }

    }

    class CustomerSummary
    {
        private DateTime Start_date;
        private DateTime End_date;

        private SqlConnection Connection;

        private int Repeat_customers;
        private int Total_Num_Customers;
        private int Num_Reservations;
        private int Num_Cancellations;




        public CustomerSummary(DateTime start_date, DateTime end_date)
        {
            Start_date = start_date.Date;
            End_date = end_date.Date;
            Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            Repeat_customers = 0;
            Num_Reservations = 0;
            Num_Cancellations = 0;
        }
        public void Caculate_Repeat_customer()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            SqlCommand query1 = new SqlCommand("Select Count (Customer_Id) From Transactions Group BY Customer_Id Having Count(Id) >= @NUM_Id", Connection);
            query1.Parameters.AddWithValue("@NUM_Id", 2);
            Repeat_customers = Convert.ToInt32(query1.ExecuteScalar());

            SqlCommand query2 = new SqlCommand("Select Count (*) From Customer", Connection);
            Total_Num_Customers = Convert.ToInt32(query2.ExecuteScalar());

            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        public void Calculate_Reservations_made()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            SqlCommand query1 = new SqlCommand("Select Count(*) From Logs Where Action_type Like @ActionType AND Action_date BETWEEN @Start_date AND @End_date", Connection);
            query1.Parameters.AddWithValue("@ActionType", "RC%");
            query1.Parameters.AddWithValue("@Start_date", Start_date.Date);
            query1.Parameters.AddWithValue("@End_date", End_date.Date);
            Num_Reservations = Convert.ToInt32(query1.ExecuteScalar());
            {
                Connection.Close();
            }
        }
        public void Calculate_num_cancellations()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            SqlCommand query1 = new SqlCommand("Select Count(*) From Logs Where Action_type Like @ActionType AND Action_date BETWEEN @Start_date AND @End_date", Connection);
            query1.Parameters.AddWithValue("@ActionType", "RD%");
            query1.Parameters.AddWithValue("@Start_date", Start_date.Date);
            query1.Parameters.AddWithValue("@End_date", End_date.Date);
            Num_Cancellations = Convert.ToInt32(query1.ExecuteScalar());
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        public void ExportFile()
        {
            using (StreamWriter writer = File.CreateText(@"C:\Users\ncare\Documents\HMS_ExportFiles\Customer.txt"))
            {
                writer.WriteLine($"Customer Summary from {Start_date.ToShortDateString()} to {End_date.ToShortDateString()}");
                writer.WriteLine($"Number of Repeat Customers : {Repeat_customers} repeat customers");
                writer.WriteLine($"Perecentage of Repeat Customers : {Convert.ToInt32((Repeat_customers / Convert.ToDouble(Total_Num_Customers)) * 100)} %");
                writer.WriteLine($"Number of Reservations Made: {Num_Reservations} reservations");
                writer.WriteLine($"Number of Cancellations: {Num_Cancellations} cancellations");
                writer.Close();
            }
        }



    }
}
