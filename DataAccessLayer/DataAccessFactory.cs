using DataAccessLayer.EF.Models.University;
using DataAccessLayer.Interface;
using DataAccessLayer.Repos.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccessFactory
    {
        public static IRepo<News, int , bool> /* CLASS, IdDataType, ReturnDataType */ NewsData()
        {
            return new NewsRepo();
        }

        
    }
}
