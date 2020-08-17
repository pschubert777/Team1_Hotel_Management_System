using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace Hotel_Management_System
{
    class ThirdPartyFile
    {
       
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }

        public DateTime today_date { get; set; }

        public int third_party_id { get; set; }

        public int hotel_id { get; set; }

        public string use_rewards { get; set; }

        public int num_occupants { get; set; }

        public int customer_id { get; set; }

        public string room_package_type { get; set; }

        public int charge_amount_deposit { get; set; }



        public ThirdPartyFile()
        {

        }



       public void read_in_data()
        {
            using (StreamReader readFile = new StreamReader("ThirdPartyRequest.txt"))
            {
                string request = "";
                while( (request =readFile.ReadLine()) != null)
                {
                    string[] individual_details= request.Split(' ');
                    parse_and_filter_data(individual_details);

                    Reservation res = new Reservation();
                    res.Third_party_id = third_party_id;
                    res.startDate = start_date;
                    res.endDate = end_date;
                    res.numGuests = num_occupants;
                    res.hotel_id = hotel_id;
                    res.roomType = room_package_type;


                }
            }
        }


        private void parse_and_filter_data(string[] data)
        {
            third_party_id = Convert.ToInt32(data[1]);
            customer_id = Convert.ToInt32(data[3]);
            hotel_id = Convert.ToInt32(data[5]);
            num_occupants = Convert.ToInt32(data[7]);
            start_date = DateTime.ParseExact(data[9], "yyyyMMdd", CultureInfo.InvariantCulture);
            end_date = DateTime.ParseExact(data[11], "yyyyMMdd", CultureInfo.InvariantCulture);
            if (data.Length == 20)
            {
                room_package_type = data[13];
                charge_amount_deposit = Convert.ToInt32(data[17]);
                use_rewards = data[19];
            }
            else
            {
                room_package_type = $"{data[13]}{data[14]}";
                charge_amount_deposit = Convert.ToInt32(data[18]);
                use_rewards = data[20];

            }

            use_rewards = use_rewards == "Y" ? "Yes" : "No";
        }

    }
}
