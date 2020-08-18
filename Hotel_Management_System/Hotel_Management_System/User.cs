using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class User
    {
        public string name { get; set; }
        public string User_type { get; set; }
        public int id { get; set; }
        

        public User()
        {

        }
        public User(string n, string ut, int i)
        {
            name = n;
            User_type = ut;
            id = i;
        }

        
    }
}
