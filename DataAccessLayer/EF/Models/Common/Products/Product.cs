using DataAccessLayer.EF.Models.Product.Specifications;
using DataAccessLayer.EF.Models.Common.Reviews;
using DataAccessLayer.EF.Models.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Common.Products
{
    public class Products
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

        // kon seller er post kora product
        [ForeignKey("User")]
        public int? SellerId { get; set; }
        /*
         
          eta hocche amar foreign key of user .. 
          so, amra ekta virtual nibo .. 
        */

        public virtual User User { get; set; }


        // kon brand er product 
        [ForeignKey("Brand")]
        public int? BrandId {  get; set; }

        public virtual Brand Brand { get; set; }

        // Kon category er product
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public virtual Category Category{ get; set; }

        //-------------------------------------- One Product Has Many Specification Category
        public virtual ICollection<SpecificationCategory> SpecificationCategories{ get; set; }

        public Products()
        {
            SpecificationCategories = new List<SpecificationCategory>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
        }


       


        


        // Available Quality
    }
}

