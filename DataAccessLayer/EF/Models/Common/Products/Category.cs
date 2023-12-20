﻿using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.EF.Models.Seller.Profile.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<EF.Models.Common.Products.Products> Products { get; set; }
        public Category()
        {
            Products = new List<EF.Models.Common.Products.Products>(); // initiate kore dite hobe .. 
            // jehetu list .. na hole may be null assign hoye thakbe 
        }
    }
}