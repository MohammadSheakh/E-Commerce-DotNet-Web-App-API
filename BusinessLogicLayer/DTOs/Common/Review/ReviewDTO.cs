//using DataAccessLayer.EF.Models.Seller.Profile.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.DTOs.Review
{
    public class ReviewDTO
    {
        // Required pore assign korbo 
        public int Id { get; set; }

        //[Required] 
        public string Category { get; set; }
       
        public string ReviewDetails { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? LikeCount { get; set; }

        public int? DisLikeCount { get; set; }

        public string PostedBy { get; set; }


    }
}
