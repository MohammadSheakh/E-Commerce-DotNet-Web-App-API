using DataAccessLayer.EF.Models;
using DataAccessLayer.EF.Models.Common.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Common.Product.Specifications
{
    public class SpecificaitonCategoryDTO
    {
        public string Name { get; set; }

        public int Products_Id { get; set; }

        // this is for view
        //public virtual Products Product { get; set; }
    }
}
