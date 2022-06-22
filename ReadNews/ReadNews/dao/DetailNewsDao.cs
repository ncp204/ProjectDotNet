using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ReadNews.dao
{
    internal class DetailNewsDao
    {
        public static ArrayList getListDetail()
        {
            ArrayList listNews = new ArrayList();
            MySqlConnection connection = dao.KetNoi.GetDBConnection();
            beans.DetailNews news = null;
            try
            {
                connection.Open();
                String sql = "Select * from detail";
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            news = new beans.DetailNews(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                            listNews.Add(news);
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Có lỗi sảy ra: " + e.Message);
            }
            return listNews;
        }
    }
}
