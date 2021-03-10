using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class Login
    {
        private string username;
        private string password;

        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
