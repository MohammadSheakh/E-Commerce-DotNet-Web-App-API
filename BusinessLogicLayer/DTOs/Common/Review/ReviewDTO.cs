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
        public int id { get; set; }

        //[Required] 
        public string category { get; set; }
       
        public string reviewDetails { get; set; }

        public DateTime? createdAt { get; set; }

        public int? likeCount { get; set; }

        public int? disLikeCount { get; set; }

        public string postedBy { get; set; }


    }
}
