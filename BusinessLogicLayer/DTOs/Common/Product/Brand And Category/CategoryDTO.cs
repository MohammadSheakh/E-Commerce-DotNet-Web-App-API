using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Common.Product.Brand_And_Category
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
