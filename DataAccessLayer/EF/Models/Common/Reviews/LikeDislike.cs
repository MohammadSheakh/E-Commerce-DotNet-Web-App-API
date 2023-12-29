using DataAccessLayer.EF.Models.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Common.Reviews
{
    public class LikeDislike
    {
        public int Id { get; set; }

        // 'like' | 'dislike' | 'normal'
        public string Type { get; set; }

        // Many LikeDislike to One Review 


        [ForeignKey("Review")] // this is Many to One ... i mean Many like dislike to One Review
        public int? ReviewId { get; set; }
        /*
          eta hocche amar foreign key of review .. 
          so, amra ekta virtual nibo .. 
        */

        public virtual Review Review { get; set; }

        // Many LikeDislike to One User

        [ForeignKey("User")]
        public int? UserId { get; set; } // othoba eta ke ReactedBy o bola jay 
        /*
          eta hocche amar foreign key of user .. 
          so, amra ekta virtual nibo .. 
        */

        public virtual User User { get; set; }


    }
}
