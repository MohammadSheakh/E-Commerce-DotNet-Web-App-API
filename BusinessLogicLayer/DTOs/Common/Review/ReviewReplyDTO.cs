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
        public string ReplyDetails { get; set; }

        public DateTime? CreatedAt { get; set; }

        
        public string PostedBy { get; set; } // kon user reply diyeche

        
        public int ReviewId { get; set; } // kon review er reply

       


    }
}
