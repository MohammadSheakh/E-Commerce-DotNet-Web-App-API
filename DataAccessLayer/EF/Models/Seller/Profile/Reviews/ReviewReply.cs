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
    public class ReviewReply
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public string replyDetails { get; set; }

        public DateTime? createdAt { get; set; }

        [ForeignKey("User")]
        public int? postedBy { get; set; } // kon user reply diyeche

        [ForeignKey("Review")]
        public int? reviewId { get; set; } // kon review er reply

        public virtual User User { get; set; }

        public virtual Review Review { get; set; }


    }
}
