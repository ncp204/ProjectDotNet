using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Collections;

namespace ReadNews.dao
{
    internal class AccountDao
    {
        // Đăng ký tài khoản
        public static bool register(string email, string username, string password)
        {
            MySqlConnection connection = dao.KetNoi.GetDBConnection();
            try
            {
                connection.Open();
                string sql = "INSERT INTO ACCOUNT(EMAIL, USERNAME, PASSWORD) VALUES(@email, @username, @password)";
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                return command.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Có lỗi sảy ra: " + e.Message);
                return false;
            }
        }

        // kiểm tra tài khoản đăng nhập
        public static beans.Account getAccount(string email, string password)
        {
            ArrayList list = listAccount();
            beans.Account acc = null;
            foreach (beans.Account account in list)
            {
                if (account.Email.ToUpper().Equals(email) && account.Password.Equals(password))
                {
                    return account;
                }
            }
            return acc;
        }

        // lấy danh sách tài khoản
        public static ArrayList listAccount()
        {
            ArrayList accounts = new ArrayList();
            beans.Account account = null;
            MySqlConnection connection = dao.KetNoi.GetDBConnection();
            try
            {
                connection.Open();
                string sql = "Select * from account";
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            account = new beans.Account(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                            accounts.Add(account);
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Có lỗi sảy ra: " + e.Message);
            }
            return accounts;
        }
    }
}
