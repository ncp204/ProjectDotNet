using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.beans;

namespace Source.services
{
    internal class LoginService
    {
        public static User? checkLogin(String email, String password)
        {
            if (email.Equals("admin@gmail.com") && password.Equals("123"))
            {
                return new User("admin", "123", "admin@gmail.com", "firstName admin", "lastname admin");
            }
            else
            {
                return null;
            }
        }
    }
}
