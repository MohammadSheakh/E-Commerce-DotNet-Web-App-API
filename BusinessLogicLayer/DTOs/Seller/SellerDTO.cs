using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Seller
{
    public class SellerDTO
    {
        // public korte hobe internal ke 
        
        public int Id { get; set; } // auto increment // unique
        //[StringLength(35)]
        //[Req]
        public string name { get; set; }

        public int? rating { get; set; } // intiger normally null accept kore na .. 
        // amra nullable kore dilam 
    }
}
