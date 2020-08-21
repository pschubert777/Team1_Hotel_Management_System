using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    class Logging {

        private DateTime startDate, endDate, todayDate;
        private SqlConnection connection;

        public Logging()
        {
            
        }
        public Logging(DateTime start_date, DateTime end_date)
        {

            startDate = start_date;
            endDate = end_date;
        }

        public DataTable displayLogs(User user)
        {


            connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }


            SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM Logs" +
                                                    " WHERE User_id=" + user.id +
                                                    " AND User_type=\'" + user.User_type + "\'" +
                                                    " AND Action_date >=\'" + startDate + "\'" +
                                                    " AND Action_date <=\'" + endDate + "\'", connection);

            var table = new DataTable();
            query.Fill(table);

            



            using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter("Logging.txt"))
            {

                if (user.User_type.Equals("Customer"))
                    outputFile.WriteLine("ID: " + user.id + "\tName: " + user.name + "\tUser Type: Customer\n");
                else if (user.User_type.Equals("Employee"))
                    outputFile.WriteLine("ID: " + user.id + "\nName: " + user.name + "\nUser Type: Employee\n");

                outputFile.WriteLine(startDate + " - " + endDate + "\n");

                outputFile.WriteLine("Action Date\t\t\t\tAction");

                // go through each row
                foreach (DataRow dr in table.Rows)
                {
                    // go through each column in the row
                    for (int i = 2; i < table.Columns.Count; i++)
                    {

                        string str = dr[i].ToString();

                        outputFile.Write(str + "\t");

                        if (i == 4)
                        {
                            outputFile.Write("\n");
                        }

                        i++;
                    }
                }
            }

            
            connection.Close();

            return table;
        }   

        public void metricsLog (User user)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }
            
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'MC - Metrics Report Created\')";
            command.ExecuteNonQuery();

            connection.Close();
        }
        public void upgradeLog(User user)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'RU - Reservation upgraded\')";
            command.ExecuteNonQuery();

            connection.Close();
        }
        public void createResLog(User user)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'RC - Reservation created\')";
            command.ExecuteNonQuery();

            connection.Close();
        }
        public void createThirdPartyResLog(User user)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'RT - Third party reservation created\')";
            command.ExecuteNonQuery();

            connection.Close();
        }
        public void cancelResLog(User user)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'RD - Reservation cancelled\')";
            command.ExecuteNonQuery();

            connection.Close();
        }
        public void createAccountLog(User user)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            if (user.User_type.Equals("Customer"))
                command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'CC - Customer created\')";
            else
                command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'EC - Employee created\')";

            command.ExecuteNonQuery();

            connection.Close();
        }
        public void loginLog(User user)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            if (user.User_type.Equals("Customer"))
                command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'CL - Customer logged in\')";
            else
                command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'EL - Employee logged in\')";

            command.ExecuteNonQuery();

            connection.Close();
        }
        public void checkInLog(User user)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

                command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'CI - Customer checked in\')";
          
            command.ExecuteNonQuery();

            connection.Close();
        }
        public void checkOutLog(User user)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

                command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                    + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'CO - Customer checked out\')";
            command.ExecuteNonQuery();

            connection.Close();
        }
        public void roomLog(User user, decimal room, string status)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Logs (User_id, Action_date, User_type, Action_type) VALUES ("
                                                + user.id + ", \'" + DateTime.Today + "\', \'" + user.User_type + "\', \'RM - Room " + room.ToString() + " " + status + "\')";
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}

