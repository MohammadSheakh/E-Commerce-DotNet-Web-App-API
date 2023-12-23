

using DataAccessLayer.EF.Models;
using DataAccessLayer.EF.Models.Seller.Profile;
using DataAccessLayer.EF.Models.Seller.Shop;
using DataAccessLayer.EF.Models.UserModel;
using DataAccessLayer.Helper;
using DataAccessLayer.Interface;
using DataAccessLayer.Migrations;
using DataAccessLayer.Repos.SellerRepo.Profile;
using DataAccessLayer.Repos.SellerRepo.Profile.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.UserRepo
{
    internal class UserRepo : Repo, IRepo<User, int, User>, IAuth<bool>
    {
        public bool Authenticate(string email, string password)
        {
            var data = db.Users.FirstOrDefault(u => u.Email.Equals(email) && u.Password.Equals(password));
            if (data != null) return true;
            return false;
            // throw new NotImplementedException();
        }

        

        public User Create(User obj)
        {
            obj.CreatedAt = DateTime.Now.Date;
            //var res = GenericMethodForRepo.Create
            
            // it also create a profile .. based on
            // RoleId
            if(obj.RoleId == 1)
            {
                // taile sellerProfile Create korbo
                var sellerProfile = new SellerProfile();
                // ekta shop profile  create kore .. shetar
                // id assign korte hobe seller profile e 

                var shopProfile = new ShopProfile();

                //var guid = Guid.NewGuid();

                //byte[] bytes = guid.ToByteArray();
                //int intGuid = BitConverter.ToInt32(bytes, 0);

                //shopProfile.id = intGuid;

                shopProfile.Name = obj.Name+"'s Shop";
                //db.ShopProfiles.Add(shopProfile);
                // 🔴 Repo to create korsi .. 
                // so, repo ke call korbo 

                var shopRepo = new ShopRepo();
                var result =  shopRepo.Create(shopProfile);

                sellerProfile.ShopProfileId = result.id;

                //db.SellerProfiles.Add(sellerProfile);
                var sellerProfileRepo = new SellerProfileRepo();

                var createdSellerProfile =  sellerProfileRepo.Create(sellerProfile);

                obj.ProfileId = createdSellerProfile.Id;

                

            }
            else if (obj.RoleId == 2)
            {
                // taile buyerProfile create korbo 
                var buyerProfile = new BuyerProfile();
                db.BuyerProfiles.Add(buyerProfile);

            }
            else if(obj.RoleId == 3)
            {
                // taile admin profile create korbo
            }




            // 🏠 database e create houar pore ki jei 
            // id return korbe .. sheta diye ki assign kora jabe ?





            db.Users.Add(obj);

            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var existing = Get(id);
            db.Users.Remove(existing);
            return db.SaveChanges() > 0;
            // throw new NotImplementedException();
        }

        public List<User> Get()
        {
            return db.Users.ToList();
            //throw new NotImplementedException();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
            //throw new NotImplementedException();
        }

        public User Update(User obj)
        {
            var existing = Get(obj.Id);
            db.Entry(existing).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

            //throw new NotImplementedException();
        }
    }
}
