using DataAccessLayer.EF.Models.Common.Reviews;
using DataAccessLayer.EF.Models.Seller.Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string TotalQuantity { get; set; }

        public string TotalPrice { get; set; }

        [ForeignKey("SellerProfile")]
        public Nullable<int> SellerProfileId { get; set; } // One Order Has One SellerId // 🔴⚫🔰🔗🏠
        public virtual SellerProfile SellerProfile { get; set; }

        [ForeignKey("BuyerProfile")]
        public Nullable<int> BuyerProfileId { get; set; } // One Order has One buyer Id // 🔴⚫🔰🔗🏠
        
        public virtual BuyerProfile BuyerProfile { get; set; }






        // One Order Has Many Order Items
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
        }

    }
}
