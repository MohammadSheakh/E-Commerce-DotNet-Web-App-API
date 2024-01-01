using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.EF.Models.Common.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Product.Specifications
{
    public class SpecificationCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Kon Product er Specificaiton Category
        [ForeignKey("Product")]
        public int Products_Id { get; set; }

        public virtual Products Product{ get; set; }


        // One Specification Category has Many Specification
        public virtual ICollection<Specification> Specifications{ get; set; }

        public SpecificationCategory()
        {
            Specifications = new List<Specification>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
        }

        
    }
}
