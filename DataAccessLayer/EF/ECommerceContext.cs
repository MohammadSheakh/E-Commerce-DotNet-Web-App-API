using DataAccessLayer.EF.Models;
using DataAccessLayer.EF.Models.UserModel;
using DataAccessLayer.EF.Models.Seller.Profile.Reviews;
using DataAccessLayer.EF.Models.University;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        // public DbSet<Seller> Sellers { get; set; } // Seller er jinish User er moddhe chole jabe
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<CategoryBrand> CategoryBrand { get; set; }
        //public DbSet<Category> Categories { get; set; }

        public DbSet<Brand> Brands { get; set; }

        // For University Practice -------------------------------------------
        public DbSet<News> News { get; set; }

        
        // For Seller -------------------------------------------
        public DbSet<Models.Seller.Profile.Reviews.Review> Reviewes { get; set; }

        public DbSet<Models.Seller.Profile.Reviews.ReviewReply> ReviewReplies { get; set; }

        public DbSet<User> Users { get; set; }

        // token rakhar jonno ekta table lagbe 
        public DbSet<Token> Tokens { get; set; }


    }
}
// 100 -> 145 taka

//100 taka -> 70 rupi ..
//1 taka  ->  70/100  ..

//145 taka -> 100 rupi .. 

