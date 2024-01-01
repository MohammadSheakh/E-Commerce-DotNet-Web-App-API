using DataAccessLayer.EF.Models.Seller.Profile;
using DataAccessLayer.Interface;
using DataAccessLayer.Interface.SellerProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.SellerRepo.Profile
{
    internal class SellerProfileRepo : Repo, IRepo<SellerProfile, int, SellerProfile>, ISellerProfile<SellerProfile>
    {
        // Repo Internal rakhte hobe 
        public SellerProfile Create(SellerProfile obj)
        {
            db.SellerProfiles.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var existing = Get(id);
            db.SellerProfiles.Remove(existing);
            return db.SaveChanges() > 0;
        }

        public List<SellerProfile> Get()
        {
            return db.SellerProfiles.ToList();
        }

        public SellerProfile Get(int id)
        {
            //return db.SellerProfiles.Find(id);
            return db.SellerProfiles.FirstOrDefault(u => u.Id == id);
        }

        public SellerProfile Update(SellerProfile obj)
        {
            var existing = Get(obj.Id);
            db.Entry(existing).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public SellerProfile UpdateShopProfileIdToNull(int userId)
        {
            var existing = Get(userId);
            existing.ShopProfileId = null;
            if (db.SaveChanges() > 0) return existing;
            return null;
        }
    }
}
