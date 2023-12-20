using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Common.Review
{
    public class LikeDislike
    {
        public int Id { get; set; }

        // 'like' | 'dislike' | 'normal'
        public string type { get; set; }

    }
}
