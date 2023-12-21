using DataAccessLayer.EF.Models.Seller.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Seller.Shop
{
    public class ShopProfile
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
        public int? Rating { get; set; }
        public string OfflineShopAddress { get; set; }

        public string GoogleMapLocation { get; set; }

        public int? PhoneNumber { get; set; }


        // SellerProfileId is the foreign key on the ShopProfile side of the relationship
        // This is not necessary if you're using convention-based mapping
        //public int SellerProfileId { get; set; }
        //public virtual SellerProfile SellerProfile { get; set; }  // Navigation property
    }
}


