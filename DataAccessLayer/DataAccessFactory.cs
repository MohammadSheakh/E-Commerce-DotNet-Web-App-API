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
using DataAccessLayer.Interface.Common.Product;
using DataAccessLayer.Repos.CommonRepos.ConversationRepos;
using DataAccessLayer.EF.Models.Common.Conversations;
using System.Runtime.Remoting.Messaging;
using DataAccessLayer.Interface.Common.Conversation;
using DataAccessLayer.Interface.Common.Review;
using DataAccessLayer.EF.Models.Common.Orders;
using DataAccessLayer.Repos.CommonRepos.OrderRepos;
using DataAccessLayer.Interface.Common.Order;
using DataAccessLayer.Repos.SellerRepo.Profile.Shop;
using DataAccessLayer.EF.Models.Seller.Shop;
using DataAccessLayer.Interface.SellerProfile;
using DataAccessLayer.Interface.User;
using DataAccessLayer.Interface.Common.Product.Specificaiton;
using DataAccessLayer.EF.Models.Product.Specifications;

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

        public static IUser<User> IUserData()
        {
            return new UserRepo();
        }

        //----------------------------------- Seller ---------------

        public static IRepo<SellerProfile, int, SellerProfile> SellerProfileData()
        {
            return new SellerProfileRepo();
        }

        public static ISellerProfile<SellerProfile> ISellerProfileData()
        {
            return new SellerProfileRepo();
        }
        //------------------------------------------- Shop ---------------
        public static IRepo<ShopProfile, int, ShopProfile> ShopData()
        {
            return new ShopRepo();
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

        public static IProduct<Products> IProductData()
        {
            return new ProductRepo();
        }
        public static ISpecificationCategory<SpecificationCategory, Specification> IProductSpecificationData()
        {
            return new ProductRepo();
        }


        //----------------------------------------- Category Brand -----------------
        public static IRepo<Category, int , Category> CategoryData()
        {
            return new CategoryRepo();
        }
        
        public static IRepo<Brand, int, Brand> BrandData()
        {
            return new BrandRepo();
        }
        public static IRepo<CategoryBrand, int, CategoryBrand> CategoryAndBrandData()
        {
            return new CategoryBrandRepo();
        }
        //--------------------------------------------- Review---------------
        public static IRepo<Review, int, Review> ReviewData()
        {
            return new ReviewRepo();
        }
        public static IReview<Review> IReviewData()
        {
            return new ReviewRepo();
        }

        
        public static IRepo<ReviewReply, int, ReviewReply> ReviewReplyData()
        {
            return new ReviewReplyRepo();
        }

        // ------------------------------------------ cart 
        public static ICart<Cart, int> CartData()
        {
            return new CartRepo();
        }



        //--------------------------------------------- Conversation---------------
        public static IRepo<Conversation, int, Conversation> ConversationData()
        {
            return new ConversationRepo();
        }

        public static IConversation<Conversation> IConversationData()
        {
            return new ConversationRepo();
        }

        public static IRepo<Message, int, Message> MessageData()
        {
            return new MessageRepo();
        }
        public static IMessage<Message> IMessageData()
        {
            return new MessageRepo();
        }

        

        //-----Auth-------------------------------------------------------
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
