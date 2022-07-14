using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ReadNews.service
{
    internal class AccountService
    {
        // Kiểm tra xem có tài khoản hay không, nếu có trả về true, không có trả về false
        public static bool getAccount(string email, string password)
        {
            email = email.Trim();
            password = password.Trim();
            email = email.ToUpper();
            beans.Account account = dao.AccountDao.getAccount(email, password);
            return dao.AccountDao.getAccount(email, password) != null ? true : false;
        }

        // Đăng ký tài khoản người dùng
        public static bool register(string email, string username, string password)
        {
            email = email.Trim();
            username = username.Trim();
            password = password.Trim();
            Console.WriteLine(validateAccount(email, username));
            if (validateAccount(email, username) == 0)
            {
                return dao.AccountDao.register(email, username, password);
            }
            return false;
        }


        // Kiểm tra tài khoản tồn tại,nếu không trùng trả về 0, nếu trùng email trả về 1, trùng username trả về 2, trùng cả 2 trả về 3
        public static int validateAccount(string email, string username)
        {
            ArrayList list = dao.AccountDao.listAccount();
            int result = 0;
            foreach (beans.Account account in list)
            {
                if (account.Email.ToUpper().Equals(email.ToUpper()))
                {
                    result += 1;
                }

                if (account.Username.ToUpper().Equals(username.ToUpper()))
                {
                    result += 2;
                }
                //Console.WriteLine(account.Username);
            }
            return result;
        }

        // Kiểm tra đăng ký đúng dạng email hay không, phần regex email, đúng dạng trả về true, sai trả về false
        public static bool validateEmail(string email)
        {
            email = email.Trim();
            string emailRegex = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([a-zA-Z]{2,3}){0,1}";
            return Regex.IsMatch(email, emailRegex);
        }

        // Kiểm tra tên đăng ký có đúng dạng hay không, không có ký tự đặc biệt và có đố dài từ 4-16 ký tự
        public static bool validateUsername(string username)
        {
            username = username.Trim();
            string regexUsername = "^[a-z0-9_-]{4,16}";
            return Regex.IsMatch(username, regexUsername);
        }

        // Kiểm tra mật khẩu có đúng dạng hay không, không chứa ký tự đặc biệt và độ dài trên 4 ký tự
        public static bool validatePassword(string password)
        {
            password = password.Trim();
            string regexPassword = "^[a-zA-Z0-9]{4,}";
            return Regex.IsMatch(password, regexPassword);
        }

        // Kiểm tra giá trị nhập vào có rỗng hoặc null hay không, nếu có trả về false, ngược lại trả về true(hợp lệ)
        public static bool validateInputEmty(string data)
        {
            if (data == null) return false;
            data = data.Trim();
            return !data.Equals("");
        }
    }
}
