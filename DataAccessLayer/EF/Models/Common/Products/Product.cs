using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class Product
    {
        [Key]
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Details { get; set; }

        public string ProductImage { get; set; }

        public int ? Rating { get; set; }

        [Required]
        public int? Price { get; set; }
        public int? AvailableQuantity { get; set; }
        public int? LowestQuantityToStock { get; set; }
        
        // Available Quality
    }
}

