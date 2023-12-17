﻿using DataAccessLayer.EF.Models.Seller.Profile.Reviews;
using DataAccessLayer.EF.Models.University;
using DataAccessLayer.EF.Models.UserModel;
using DataAccessLayer.Interface;
using DataAccessLayer.Repos.Seller;
using DataAccessLayer.Repos.SellerRepo;
using DataAccessLayer.Repos.University;
using DataAccessLayer.Repos.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /* <CLASS, IdDataType, ReturnDataType> */
    public class DataAccessFactory
    {
        /* <CLASS, IdDataType, ReturnDataType> */
        public static IRepo<News, int , bool>  NewsData()
        {
            return new NewsRepo();
        }

        public static IRepo<User, int, User> UserData()
        {
            return new UserRepo();
        }

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



        /* <CLASS, IdDataType, ReturnDataType> */
    }
}