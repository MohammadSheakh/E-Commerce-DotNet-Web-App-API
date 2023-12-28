using DataAccessLayer.EF.Models.Common.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class CategoryBrand
    {
        public int Id { get; set; }

        // Brand ar Category er Collection rakhbo 

        //public virtual ICollection<Brand> Brands { get; set; }
        //public virtual ICollection<Category> Categories { get; set; }

        //// jehetu collection .. so constructor er moddhe initialize korte hobe
        //public CategoryBrand() { 
        //    Brands = new List<Brand>();
        //    Categories = new List<Category>();
        //}

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category{ get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

    }
}
