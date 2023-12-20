using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Common.Review
{
    public class ReviewFF
    {
        public int Id { get; set; }


        // Value Can be 'General' , 'NegetiveReview', 'AfterSalesExperience' 
        public string Category { get; set; } // From ENUM

        public string Details { get; set; }
    }
}
