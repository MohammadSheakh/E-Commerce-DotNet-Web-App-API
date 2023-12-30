using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Common.Review.LikeDislike
{
    public class LikeDislikeDTO
    {
        // not sure 
        public int Id { get; set; }
        // ei type tai amake extract korte hobe
        [Required]
        public string Type { get; set; }

        public int? ReviewId { get; set; }

        public int? UserId { get; set; }
    }
}
