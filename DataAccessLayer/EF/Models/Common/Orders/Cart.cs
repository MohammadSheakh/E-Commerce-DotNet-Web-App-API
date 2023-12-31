using DataAccessLayer.EF.Models.Seller.Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Common.Orders
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CartId { get; set; }
        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public virtual EF.Models.Common.Products.Products Product { get; set; }

        [ForeignKey("BuyerProfile")]
        public int? BuyerProfileId { get; set; }
        public virtual BuyerProfile BuyerProfile { get; set; }

        public int Quantity { get; set; }
  
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
