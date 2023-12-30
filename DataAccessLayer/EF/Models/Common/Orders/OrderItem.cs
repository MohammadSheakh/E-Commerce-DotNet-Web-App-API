using DataAccessLayer.EF.Models.Common.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class OrderItem
    {
        /// Cart kei OrderItem hishebe  chinta kora jete pare kina .. 
        public int Id { get; set; }

        public int? Quantity { get; set; }

        public int? UnitPrice { get; set; }


        ////////////////////////////////////// Many OrderItem to One Order
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public virtual Order Order { get; set; }


        /////////////////////////////////////// Many OrderItem to One Product
        
        [ForeignKey("Product")]        
        public int? ProductId { get; set; }

        public virtual Products Product {  get; set; }
    }
}
