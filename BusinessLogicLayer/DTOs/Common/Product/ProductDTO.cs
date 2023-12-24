using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Product
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Details { get; set; }
        // ProductImage ta add korte hobe 

        public int? Rating { get; set; }
        public int? Price { get; set; }
        public int? AvailableQuantity { get; set; }
        public int? LowestQuantityToStock { get; set; }
        public int? SellerId { get; set; }

        public int? BrandId { get; set; }

        public int? CategoryId { get; set; }

        
    }
}
