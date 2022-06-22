using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
