using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ReadNews.dao
{
    internal class CauHinh
    {
        public static MySqlConnection getDBConnection(string localhost, int port, string database, string username, string password)
        {
            String connString = "Server=" + localhost + ";Database=" + database + ";User=" + username

                + ";Port=" + port + ";Password=" + password + ";SSL Mode = None";

            MySqlConnection connecttion = new MySqlConnection(connString);

            return connecttion;
        }
    }
}
