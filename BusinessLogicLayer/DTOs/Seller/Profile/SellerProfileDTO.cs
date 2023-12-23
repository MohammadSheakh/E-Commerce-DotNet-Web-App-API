using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Seller.Profile
{
    public class SellerProfileDTO
    {
        // DTO te ki Id rakha jay ? 🏠 
        public int Id { get; set; }

        public string Description { get; set; }
        public string Image { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? PhoneNumber { get; set; }
    }
}
