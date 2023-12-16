using DataAccessLayer.EF.Models.Seller.Profile.Reviews;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.SellerRepo
{
    internal class ReviewReplyRepo : Repo, IRepo<ReviewReply, int, ReviewReply> // Return bool korse sir 
    {
        public ReviewReply Create(ReviewReply obj)
        {
            db.ReviewReplies.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
            //throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var existing = Get(id);
            db.ReviewReplies.Remove(existing);
            return db.SaveChanges() > 0;
            // throw new NotImplementedException();
        }

        public List<ReviewReply> Get()
        {
            return db.ReviewReplies.ToList();
            //throw new NotImplementedException();
        }

        public ReviewReply Get(int id)
        {
            return db.ReviewReplies.Find(id);
            //throw new NotImplementedException();

        }

        public ReviewReply Update(ReviewReply obj)
        {
            var existing = Get(obj.id);
            db.Entry(existing).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

            //throw new NotImplementedException();

        }
    }
}
