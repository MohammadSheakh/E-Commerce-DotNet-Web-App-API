using DataAccessLayer.EF.Models.Common.Reviews;
using System.Reflection;
using System.Xml.Linq;
using System;

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.EF.ECommerceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        //  This method will be called after migrating to the latest version.
        //  You can use the DbSet<T>.AddOrUpdate() helper extension method
        protected override void Seed(DataAccessLayer.EF.ECommerceContext context)
        {
            //  ekhon amra chaile data seed korte pari .. 

            // Category  Added
            //for (int i = 1; i <= 4; i++)
            //{
            //    context.Categories.AddOrUpdate(new EF.Models.Common.Products.Category
            //    {
            //        Name = "Category-" + i,
            //    });
            //    // user add done .. 
            //}

            //Name = Guid.NewGuid().ToString().Substring(0, 15),
            //Password = Guid.NewGuid().ToString().SubString(0, 10),
            //Type = "General", // pore ekjon ke admin banay dibo 


            //// Brand  Added
            //for (int i = 1; i <= 4; i++)
            //{
            //    context.Brands.AddOrUpdate(new EF.Models.Common.Products.Brand
            //    {

            //        Name = "Brand-" + i,
            //    });

            //}

            //// Role Added
            //string[] roleNames = { "Seller", "Buyer", "Admin" };
            //foreach (var roleName in roleNames)
            //{
            //    context.Roles.AddOrUpdate(new EF.Models.UserModel.Role
            //    {
            //        name = roleName,
            //    });
            //}

            // Product Added=============================

            //Name: Tp Link 445
            //Details: amezing router
            //Rating: 0
            //Price: 50
            //availableQuantity: 3
            //lowestQuantityToStock: 3
            //CategoryId: 1
            //BrandId: 1
            //SellerId: 6


            // Seler Added=============================

            //Name: sheakhBuyer
            //Email:d @gmail.com
            //Password:1234
            //RoleId: 1




            ///////////////////////////////////////////////////
            //////////////////////////////////////////////////
            /////////////////////////////////////////////////////
            //////////////////////////////////////////////////
            /////////////////////////////////////////////////////
            /////////////////////////////////////////////////////
            /////////////////////////////////////////////////////

            // ekhon kichu post add korbo 

            //  Random random = new Random();

            //  for (int i = 1; i <= 10; i++)
            //  {

            //      context.Reviews.AddOrUpdate(new Models.Reviews){
            //          Id = i,
            // Details = Guid.NewGuid().ToString().Substring(0, 5),
            // CreatedAt = DateTime.Now,
            // PostedBy = "User-" + random.Next(1, 11),  // 1 theke 10 er moddhe select hobe randomly 

            //}

            //  }

            // ekhon kichu review er reply add korbo 

            //   for (int i = 1; i <= 10; i++)
            //   {

            //       context.ReviewReplies.AddOrUpdate(new Models.ReviewReplies){
            //           Id = i,
            //Details = Guid.NewGuid().ToString().Substring(0, 5),
            //CreatedAt = DateTime.Now + random.Next(0, 10),
            //PostedBy = "User-" + random.Next(1, 11),  // 1 theke 10 er moddhe select hobe randomly 
            //ReviewId = random.Next(1, 21) // 1 - 20

            //       }

            //   }

        }
    }
}





