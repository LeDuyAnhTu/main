using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BHX
{
    public class Account
    {
        //Fields
        private string _Username, _Password;

        //Constructor
        public Account(string username, string password)
        {
            _Username = username;
            _Password = password;
        }

        //Properties
        public string Username { get => _Username; set => _Username = value; }
        public string Password { get => _Password; set => _Password = value; }

        //Method
        public string toFile()
        {
            return Username + "#" + Password;
        }
    }
}
