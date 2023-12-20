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

        // public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}
