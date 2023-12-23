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
            throw new NotImplementedException();
        }

        public List<ShopProfile> Get()
        {
            throw new NotImplementedException();
        }

        public ShopProfile Get(int id)
        {
            throw new NotImplementedException();
        }

        public ShopProfile Update(ShopProfile obj)
        {
            throw new NotImplementedException();
        }
    }
}
