using DataAccessLayer.EF.Models.Seller.Profile.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string totalQuantity { get; set; }

        public string totalPrice { get; set; }

        // public Nullable<int> sellerId { get; set; }

        // public Nullable<int> buyerId { get; set; }


        // One Order Has One SellerId // 🔴⚫🔰🔗🏠
        // One Order has One buyer Id // 🔴⚫🔰🔗🏠

        // One Order Has Many Order Items
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
        }

    }
}
