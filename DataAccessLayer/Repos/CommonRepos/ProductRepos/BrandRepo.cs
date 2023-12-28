using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.CommonRepos.ProductRepos
{
    internal class BrandRepo : Repo, IRepo<Brand, int, Brand>
    {
        public Brand Create(Brand obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> Get()
        {
            throw new NotImplementedException();
        }

        public Brand Get(int id)
        {
            throw new NotImplementedException();
        }

        public Brand Update(Brand obj)
        {
            throw new NotImplementedException();
        }
    }
}
