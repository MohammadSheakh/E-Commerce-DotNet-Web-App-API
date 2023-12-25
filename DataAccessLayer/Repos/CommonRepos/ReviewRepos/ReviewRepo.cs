using DataAccessLayer.EF.Models.Common.Reviews;

using DataAccessLayer.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.Seller
{
    internal class ReviewRepo : Repo, IRepo<Review, int, Review>
    {
        public Review Create(Review obj)
        {
            db.Reviewes.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
            
        }

        public bool Delete(int id)
        {
            var existing = Get(id);
            db.Reviewes.Remove(existing);
            return db.SaveChanges() > 0;
            
        }

        public List<Review> Get()
        {
            return db.Reviewes.ToList();
            
        }

        public Review Get(int id)
        {
            return db.Reviewes.Find(id);
            
        }

        

        public Review Update(Review obj)
        {
            var existing = Get(obj.Id);
            db.Entry(existing).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
