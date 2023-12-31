using DataAccessLayer.EF.Models;
using DataAccessLayer.EF.Models.Common.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Common.Order
{
    public class CartViewDto
    {
        public int Id { get; set; }
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int BuyerProfileId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


        public virtual BuyerProfile BuyerProfile { get; set; }
        public virtual Products Product { get; set; }
    }
}
