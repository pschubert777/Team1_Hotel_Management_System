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

        public Logging(DateTime start_date, DateTime end_date)
        {

            startDate = start_date;
            endDate = end_date;
        }
        public DataTable displayLogs() {

            connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Hotel_Entity_Relationship_System;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (connection.State == System.Data.ConnectionState.Closed) {

                connection.Open();
            }


            SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM Logs", connection);

            var table = new DataTable();
            query.Fill(table);

            connection.Close();

            return table;
           
        }
    }
}
