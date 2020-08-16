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


            connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

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

                if (user.User_type.Equals("C"))
                    outputFile.WriteLine("ID: " + user.id + "\tName: " + user.name + "\tUser Type: Customer\n");
                else if (user.User_type.Equals("E"))
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
    }
}

