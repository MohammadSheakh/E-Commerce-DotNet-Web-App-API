using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.DTOs.Common.Order
{
    public class CratCreateDto
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int BuyerProfileId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
