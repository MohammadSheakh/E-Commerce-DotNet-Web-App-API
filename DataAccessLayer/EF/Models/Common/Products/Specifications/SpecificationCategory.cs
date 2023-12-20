using DataAccessLayer.EF.Models.Seller.Profile.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        // One Specification Category has Many Specification
        public virtual ICollection<Specification> Specifications{ get; set; }

        public SpecificationCategory()
        {
            Specifications = new List<Specification>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
        }

        
    }
}
