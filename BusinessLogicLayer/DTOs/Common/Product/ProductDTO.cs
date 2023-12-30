using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Product
{
    public class ProductDTO
    {
        [Required]
        public string Name { get; set; }
        public string Details { get; set; }
        // ProductImage ta add korte hobe 

        public int? Rating { get; set; }
        [Required]
        public int? Price { get; set; }
        [Required]
        public int? AvailableQuantity { get; set; }
        public int? LowestQuantityToStock { get; set; }
        [Required]
        public int? SellerId { get; set; }

        [Required]
        public int? BrandId { get; set; }

        [Required]
        public int? CategoryId { get; set; }

        
    }
}
