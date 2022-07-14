using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ReadNews.dao
{
    internal class KetNoi
    {
        public static MySqlConnection GetDBConnection()
        {
            string localhost = "localhost";
            int port = 3306;
            string database = "readnews";
            string username = "root";
            string password = "";

            return CauHinh.getDBConnection(localhost, port, database, username, password);
        }
    }
}
