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
            db.Brands.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> Get()
        {
            return db.Brands.ToList();
        }

        public Brand Get(int id)
        {
            return db.Brands.Find(id);
        }

        public Brand Update(Brand obj)
        {
            throw new NotImplementedException();
        }
    }
}
