using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Review
{
    public  class ReviewReplyDTO
    {
        // public int id { get; set; }

        //[Required]
        public string replyDetails { get; set; }

        public DateTime? createdAt { get; set; }

        
        public string postedBy { get; set; } // kon user reply diyeche

        
        public int reviewId { get; set; } // kon review er reply

       


    }
}
