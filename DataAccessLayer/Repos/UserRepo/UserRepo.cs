

using DataAccessLayer.EF.Models;
using DataAccessLayer.EF.Models.Seller.Profile;
using DataAccessLayer.EF.Models.Seller.Shop;
using DataAccessLayer.EF.Models.UserModel;
using DataAccessLayer.Helper;
using DataAccessLayer.Interface;
using DataAccessLayer.Interface.User;
using DataAccessLayer.Migrations;
using DataAccessLayer.Repos.BuyerRepo.Profile;
using DataAccessLayer.Repos.SellerRepo.Profile;
using DataAccessLayer.Repos.SellerRepo.Profile.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos.UserRepo
{
    internal class UserRepo : Repo, IRepo<User, int, User>, IAuth<bool>, IUser<User>
    {

        public bool getUserByEmail(string senderEmail, string receiverEmail)
        {
           var user = db.Users.Where(u => u.Email.Equals(senderEmail) && u.Email.Equals(receiverEmail));
           if(user != null)
           {
                return true;
           }
            return false;
           // throw new NotImplementedException();
        }

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
            
            if(obj.RoleId == 1)
            {
                
                var sellerProfile = new SellerProfile();
                

                var shopProfile = new ShopProfile();

                shopProfile.Name = obj.Name+"'s Shop";
                
                var shopRepo = new ShopRepo();
                var result =  shopRepo.Create(shopProfile);

                sellerProfile.ShopProfileId = result.id;

                var sellerProfileRepo = new SellerProfileRepo();

                var createdSellerProfile =  sellerProfileRepo.Create(sellerProfile);

                obj.SellerProfileId = createdSellerProfile.Id;

                
                 
            }
            else if (obj.RoleId == 2)
            {
                // taile buyerProfile create korbo 
                var buyerProfile = new BuyerProfile();
                // db.BuyerProfiles.Add(buyerProfile);
                var BuyerProfileRepo = new BuyerProfileRepo();
                var createdBuyerProfile = BuyerProfileRepo.Create(buyerProfile);
                obj.BuyerProfileId = createdBuyerProfile.Id;
            }
            else if(obj.RoleId == 3)
            {
                // taile admin profile create korbo
            }




            db.Users.Add(obj);

            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            // var existingUser = Get(id);
            var existingUser = db.Users.Find(id);

            // 🔴 User account Remove korar age .. 
            // Profile Account Remove korte hobe 
            // Tar Age Seller Shop Profile Remove korte hobe 


            // 🔰 Age dekhte hobe Role ki .. Role Seller Hoile Seller Profile Delete
            // Role Buyer Hoile Buyer Profile Delete korte hobe .. 

            if (existingUser != null)
            {
                var sellerProfileRepo = new SellerProfileRepo();

               

                var existingProfileAccount = sellerProfileRepo.Get(existingUser.SellerProfileId ?? 0);

                var shopProfileRepo = new ShopRepo();
                //    var existingShopProfileAccount = shopProfileRepo.Get(existingProfileAccount.ShopProfileId);

                var existingShopProfileAccount =  db.ShopProfiles.FirstOrDefault(u => u.id == existingProfileAccount.ShopProfileId);

                if (existingShopProfileAccount != null && existingProfileAccount != null)
                {
                    // Remove the reference from the Users table
                    

                    db.ShopProfiles.Remove(existingShopProfileAccount);

                    db.SaveChanges();

                    db.SellerProfiles.Remove(existingProfileAccount);

                    //db.SaveChanges();

                    existingUser.SellerProfileId = null;

                    db.Users.Remove(existingUser);


                }

                

            }

            return db.SaveChanges() > 0;
            
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

        

        public User Update( User obj)
        {

            //var existing = Get(obj.Id);
            var id = Convert.ToInt32(obj.Id);
             var existing = db.Users.Find(id);
            //db.Entry(existing).CurrentValues.SetValues(obj);

            existing.Name = obj.Name;
            existing.Email = obj.Email;
            existing.Password = obj.Password;



            if (db.SaveChanges() > 0) return obj;
            return null;

            //throw new NotImplementedException();
        }
    }
}
