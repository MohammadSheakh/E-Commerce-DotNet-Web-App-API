using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.Interface.Common.Product;

namespace DataAccessLayer.Repos.CommonRepos.ProductRepos
{
    internal class ProductRepo : Repo, IRepo<Products, int, Products>  ,IProduct<Products>// IProduct<Products>,
    {
        public List<Products> GetAllProductsDetailsBySellerId(int sellerId)
        {

            var products = db.Product.Where(p => p.SellerId == sellerId).ToList();
            return products;
            //throw new NotImplementedException();
        }

        public Products Create(Products obj)
        {
            db.Product.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var existing = Get(id);
            db.Product.Remove(existing);
            return db.SaveChanges() > 0;
        }

        public List<Products> Get()
        {
            return db.Product.ToList();
        }

        public Products Get(int id)
        {
            return db.Product.Find(id);
        }

       

        
        public Products Update(Products obj)
        {
            var existing = Get(obj.Id);
            db.Entry(existing).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

       

        
    }
}
