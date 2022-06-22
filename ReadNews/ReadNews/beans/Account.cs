using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNews.beans
{
    internal class Account
    {
        private int id;
        private string email;
        private string username;
        private string password;

        public Account(int id, string email, string username, string password)
        {
            this.Id = id;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
