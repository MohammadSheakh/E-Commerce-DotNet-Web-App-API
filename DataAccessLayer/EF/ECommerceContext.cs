﻿using DataAccessLayer.EF.Models;
using DataAccessLayer.EF.Models.UserModel;
using DataAccessLayer.EF.Models.Common.Reviews;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.EF.Models.Common;
using DataAccessLayer.EF.Models.Common.Products;
using DataAccessLayer.EF.Models.Common.Conversations;
using DataAccessLayer.EF.Models.Product.Specifications;
using DataAccessLayer.EF.Models.Seller.Profile;
using DataAccessLayer.EF.Models.Seller.Shop;
// using DataAccessLayer.EF.Models.Seller.Shop;
using System.Reflection.Emit;
using DataAccessLayer.EF.Models.Common.Orders;

namespace DataAccessLayer.EF
{
    // EF installation (1)
    // Model And Context Initiation... (1)
    // Connection string generate (1)

    // last step .. jeta project e ekbar korlei hobe .. ar korte hobe na 
    // Enabling migrations (1)
    /*
        > enable-migrations

        > add-migration  Create Database And Add Table (*) // migration add kora hoy and give name of that migration
        > update-database (*)
     */


    internal class ECommerceContext : DbContext // inheriting from
    {
        // internal ke public kore dite hobe 

        // eta amader database .. 
        // er moddhe amra table create korbo 

        // DbSet hishebe Context  e add na korle table create hobe na database e


        // For Common -------------------------------------------

        // -----------For Conversation --------------------------
        public DbSet<Conversation> Conversations{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        // ---------- For Orders --------------------------
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        // cart
        public DbSet<Cart> Carts { get; set; }
        // ---------- For Products --------------------------
        public DbSet<Products> Product { get; set; }
        public DbSet<CategoryBrand> CategoryBrand { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        // ---------------------- For Specifications ---------
        public DbSet<Specification> Specifications{ get; set; }
        public DbSet<SpecificationCategory> SpecificationCategories{ get; set; }

        // ---------- For Reviews --------------------------
        public DbSet<Models.Common.Reviews.Review> Reviewes { get; set; }
        public DbSet<Models.Common.Reviews.ReviewReply> ReviewReplies { get; set; }

        public DbSet<Models.Common.Reviews.LikeDislike> LikeDisliikes { get; set; }


        // For Buyer ----------------------------------------
        public DbSet<BuyerProfile> BuyerProfiles { get; set; }



        // For Seller -----------------------------------------
        // ---------For SellerProfile -----------------------------------------
        public DbSet<SellerProfile> SellerProfiles{ get; set; }

        public DbSet<ShopProfile> ShopProfiles { get; set; }


        // For UserModel --------------------------------------

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles{ get; set; }

        // token rakhar jonno ekta table lagbe 
        public DbSet<Token> Tokens { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SellerProfile>()
        //        .HasOne(s => s.ShopProfile)
        //        .WithOne(sp => sp.SellerProfile)
        //        .HasForeignKey<ShopProfile>(sp => sp.SellerProfileId);
        //}

    }
}


