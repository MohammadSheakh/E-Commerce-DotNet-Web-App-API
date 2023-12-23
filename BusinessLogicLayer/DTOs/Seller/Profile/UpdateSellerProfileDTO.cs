using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Seller.Profile
{
    public class UpdateSellerProfileDTO
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public int? PhoneNumber { get; set; }
    }
}

