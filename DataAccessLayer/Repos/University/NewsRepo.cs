using DataAccessLayer.EF;
using DataAccessLayer.EF.Models.University;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.University
{
    internal class NewsRepo: Repo, IRepo<News, int, bool> /* CLASS, IdDataType, ReturnDataType */
    {
        //public static EF.Models.University.News GetOneNews(int id)
        //{
        //    //id person get
        //    var db = new ECommerceContext();
        //    return db.News.Find(id);
        //}
        //public static void CreateNews(EF.Models.University.News news)
        //{
        //    //insert
        //    var db = new ECommerceContext();
        //    db.News.Add(news);
        //    db.SaveChanges();
        //}

        public News GetOneNews(int id)
        {
            //id person get

            return db.News.Find(id);
        }
        public bool CreateNews(EF.Models.University.News news)
        {
            //insert
            db.News.Add(news);

            return db.SaveChanges() > 0;
        }

        public List<News> Get()
        {
            throw new NotImplementedException();
        }

        public News Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create(News obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(News obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }




        ////////////////////////////////////////////
        ////////////////////////////////////////////
        ////////////////////////////////////////////
        ////////////////////////////////////////////





        //public static News GetOneNews(int id)
        //{
        //    //id person get

        //    return db.News.Find(id);
        //}
        //public static bool CreateNews(EF.Models.University.News news)
        //{
        //    //insert
        //    db.News.Add(news);

        //    return db.SaveChanges() > 0;
        //}


    }
}
