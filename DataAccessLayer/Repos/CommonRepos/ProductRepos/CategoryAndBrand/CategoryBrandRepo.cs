using DataAccessLayer.EF.Models;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.CommonRepos.ProductRepos
{
    internal class CategoryBrandRepo : Repo, IRepo<CategoryBrand, int, CategoryBrand>
    {
        public CategoryBrand Create(CategoryBrand obj)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryBrand> Get()
        {
            return db.CategoryBrand.ToList();
        }

        public CategoryBrand Get(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryBrand Update(CategoryBrand obj)
        {
            throw new NotImplementedException();
        }
    }
}
