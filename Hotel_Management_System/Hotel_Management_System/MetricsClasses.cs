using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    class RewardsSummary
    {
        private string Start_date;
        private string End_date;
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
            Rewards_earned = 0;
            Rewards_redeemed = 0;
            Num_customers = 0;

            Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        public void Calculate_rewards_outstanding()
        {
            int Customer_rewards_present = 0, Customer_Rewards_spent = 0, Customer_Rewards_gained = 0;
            // retrieving a rewards points summed up
            SqlCommand query1_1 = new SqlCommand("Select SUM(Reward_Points) from Customer", Connection);
            Customer_rewards_present = Convert.ToInt32(query1_1.ExecuteScalar());

            // retrieving reward points spent 
            SqlCommand query1_2 = new SqlCommand("Select SUM(Reward_points_spent) from Transactions Where Transaction_date Between @StartDate AND @EndDate", Connection);
             query1_2.Parameters.AddWithValue("@StartDate", Start_date);
             query1_2.Parameters.AddWithValue("@EndDate",End_date);
            Customer_Rewards_spent = Convert.ToInt32(query1_2.ExecuteScalar());

            
            // retrieving reward points gained
            SqlCommand query1_3 = new SqlCommand("Select SUM(Reward_points_gained) from Transactions Where Transaction_date Between @StartDate AND @EndDate", Connection);
            query1_3.Parameters.AddWithValue("@StartDate", Start_date);
            query1_3.Parameters.AddWithValue("@EndDate", End_date);
            Customer_Rewards_gained = Convert.ToInt32(query1_3.ExecuteScalar());

            Rewards_outstanding_start_date = (Customer_rewards_present - Customer_Rewards_gained) + Customer_Rewards_spent;




        }

        public void Calculate_rewards_earned()
        {

        }

        public void Calculate_rewards_redeemed()
        {

        }

        public void Export_file()
        {

        }


        ~RewardsSummary()
        {
          
        }
      



    }
}
