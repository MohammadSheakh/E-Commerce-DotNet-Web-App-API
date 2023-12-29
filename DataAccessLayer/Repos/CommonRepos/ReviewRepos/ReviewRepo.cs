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
        public Review DoLikeDislikeToAReview(int ReviewId, int UserId, string likeDislikeStatusComingFromFE)
        {
            // check for like dislike status is already exist or not
            var data = db.LikeDisliikes.FirstOrDefault(a=> a.ReviewId == ReviewId && a.UserId == UserId);

            // review tao niye ashte hobe .. karon count manupulate korte hobe
            var review = db.Reviewes.FirstOrDefault(a => a.Id == ReviewId);

            if(data == null)
            {
                ////data does not exist .. 
                // create korte hobe .. 
                // lets create 
                var likeDislike = new LikeDislike
                {
                    Type = likeDislikeStatusComingFromFE,
                    UserId = UserId,
                    ReviewId = ReviewId
                };

                //ekhon review er like dislike count manupulate korte hobe

                if (likeDislikeStatusComingFromFE == "like")
                {
                    review.LikeCount = review.LikeCount + 1;
                    //db.Reviewes.Add(review);
                    // new review add hocche .. but amar to update korte hobe
                }
                else
                {
                    review.DisLikeCount = review.DisLikeCount + 1;
                    
                    //db.Reviewes.Add(review);
                    // new review add hocche .. but amar to update korte hobe
                }
                db.LikeDisliikes.Add(likeDislike);
                db.SaveChanges();
            }
            else
            {
                // like dislike kichu ekta kora ase .. 
                // dekhte hobe ki kora ase .. 

                var reactionFromDB = data.Type;
                if ((reactionFromDB == "like") && (likeDislikeStatusComingFromFE == "like"))
                {
                    
                        data.Type = "normal";
                       review.LikeCount = review.LikeCount - 1;
                }
                else if ((reactionFromDB == "dislike") && (likeDislikeStatusComingFromFE == "dislike"))
                {
                    
                        data.Type = "normal";
                      
                        review.DisLikeCount = review.DisLikeCount - 1;
                   
                }
                else if ((reactionFromDB == "normal") && (likeDislikeStatusComingFromFE == "like"))
                {
                        data.Type = "like";
                        review.LikeCount = review.LikeCount + 1;
                }
                else if ((reactionFromDB == "normal") && (likeDislikeStatusComingFromFE == "dislike"))
                {
                    data.Type = "dislike";
                    review.DisLikeCount = review.DisLikeCount + 1;
                }
                else if ((reactionFromDB == "like") && (likeDislikeStatusComingFromFE == "dislike"))
                {
                     data.Type = "dislike";
                  review.LikeCount = review.LikeCount - 1;
                    review.DisLikeCount = review.DisLikeCount + 1;
                 }
                else if ((reactionFromDB == "dislike") && (likeDislikeStatusComingFromFE == "like"))
                {
                    data.Type = "like";
                    
                    review.DisLikeCount = review.DisLikeCount - 1;
                    review.LikeCount = review.LikeCount + 1;
                }
                db.SaveChanges();
            }

            return review;
            //throw new NotImplementedException();
        }

        public LikeDislike GetLikeDislikeStatusForReviewIdAndSellerId(int ReviewId, int UserId)
        {
            var data = db.LikeDisliikes.FirstOrDefault(a => a.ReviewId == ReviewId && a.UserId == UserId);

            return data;
        }
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
            obj.LikeCount = 0;
            obj.DisLikeCount = 0;
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
