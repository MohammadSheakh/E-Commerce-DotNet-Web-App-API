using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.EF.Models.Common.Reviews;

using DataAccessLayer.Interface;
using DataAccessLayer.Interface.Common.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.Seller
{
    internal class ReviewRepo : Repo, IRepo<Review, int, Review>, IReview<Review>
    {
        public List<Review> GetAllReviewsByProductIdAndReviewCategory(int ProductId, string ReviewCategory)
        {
            var reviews = db.Reviewes.Where(e => e.ProductId == ProductId && e.Category == ReviewCategory).ToList();

            return reviews;
            
        }
       
        public List<Review> GetAllReviewsByShopProfileIdAndReviewCategory(int ShopProfileId, string ReviewCategory)
        {
            var reviews = db.Reviewes.Where(e => e.ShopProfileId == ShopProfileId && e.Category == ReviewCategory).ToList(); // ToList();

            return reviews;

        }
        public Review Create(Review obj)
        {
            obj.CreatedAt = DateTime.Now;

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

        public Review Get(int ReviewId)
        {
            return db.Reviewes.Find(ReviewId);
            
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
