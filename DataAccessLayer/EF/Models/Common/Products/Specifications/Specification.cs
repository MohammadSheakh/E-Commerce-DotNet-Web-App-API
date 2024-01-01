using DataAccessLayer.EF.Models.Common.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models.Product.Specifications
{
    public class Specification
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }


        // Kon Specification Category er .. Specificaiton .. 

        [ForeignKey("SpecificationCategory")]
        public int SpecificationCategory_Id { get; set; }

        public virtual SpecificationCategory SpecificationCategory{ get; set; }
    }
}
