using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.EF.Models.Seller.Shop;
// using DataAccessLayer.EF.Models.Seller.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Seller.Profile
{
    public class SellerProfile
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
         

        [ForeignKey("ShopProfile")]
        public int ShopProfileId { get; set; }  // Foreign key
        
        public virtual ShopProfile ShopProfile { get; set; }  // Navigation property


        public virtual ICollection<Products> Products { get; set; }
        // Collection amader ke initialize korte hoy 

        // One Seller can have Many Order
        public virtual ICollection<Order> Orders { get; set; }


        public SellerProfile() { 
            Products = new List<Products>();
            Orders = new List<Order>();
        }
    }
}
