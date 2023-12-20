using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Seller.Profile
{
    public class SellerProfile
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public string Image { get; set; }
        public string ShopName { get; set; }
        public string ShopDescription { get; set; }
        public string ShopLogo { get; set; }
        public string Status { get; set; }
        public int? Rating { get; set; }
        public string OfflineShopAddress { get; set; }
        public string GoogleMapLocation { get; set; }
        public DateTime? CreatedAt { get; set; }

        // UpdatedAt

        public int? SellerPhoneNumber { get; set; }
        public int? ShopPhoneNumber { get; set; }
        
    }
}
