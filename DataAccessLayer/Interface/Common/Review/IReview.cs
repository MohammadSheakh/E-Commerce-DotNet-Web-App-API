using DataAccessLayer.EF.Models.Common.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface.Common.Review
{
    public interface IReview<CLASS>
    {
        
        List<CLASS> GetAllReviewsByShopProfileIdAndReviewCategory(int ShopProfileId, string ReviewCategory);
        List<CLASS> GetAllReviewsByProductIdAndReviewCategory(int ProductId, string ReviewCategory);

        CLASS DoLikeDislikeToAReview(int ReviewId, int SellerId, string LikeDislikeStatus);

        // not sure about return type 
        LikeDislike GetLikeDislikeStatusForReviewIdAndSellerId(int ReviewId, int SellerId);
    }
}
