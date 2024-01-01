using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.EF.Models.Product.Specifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Common.Product.Specifications
{
    public class SpecificationDTO
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int SpecificationCategory_Id { get; set; }

        // kon SpecificatonCategory er .. sheta print korte hobe

        //public virtual SpecificationCategory SpecificationCategory { get; set; }
    }
}
