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
    public class ReviewReply
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string ReplyDetails { get; set; }

        public DateTime? CreatedAt { get; set; }

        [ForeignKey("User")]
        public int? PostedBy { get; set; } // kon user reply diyeche

        [ForeignKey("Review")]
        public int? ReviewId { get; set; } // kon review er reply

        public virtual User User { get; set; }

        public virtual Review Review { get; set;  }


    }
}
