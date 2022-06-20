using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.beans
{
    internal class User
    {
        private String username;
        private String password;
        private String email;
        private String firstName;
        private String lastName;
        public User(string username, string password, string email, String firstName, String lastName)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public User()
        {

        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   username == user.username &&
                   password == user.password &&
                   email == user.email &&
                   firstName == user.firstName &&
                   lastName == user.lastName &&
                   Username == user.Username &&
                   Password == user.Password &&
                   Email == user.Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(username, password, email, firstName, lastName, Username, Password, Email);
        }
    }
}
