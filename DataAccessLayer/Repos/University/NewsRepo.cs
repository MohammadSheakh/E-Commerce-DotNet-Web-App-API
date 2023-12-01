using DataAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.University
{
    public class NewsRepo
    {
        public static EF.Models.University.News GetOneNews(int id)
        {
            //id person get
            var db = new ECommerceContext();
            return db.News.Find(id);
        }
        public static void CreateNews(EF.Models.University.News news)
        {
            //insert
            var db = new ECommerceContext();
            db.News.Add(news);
            db.SaveChanges();
        }
    }
}
