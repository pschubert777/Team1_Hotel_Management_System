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
        public string Rewards_outstanding_start_date { get; set; }
        public string Rewards_outstanding_end_date { get; set; }
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
