using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNews.service
{
    internal class DetailService
    {
        public static ArrayList getListNews()
        {
            return dao.DetailNewsDao.getListDetail();
        }
    }
}
