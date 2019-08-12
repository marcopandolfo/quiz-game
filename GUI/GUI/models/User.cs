using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.models
{
    public class User
    {
        public Nullable<int> id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }
    }
}
