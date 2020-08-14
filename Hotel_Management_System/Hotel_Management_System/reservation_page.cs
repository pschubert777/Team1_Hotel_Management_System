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
    public partial class reservation_page : Form
    {
        private int user_id { get; set; }
        private string user_type { get; set; }

        Reservation res = new Reservation();
        private string reservationSearchID { get; set; }
        public reservation_page()
        {
            //default values
            InitializeComponent();
            res.startDate = startDatePicker.Value;
            res.endDate = endDatePicker.Value;
            res.hotel_id = 0;
            res.roomType = "";
            res.numGuests = 0;
            res.cardNum = 0;
            reservationSearchID = "";
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            res.startDate = startDatePicker.Value;
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            res.endDate = endDatePicker.Value;
        }

        private void hotelLocationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            res.hotel_id = Convert.ToInt32( hotelLocationBox.Text);
        }

        private void roomTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            res.roomType = roomTypeBox.Text;
        }

        private void numberOfGuestsBox_ValueChanged(object sender, EventArgs e)
        {
            try { res.numGuests = Convert.ToInt32(numberOfGuestsBox.Value); }
            catch (FormatException _e) { Console.WriteLine(_e.Message); }
        }

        private void creditCardNumberBox_TextChanged(object sender, EventArgs e)
        {
            try { res.cardNum = Int32.Parse(creditCardNumberBox.Text); }
            catch (FormatException _e) { Console.WriteLine(_e.Message); }
        }

        private void submitUpdateButton_Click(object sender, EventArgs e)
        {
            if (startDatePicker.Value.Date > endDatePicker.Value.Date)
            {
                MessageBox.Show("Error - Start Date later than End Date");
            }
            else
            {
                try
                {
                    //test line to show values when submitted. delete before turning in
                    MessageBox.Show(res.startDate.ToString() + "\n" + res.endDate.ToString() + "\n" + res.hotel_id + "\n" + res.roomType + "\n" + res.numGuests + "\n" + res.cardNum);
                    //reward points dialogue box
                    //only show this if user has at least 50 reward points
                    res.DetermineAvailability();
                    var confirmRewards = MessageBox.Show("Would you like to use 50 reward points to get a 10% discount?", "Reward Points", MessageBoxButtons.YesNo);

                    string useRewards = ""; ;
                    useRewards = confirmRewards == DialogResult.Yes ? "Yes" : "No";

                    switch (user_type)
                    {
                        case "Customer":
                            res.book_reservation(useRewards,  user_id);
                            break;
                        default:
                            res.book_reservation(useRewards, 0);
                            break;
                    }//*****PlaceHolder NEED to come up with functionality to retrieve Customer ID if user is EMPLOYEE

                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //reset all fields. eventually this button will probably just return the user to the previous page though
            res = new Reservation(); //reset reservation object
            startDatePicker.ResetText();
            endDatePicker.ResetText();
            hotelLocationBox.ResetText();
            roomTypeBox.ResetText();
            numberOfGuestsBox.ResetText();
            creditCardNumberBox.ResetText();
        }

        private void reservationIdBox_TextChanged(object sender, EventArgs e)
        {
            reservationSearchID = reservationIdBox.Text;
        }

        private void reservationSearchButton_Click(object sender, EventArgs e)
        {

            SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataTable dataTable1 = new DataTable();

            if(Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            try
            {
                if (user_type == "Employee" && reservationSearchID != "")
                {

                    SqlDataAdapter query = new SqlDataAdapter("Select * From Reservation Where Id =@resID", Connection);
                    query.SelectCommand.Parameters.AddWithValue("@resID", Convert.ToInt32(reservationSearchID));
                    query.Fill(dataTable1);
                    ReservationDataGridView.DataSource = dataTable1;

                }
                else if (user_type == "Employee" && reservationSearchID == "")
                {

                    SqlDataAdapter query = new SqlDataAdapter("Select * From Reservation", Connection);
                    query.Fill(dataTable1);
                    ReservationDataGridView.DataSource = dataTable1;
                }
                else if (user_type == "Customer" && reservationSearchID != "")
                {
                    SqlDataAdapter query = new SqlDataAdapter("Select * From Reservation Where Id =@resID AND Customer_Id = @CustomerID", Connection);
                    query.SelectCommand.Parameters.AddWithValue("@CustomerID", user_id);
                    query.SelectCommand.Parameters.AddWithValue("@resID", Convert.ToInt32(reservationSearchID));
                    query.Fill(dataTable1);
                    ReservationDataGridView.DataSource = dataTable1;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Connection.Close();
            }
        }
    }

    public class Reservation
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int hotel_id { get; set; }
        public string roomType { get; set; }
        public int numGuests { get; set; }
        public int cardNum { get; set; }

        public int Third_party_id { get; set; } = -1;


        public void DetermineAvailability()
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            bool enough_rooms = true;

            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }


            for (var individual_date = startDate; individual_date <= endDate; individual_date.AddDays(1))
            {
                try
                {
                    SqlCommand query = new SqlCommand("Select Count(*) From Reservation where Reservation_status NOT LIKE @Status AND @Current_Date Between Start_date and End_date AND Room_type = @roomType AND Hotel_location_Id = @HotelID", Connection);
                    query.Parameters.AddWithValue("@Status", "Cancelled%");
                    query.Parameters.AddWithValue("@Current_Date", individual_date);
                    query.Parameters.AddWithValue("@roomType", roomType);
                    query.Parameters.AddWithValue("@HotelID", hotel_id);
                    int num_occupied = Convert.ToInt32(query.ExecuteScalar());

                    SqlCommand query2 = new SqlCommand("Select Count(*) From Maintenance Where Date_maintenance = @Current_Date", Connection);
                    query2.Parameters.AddWithValue("@Current_Date", individual_date);
                    int num_maintenance = Convert.ToInt32(query2.ExecuteScalar());

                    SqlCommand query3 = new SqlCommand("Select Count(*) From Room where Room_type = @Type AND Hotel_id = @HotelID ", Connection);
                    query3.Parameters.AddWithValue("@Type", roomType);
                    query3.Parameters.AddWithValue("@HotelID", hotel_id);
                    int num_total_rooms = Convert.ToInt32(query3.ExecuteScalar());

                    if (num_total_rooms - num_maintenance - num_occupied <= 0)
                    {
                        enough_rooms = !enough_rooms;
                        break;
                    }
                }
                catch (Exception error)
                {
                    Connection.Close();
                    throw new Exception(error.Message);
                }

            }


            if (Connection.State == ConnectionState.Open) { Connection.Close(); }
            if (!enough_rooms){throw new Exception("There are not enough rooms!");}
        }


        public void book_reservation(string result, int user_id)
        {   // discount 1 =100%, 0.9 = 90% of the original
            double total_Room_Cost = 0,discount = 1;
            // get the number of nights 
            int date_difference = Convert.ToInt32((startDate.Date - endDate.Date).TotalDays);

            //25 points earned a night
            int total_points_earned = date_difference * 25;

            // check if user has enough points 
            bool enough_rewards = Check_rewards_enough(user_id);
            SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            // 10% of the original price  is total price *.9
            if (result == "Yes" && enough_rewards) { discount = 0.9; }
            

            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand query = new SqlCommand("Select distinct Monetary_cost from Room  where Room_type = @Type", Connection);
            query.Parameters.AddWithValue("@Type", roomType);
            total_Room_Cost = Convert.ToDouble(query.ExecuteScalar());

            SqlCommand query1 = new SqlCommand("Update Customer  SET Reward_Points + @NumPoints Where Id =@CustomerId", Connection);
            query1.Parameters.AddWithValue("@NumPoints", (result == "Yes" && enough_rewards) ? total_points_earned - 50 : total_points_earned);
            query1.Parameters.AddWithValue("@CustomerId", user_id);
            query1.ExecuteNonQuery();

            // insert reservation information and return the reservation id to insert into transaction
            SqlCommand query2 = new SqlCommand("Insert into Reservation(Room_type, Num_guests, Start_date, End_date, Hotel_location_Id, Points_earned) OUTPUT Inserted.ID Values(@UserID, @NumGuests, @Startdate, @EndDate, @HotelID, @PointsEarned)", Connection);
            query2.Parameters.AddWithValue("@UserID", user_id);
            query2.Parameters.AddWithValue("@NumGuests", numGuests);
            query2.Parameters.AddWithValue("@Startdate", startDate);
            query2.Parameters.AddWithValue("@EndDate", endDate);
            query2.Parameters.AddWithValue("@HotelID", hotel_id);
            query2.Parameters.AddWithValue("@PointsEarned", total_points_earned);
            int reservation_id = Convert.ToInt32(query2.ExecuteScalar());

            SqlCommand query3 = new SqlCommand("Insert into Transactions (Reservation_Id, Customer_Id, Reward_points_spent, Money_spent, Activity_type, Reward_points_gained, Transaction_date) Values (@ReservationID, @CustomerID, @RewardsSpent, @MoneySpent, @ActivityType, @RewardsGained, @TransactionDate", Connection);
            query3.Parameters.AddWithValue("@ReservationID", reservation_id);
            query3.Parameters.AddWithValue("@CustomerID", user_id);
            query3.Parameters.AddWithValue("@RewardsSpent", (result == "Yes" && enough_rewards) ? 50: 0);
            query3.Parameters.AddWithValue("@MoneySpent", total_Room_Cost *= discount);
            query3.Parameters.AddWithValue("@RewardsGained",total_points_earned);
            query3.Parameters.AddWithValue("@TransactionDate", DateTime.Now.Date);



            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }


        }

        public bool Check_rewards_enough(int user_id)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
           
            try
            {
                if (Connection.State == ConnectionState.Closed) { Connection.Open(); }

                SqlCommand query = new SqlCommand("Select Reward_Points from Customer where Id = @user_id ", Connection);
                query.Parameters.AddWithValue("@user_id", user_id);
                int num_points = Convert.ToInt32(query.ExecuteScalar());

                if(Connection.State == ConnectionState.Open) { Connection.Close(); }
                return num_points >= 50;
            }
            catch(Exception error)
            {
                Connection.Close();
                throw new Exception(error.Message);
            }


        }
    }

}
