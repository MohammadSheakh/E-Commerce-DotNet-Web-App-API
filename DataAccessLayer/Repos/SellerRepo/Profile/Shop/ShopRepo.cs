using DataAccessLayer.EF.Models.Seller.Shop;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.SellerRepo.Profile.Shop
{
    internal class ShopRepo : Repo, IRepo<ShopProfile, int, ShopProfile>
    {
        public ShopProfile Create(ShopProfile obj)
        {
            db.ShopProfiles.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
            //throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var existing = Get(id);
            db.ShopProfiles.Remove(existing);
            return db.SaveChanges() > 0;
        }

        public List<ShopProfile> Get()
        {
            throw new NotImplementedException();
        }

        public ShopProfile Get(int id)
        {
            
            var existingShop = db.ShopProfiles.FirstOrDefault(u => u.id == id);
            if(existingShop != null)
            {
                return existingShop;
            }
            return null;
        }

        public ShopProfile Update(ShopProfile obj)
        {
            throw new NotImplementedException();
        }
    }
}
