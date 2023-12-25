using DataAccessLayer.EF.Models.Common.Reviews;
using DataAccessLayer.EF.Models.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Common.Reviews
{
    public class Review
    {
        // public korte hobe 
        // prop
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Category { get; set; }
        [Required]
        public string ReviewDetails { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? LikeCount { get; set; }

        public int? DisLikeCount { get; set; }

        // kon post er Review 
        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public virtual DataAccessLayer.EF.Models.Common.Products.Products Product{ get; set; }


        [ForeignKey("User")]
        public int? PostedBy { get; set; }
        /*
          eta hocche amar foreign key of user .. 
          so, amra ekta virtual nibo .. 
        */

        public virtual User User { get; set; }

        // One Review Can have many LikeDislike 
        public virtual ICollection<LikeDislike> LikeDislikes { get; set; }


        /*
         Review er under e multiple Reply thakte pare .. 
         */

        public virtual ICollection<ReviewReply> ReviewReplies { get; set; }

        public Review()
        {
            ReviewReplies =  new List<ReviewReply>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
            LikeDislikes = new List<LikeDislike>();
        }

    }
}
