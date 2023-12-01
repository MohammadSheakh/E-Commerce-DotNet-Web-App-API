using DataAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.University
{
    public class CategoryRepo
    {
        public static EF.Models.University.Category GetOneCategory(int id)
        {
            //id person get
            var db = new ECommerceContext();
            return db.Categories.Find(id);
        }

        public static void CreateCategory(EF.Models.University.Category category)
        {
            //insert
            var db = new ECommerceContext();
            db.Categories.Add(category);
            db.SaveChanges();
        }
    }
}
