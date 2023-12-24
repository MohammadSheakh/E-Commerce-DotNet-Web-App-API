using DataAccessLayer.EF.Models;
using DataAccessLayer.EF.Models.Seller.Profile;
using DataAccessLayer.EF.Models.Common.Reviews;

using DataAccessLayer.EF.Models.UserModel;
using DataAccessLayer.Interface;
using DataAccessLayer.Repos.BuyerRepo.Profile;
using DataAccessLayer.Repos.Seller;
using DataAccessLayer.Repos.SellerRepo;
using DataAccessLayer.Repos.SellerRepo.Profile;
using DataAccessLayer.Repos.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.Repos.CommonRepos.ProductRepos;

namespace DataAccessLayer
{
    /* <CLASS, IdDataType, ReturnDataType> */
    public class DataAccessFactory
    {
        /* <CLASS, IdDataType, ReturnDataType> */
        
        //----------------------------------- User ---------------

        public static IRepo<User, int, User> UserData()
        {
            return new UserRepo();
        }

        //----------------------------------- Seller ---------------

        public static IRepo<SellerProfile, int, SellerProfile> SellerProfileData()
        {
            return new SellerProfileRepo();
        }

        //----------------------------------- Buyer ---------------
        public static IRepo<BuyerProfile, int, BuyerProfile> BuyerProfileData()
        {
            return new BuyerProfileRepo();
        }

        //----------------------------------- Common ---------------
        //--------------------------------------------- Product---------------

        public static IRepo<Products, int, Products> ProductData()
        {
            return new ProductRepo();
        }
        //--------------------------------------------- Review---------------
        public static IRepo<Review, int, Review> ReviewData()
        {
            return new ReviewRepo();
        }

        public static IRepo<ReviewReply, int, ReviewReply> ReviewReplyData()
        {
            return new ReviewReplyRepo();
        }

        public static IAuth<bool> AuthData ()
        {
            return new UserRepo();
        }

        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }



        /* <CLASS, IdDataType, ReturnDataType> */
    }
}
