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

        
     

       
       
        // customer ID when the employee is the user
        private int customer_id_employee { get; set; }
        // create user object
        User person;
        //create new reservation
        Reservation res = new Reservation();

        // reservation id for search bars
        private string reservationSearchID { get; set; }
        // rservation id for modification and cancellation of reservation
        private int reservation_id { get; set; }

        private string connectionString { get; set; } = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private bool update_reservation { get; set; }
        private void clear()
        {
            if(person.User_type == "Employee")
            {
                Customer_Id_textbox.Text = string.Empty;
            }

            reservation_id = 0;
            update_reservation = false;
            submitUpdateButton.Visible = true;
            submitUpdateButton.Text = "Submit";
            cancelButton.Visible = false;

            hotelLocationBox.Text = string.Empty;
            roomTypeBox.Text = string.Empty;
            numberOfGuestsBox.Value = 0;
            creditCardNumberBox.Text = string.Empty;

            //reset reservation object
            //res = new Reservation(); 
            //startDatePicker.ResetText();
            //endDatePicker.ResetText();
            //hotelLocationBox.ResetText();
            //roomTypeBox.ResetText();
            //numberOfGuestsBox.ResetText();
            //creditCardNumberBox.ResetText();

            startDatePicker.Value = DateTime.Now.Date;
            endDatePicker.Value = DateTime.Now.Date;
        }
        // Fill datagridView

        private void fill_data_grid_view()
        {
            DataTable x = new DataTable();
            using (SqlConnection Connection = new SqlConnection(connectionString))
            {

                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }

                string query_string = person.User_type == "Employee" ? "Select * From Reservation" : "Select * From Reservation where Customer_Id = @UserID and Reservation_status  NOT Like @Status";

                using(SqlDataAdapter query = new SqlDataAdapter(query_string, Connection))
                {
                    if(person.User_type == "Customer")
                    {
                        query.SelectCommand.Parameters.AddWithValue("@UserID", person.id);
                        query.SelectCommand.Parameters.AddWithValue("@Status", "Cancelled%");
                    }

                    query.Fill(x);
                    ReservationDataGridView.DataSource = x;


                }



            }
        }

        // Fill Combo box
        //herere
        // Hotel Combo Box

        private void Populate_hotel_combo_box()
        {
            using (SqlConnection Connection = new SqlConnection(connectionString))
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
                            hotelLocationBox.Items.Add(combined_data);
                        }
                    }
                }
            }

        }

        // Room type comBox

        void populate_room_information()
        {
            using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }

                using (SqlCommand query = new SqlCommand("Select Distinct Room_type From Room", Connection))
                {
                    using (SqlDataReader x = query.ExecuteReader())
                    {
                        while (x.Read())
                        {
                            string room_type = x[0].ToString();
                          
                            string combined_data = $"{room_type}";
                            roomTypeBox.Items.Add(combined_data);
                        }
                    }
                }

                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }


        public reservation_page()
        {
            
            InitializeComponent();

            person = new User();
            person.name = "John";
            person.User_type = "Customer";
            person.id = 1;
            reservation_id = 0;
            update_reservation = false;

            Populate_hotel_combo_box();
            populate_room_information();

            fill_data_grid_view();

            

            if(person.User_type != "Employee")
            {
                Customer_Id_textbox.Visible = false;
                customerIDLabel.Visible = false;
            }

            cancelButton.Visible = false;
            
            // reservation object default values 
            res.startDate = startDatePicker.Value;
            res.endDate = endDatePicker.Value;
            res.hotel_id = 0;
            res.roomType = "";
            res.numGuests = 0;
            res.cardNum = "";
            res.Third_party_id = 0;
            reservationSearchID = "";
            res.connectionString = connectionString;


        }
        public reservation_page(User u)
        {

            InitializeComponent();

            person = u;
            reservation_id = 0;
            update_reservation = false;

            Populate_hotel_combo_box();
            populate_room_information();

            fill_data_grid_view();



            if (person.User_type != "Employee")
            {
                Customer_Id_textbox.Visible = false;
                customerIDLabel.Visible = false;
            }

            cancelButton.Visible = false;

            // reservation object default values 
            res.startDate = startDatePicker.Value;
            res.endDate = endDatePicker.Value;
            res.hotel_id = 0;
            res.roomType = "";
            res.numGuests = 0;
            res.cardNum = "";
            res.Third_party_id = 0;
            reservationSearchID = "";
            res.connectionString = connectionString;

            person = u; // passing user object from previous form

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            res.startDate = startDatePicker.Value.Date;
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            res.endDate = endDatePicker.Value.Date;
        }

        private void hotelLocationBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] getID = hotelLocationBox.Text.Split(' ');
            res.hotel_id = Convert.ToInt32( getID[0]);
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
            try { res.cardNum = creditCardNumberBox.Text; }
            catch (FormatException _e) { Console.WriteLine(_e.Message); }
        }

        private void submitUpdateButton_Click(object sender, EventArgs e)
        {

            if (update_reservation && person.User_type == "Employee")
            {

                
                if (startDatePicker.Value.Date > endDatePicker.Value.Date)
                {
                    MessageBox.Show("Error - Start Date later than End Date");
                }
                else
                {
                    try
                    {

                        res.DetermineAvailability();
                        res.Modify_reservation(reservation_id);

                        //***JOHN  Upgrade reservation
                        Logging logging = new Logging();
                        logging.upgradeLog(person);

                        fill_data_grid_view();
                        clear();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }


                }
            }
            else
            {
                if (startDatePicker.Value.Date > endDatePicker.Value.Date)
                {
                    MessageBox.Show("Error - Start Date later than End Date");
                }
                else
                {
                    try
                    {


                        //reward points dialogue box
                        //only show this if user has at least 50 reward points
                        res.DetermineAvailability();
                        var confirmRewards = MessageBox.Show("Would you like to use 50 reward points to get a 10% discount?", "Reward Points", MessageBoxButtons.YesNo);

                        string useRewards = ""; ;
                        useRewards = confirmRewards == DialogResult.Yes ? "Yes" : "No";

                        switch (person.User_type)
                        {
                            case "Customer":
                                res.book_reservation(useRewards, person.id, false, DateTime.Now.Date);
                                break;
                            default:
                                res.book_reservation(useRewards, customer_id_employee, false, DateTime.Now.Date);
                                break;
                        }//*****PlaceHolder NEED to come up with functionality to retrieve Customer ID if user is EMPLOYEE



                        //***JOHN Create reservation
                        Logging logging = new Logging();
                        logging.createResLog(person);

                        fill_data_grid_view();
                        clear();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //reset all fields. eventually this button will probably just return the user to the previous page though
            res.Cancel_Reservation(reservation_id);

            //***JOHN Cancel reservation
            Logging logging = new Logging();
            logging.cancelResLog(person);

            fill_data_grid_view();
            clear();


            
        }

        private void reservationIdBox_TextChanged(object sender, EventArgs e)
        {
            reservationSearchID = reservationIdBox.Text;
        }

        private void reservationSearchButton_Click(object sender, EventArgs e)
        {

            SqlConnection Connection = new SqlConnection(connectionString);
            DataTable dataTable1 = new DataTable();

            if(Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            try
            {
                if (person.User_type == "Employee" && reservationSearchID != "")
                {

                    SqlDataAdapter query = new SqlDataAdapter("Select * From Reservation Where Id =@resID", Connection);
                    query.SelectCommand.Parameters.AddWithValue("@resID", Convert.ToInt32(reservationSearchID));
                    query.Fill(dataTable1);
                    ReservationDataGridView.DataSource = dataTable1;

                }
                else if (person.User_type == "Employee" && reservationSearchID == "")
                {

                    SqlDataAdapter query = new SqlDataAdapter("Select * From Reservation", Connection);
                    query.Fill(dataTable1);
                    ReservationDataGridView.DataSource = dataTable1;
                }
                else if (person.User_type == "Customer" && reservationSearchID != "")
                {
                    SqlDataAdapter query = new SqlDataAdapter("Select * From Reservation Where Id =@resID AND Customer_Id = @CustomerID", Connection);
                    query.SelectCommand.Parameters.AddWithValue("@CustomerID", person.id);
                    query.SelectCommand.Parameters.AddWithValue("@resID", Convert.ToInt32(reservationSearchID));
                    query.Fill(dataTable1);
                    ReservationDataGridView.DataSource = dataTable1;
                }
                else
                {
                    SqlDataAdapter query = new SqlDataAdapter("Select * From Reservation", Connection);
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

        private void Customer_Id_textbox_TextChanged(object sender, EventArgs e)
        {
            if(Customer_Id_textbox.Text != string.Empty) { customer_id_employee = Convert.ToInt32(Customer_Id_textbox.Text); }
            
        }

        private void ReservationDataGridView_DoubleClick(object sender, EventArgs e)
        {

            // CHANGING UI
            if(person.User_type == "Customer")
            {
                submitUpdateButton.Visible = false;

            }
            else
            {
                submitUpdateButton.Text = "Update";
                update_reservation = true;

            }
            cancelButton.Visible = true;
            // CHANGING UI


            // Transferring Data from Data grid view to textbox
            if (ReservationDataGridView.CurrentRow.Index >= 0)
            {
                
                if(person.User_type == "Employee")
                {
                    Customer_Id_textbox.Text= ReservationDataGridView.CurrentRow.Cells[1].Value.ToString();
                }

                reservation_id = Convert.ToInt32(ReservationDataGridView.CurrentRow.Cells[0].Value);

                startDatePicker.Value = Convert.ToDateTime(ReservationDataGridView.CurrentRow.Cells[4].Value);
                endDatePicker.Value = Convert.ToDateTime(ReservationDataGridView.CurrentRow.Cells[5].Value);
                numberOfGuestsBox.Value = Convert.ToInt32(ReservationDataGridView.CurrentRow.Cells[3].Value);



                // get the hotel id
                int i = 0;
                foreach(var item in hotelLocationBox.Items)
                {
                    
                    string[] hotelId  = item.ToString().Split(' ');
                    if (Convert.ToInt32(hotelId[0]) == Convert.ToInt32(ReservationDataGridView.CurrentRow.Cells[6].Value))
                    {
                        
                        hotelLocationBox.Text = item.ToString();
                        break;
                    }
                    i++;
                }


                i = 0;
                foreach (var item in roomTypeBox.Items)
                {

                    
                    if (item.ToString() == ReservationDataGridView.CurrentRow.Cells[2].Value.ToString())
                    {
                      roomTypeBox.Text= item.ToString();
                        break;
                    }
                    i++;
                }






            }
            else
            {
                MessageBox.Show("Index out of range");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void reservation_page_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuReturn_Click(object sender, EventArgs e)
        {
            if(person.User_type == "Employee")
            {
                AccountManagementInterface.frmEmployeeMenu objEmployeeMenu = new AccountManagementInterface.frmEmployeeMenu(person);
                this.Hide();
                objEmployeeMenu.Show();
            }
            else
            {
                AccountManagementInterface.frmCustomerMenu objReturnCustomerMenu = new AccountManagementInterface.frmCustomerMenu(person);
                this.Hide();
                objReturnCustomerMenu.Show();
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
        public string cardNum { get; set; }

        public int Third_party_id { get; set; }

        public string connectionString { get; set; }
        

      
        public void DetermineAvailability()
        {
            SqlConnection Connection = new SqlConnection(connectionString);
            bool enough_rooms = true;

            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            for (var individual_date = startDate; individual_date <= endDate;  individual_date = individual_date.AddDays(1))
            {
                try
                {

                    
                    SqlCommand query = new SqlCommand("Select Count(*) From Reservation where Reservation_status NOT LIKE @Status AND @Current_Date Between Start_date and End_date AND Room_type = @roomType AND Hotel_location_Id = @HotelID", Connection);
                    query.Parameters.AddWithValue("@Status", "Cancelled%");
                    query.Parameters.AddWithValue("@Current_Date", individual_date.Date);
                    query.Parameters.AddWithValue("@roomType", roomType);
                    query.Parameters.AddWithValue("@HotelID", hotel_id);
                    int num_occupied = Convert.ToInt32(query.ExecuteScalar());

                    SqlCommand query2 = new SqlCommand("Select Count(*) From Maintenance LEFT JOIN Room ON Maintenance.Room_Id = Room.Id Where Room.Room_type = @RoomType AND Room.Hotel_id = @HotelID AND Maintenance.Date_maintenance = @Current_Date", Connection);
                    query2.Parameters.AddWithValue("@RoomType", roomType);
                    query2.Parameters.AddWithValue("@HotelID", hotel_id);
                    query2.Parameters.AddWithValue("@Current_Date", individual_date.Date);
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

        public void Modify_reservation(int reservation_id)
        {
            using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                Connection.Open();


                using(SqlCommand query = new SqlCommand("UPDATE Reservation SET Start_date = @Startdate, End_date=@Enddate, Hotel_location_Id = @hotelID, Room_type=@RoomType WHERE Id = @ResID", Connection))
                {
                    query.Parameters.AddWithValue("@Startdate", startDate);
                    query.Parameters.AddWithValue("@Enddate", endDate);
                    query.Parameters.AddWithValue("@hotelID", hotel_id);
                    query.Parameters.AddWithValue("@RoomType", roomType);
                    query.Parameters.AddWithValue("@ResID", reservation_id);
                    query.ExecuteNonQuery();

                    MessageBox.Show("Updates to Reservation Made!");


                }
            }
    

        }
        public void book_reservation(string result, int user_id, bool third_party, DateTime today, double deposit =0)
        {
            string sqlString = third_party && Third_party_id >= 0
                ? "Insert into Reservation(Customer_Id, Room_type, Num_guests, Start_date, End_date, Hotel_location_Id, Points_earned, Third_party_Id) OUTPUT Inserted.ID Values(@UserID,@RoomType,@NumGuests, @Startdate, @EndDate, @HotelID, @PointsEarned, @ThirdPartyID)"
                : "Insert into Reservation(Customer_Id, Room_type, Num_guests, Start_date, End_date, Hotel_location_Id, Points_earned) OUTPUT Inserted.ID Values(@UserID,@RoomType, @NumGuests, @Startdate, @EndDate, @HotelID, @PointsEarned)";

            // discount 1 =100%, 0.9 = 90% of the original
            double total_Room_Cost = 0,discount = 1;
            // get the number of nights 
            int date_difference = Convert.ToInt32((endDate.Date-startDate.Date).TotalDays);

            //25 points earned a night
            int total_points_earned = date_difference * 25;

            // check if user has enough points 
            bool enough_rewards = Check_rewards_enough(user_id);
            SqlConnection Connection = new SqlConnection(connectionString);

            // 10% of the original price  is total price *.9
            if (result == "Yes" && enough_rewards) { discount = 0.9; }
            

            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand query = new SqlCommand("Select distinct Monetary_cost from Room  where Room_type = @Type", Connection);
            query.Parameters.AddWithValue("@Type", roomType);
            total_Room_Cost = Convert.ToDouble(query.ExecuteScalar());

            SqlCommand query1 = new SqlCommand("Update Customer  SET Reward_Points=(Reward_Points + @NumPoints) Where Id = @CustomerId", Connection);
            query1.Parameters.AddWithValue("@NumPoints", (result == "Yes" && enough_rewards) ? total_points_earned - 50 : total_points_earned);
            query1.Parameters.AddWithValue("@CustomerId", user_id);
            query1.ExecuteNonQuery();


            // insert reservation information and return the reservation id to insert into transaction
            SqlCommand query2 = new SqlCommand(sqlString, Connection);
            query2.Parameters.AddWithValue("@UserID", user_id); 
            query2.Parameters.AddWithValue("@RoomType", roomType);
            query2.Parameters.AddWithValue("@NumGuests", numGuests);
            query2.Parameters.AddWithValue("@Startdate", startDate);
            query2.Parameters.AddWithValue("@EndDate", endDate);
            query2.Parameters.AddWithValue("@HotelID", hotel_id);
            query2.Parameters.AddWithValue("@PointsEarned", total_points_earned);
            if (third_party &&Third_party_id >=0) { query2.Parameters.AddWithValue("@ThirdPartyID", Third_party_id); }
            int reservation_id = Convert.ToInt32(query2.ExecuteScalar());


            SqlCommand query3 = new SqlCommand("Insert into Transactions (Reservation_Id, Customer_Id, Reward_points_spent, Money_spent, Activity_type, Reward_points_gained, Transaction_date) Values (@ReservationID, @CustomerID, @RewardsSpent, @MoneySpent, @ActivityType, @RewardsGained, @TransactionDate)", Connection);
            query3.Parameters.AddWithValue("@ReservationID", reservation_id);
            query3.Parameters.AddWithValue("@CustomerID", user_id);
            query3.Parameters.AddWithValue("@RewardsSpent", (result == "Yes" && enough_rewards) ? 50: 0);
            query3.Parameters.AddWithValue("@MoneySpent", third_party == false? total_Room_Cost *= discount: deposit); 
            query3.Parameters.AddWithValue("@ActivityType", "Creating Reservation");
            query3.Parameters.AddWithValue("@RewardsGained",total_points_earned);
            query3.Parameters.AddWithValue("@TransactionDate", today.Date);
            query3.ExecuteNonQuery();



            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }


        }

        public bool Check_rewards_enough(int user_id)
        {
            SqlConnection Connection = new SqlConnection(connectionString);
           
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


   


        public  void Cancel_Reservation(int reservation_id)
        {
            using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                Connection.Open();


                using (SqlCommand query = new SqlCommand("UPDATE Reservation SET Reservation_status = @Status WHERE Id = @ResID", Connection))
                {
                    query.Parameters.AddWithValue("@Status", "Cancelled");
                    query.Parameters.AddWithValue("@ResID", reservation_id);
                    query.ExecuteNonQuery();

                    MessageBox.Show("Reservation Cancelled");


                }
            }
           
        }
    }





}



