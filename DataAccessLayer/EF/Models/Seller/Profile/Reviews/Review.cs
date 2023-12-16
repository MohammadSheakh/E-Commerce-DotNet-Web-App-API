using DataAccessLayer.EF.Models.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Seller.Profile.Reviews
{
    public class Review
    {
        // public korte hobe 
        // prop
        public int id { get; set; }

        [Required]
        public string category { get; set; }
        [Required]
        public string reviewDetails { get; set; }

        public DateTime? createdAt { get; set; }

        public int? likeCount { get; set; }

        public int? disLikeCount { get; set; }


        [ForeignKey("User")]
        public string postedBy { get; set; }
        /*
          eta hocche amar foreign key of user .. 
          so, amra ekta virtual nibo .. 
        */

        public virtual User User { get; set; }


        /*
         Review er under e multiple Reply thakte pare .. 
         */

        public virtual ICollection<ReviewReply> ReviewReplies { get; set; }

        public Review()
        {
            ReviewReplies =  new List<ReviewReply>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
        }

    }
}
