using BusinessLogicLayer.DTOs.Review;
using DataAccessLayer.EF.Models.Common.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Common.Review
{
    public class Review__ReviewReplyDTO
    {
        // Review
        #region 
        public int Id { get; set; }

        public string Category { get; set; }

        public string ReviewDetails { get; set; }

        public DateTime? CreatedAt { get; set; } 

        public int? ProductId { get; set; }

        //public int? ShopProfileId { get; set; }
        public int PostedBy { get; set; }

        public int LikeCount { get; set; }

        public int DisLikeCount { get; set; }
        #endregion

        // Review Reply
        #region
        //////////////////////////public virtual ReviewReply ReviewReply { get; set; }
        //public virtual List<ReviewReplyDTO> ReviewReplies { get; set; }

        public virtual ReviewReplyDTO ReviewReplies { get; set; }

        //public Review__ReviewReplyDTO()
        //{
        //    ReviewReplies = new List<ReviewReplyDTO>();
        //}
        #endregion
    }
}
