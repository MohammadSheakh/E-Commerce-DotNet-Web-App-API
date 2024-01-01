namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Details = c.String(),
                        ProductImage = c.String(),
                        Rating = c.Int(),
                        Price = c.Int(nullable: false),
                        AvailableQuantity = c.Int(),
                        LowestQuantityToStock = c.Int(),
                        SellerId = c.Int(),
                        BrandId = c.Int(),
                        CategoryId = c.Int(),
                        SellerProfile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.SellerProfiles", t => t.SellerProfile_Id)
                .ForeignKey("dbo.Users", t => t.SellerId)
                .Index(t => t.SellerId)
                .Index(t => t.BrandId)
                .Index(t => t.CategoryId)
                .Index(t => t.SellerProfile_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SpecificationCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Products_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Products_Id)
                .Index(t => t.Products_Id);
            
            CreateTable(
                "dbo.Specifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        SpecificationCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecificationCategories", t => t.SpecificationCategory_Id)
                .Index(t => t.SpecificationCategory_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RoleId = c.Int(),
                        CreatedAt = c.DateTime(),
                        Image = c.String(),
                        PhoneNumber = c.Int(),
                        DOB = c.DateTime(),
                        Address = c.String(),
                        SellerProfileId = c.Int(nullable: false),
                        BuyerProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BuyerProfiles", t => t.BuyerProfileId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .ForeignKey("dbo.SellerProfiles", t => t.SellerProfileId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.SellerProfileId)
                .Index(t => t.BuyerProfileId);
            
            CreateTable(
                "dbo.BuyerProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        totalQuantity = c.String(),
                        totalPrice = c.String(),
                        BuyerProfile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BuyerProfiles", t => t.BuyerProfile_Id)
                .Index(t => t.BuyerProfile_Id);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(),
                        UnitPrice = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.LikeDislikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                        User_Id = c.Int(),
                        Review_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Reviews", t => t.Review_id)
                .Index(t => t.User_Id)
                .Index(t => t.Review_id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SellerProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ShopProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShopProfiles", t => t.ShopProfileId, cascadeDelete: true)
                .Index(t => t.ShopProfileId);
            
            CreateTable(
                "dbo.ShopProfiles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Logo = c.String(),
                        Status = c.String(),
                        Rating = c.Int(),
                        OfflineShopAddress = c.String(),
                        GoogleMapLocation = c.String(),
                        PhoneNumber = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CategoryBrands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Conversations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParticipantsEmail = c.String(),
                        LastMessage = c.String(),
                        CreatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SenderEmail = c.String(),
                        ReceiverEmail = c.String(),
                        ConversationId = c.Int(),
                        MessageDetails = c.String(),
                        CreatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        category = c.String(nullable: false),
                        reviewDetails = c.String(nullable: false),
                        createdAt = c.DateTime(),
                        likeCount = c.Int(),
                        disLikeCount = c.Int(),
                        postedBy = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.postedBy)
                .Index(t => t.postedBy);
            
            CreateTable(
                "dbo.ReviewReplies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        replyDetails = c.String(nullable: false),
                        createdAt = c.DateTime(),
                        postedBy = c.Int(),
                        reviewId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Reviews", t => t.reviewId)
                .ForeignKey("dbo.Users", t => t.postedBy)
                .Index(t => t.postedBy)
                .Index(t => t.reviewId);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        DestroyedAt = c.DateTime(),
                        userId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "postedBy", "dbo.Users");
            DropForeignKey("dbo.ReviewReplies", "postedBy", "dbo.Users");
            DropForeignKey("dbo.ReviewReplies", "reviewId", "dbo.Reviews");
            DropForeignKey("dbo.LikeDislikes", "Review_id", "dbo.Reviews");
            DropForeignKey("dbo.Products", "SellerId", "dbo.Users");
            DropForeignKey("dbo.Users", "SellerProfileId", "dbo.SellerProfiles");
            DropForeignKey("dbo.SellerProfiles", "ShopProfileId", "dbo.ShopProfiles");
            DropForeignKey("dbo.Products", "SellerProfile_Id", "dbo.SellerProfiles");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.LikeDislikes", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "BuyerProfileId", "dbo.BuyerProfiles");
            DropForeignKey("dbo.Orders", "BuyerProfile_Id", "dbo.BuyerProfiles");
            DropForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.SpecificationCategories", "Products_Id", "dbo.Products");
            DropForeignKey("dbo.Specifications", "SpecificationCategory_Id", "dbo.SpecificationCategories");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.ReviewReplies", new[] { "reviewId" });
            DropIndex("dbo.ReviewReplies", new[] { "postedBy" });
            DropIndex("dbo.Reviews", new[] { "postedBy" });
            DropIndex("dbo.SellerProfiles", new[] { "ShopProfileId" });
            DropIndex("dbo.LikeDislikes", new[] { "Review_id" });
            DropIndex("dbo.LikeDislikes", new[] { "User_Id" });
            DropIndex("dbo.OrderItems", new[] { "Order_Id" });
            DropIndex("dbo.Orders", new[] { "BuyerProfile_Id" });
            DropIndex("dbo.Users", new[] { "BuyerProfileId" });
            DropIndex("dbo.Users", new[] { "SellerProfileId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Specifications", new[] { "SpecificationCategory_Id" });
            DropIndex("dbo.SpecificationCategories", new[] { "Products_Id" });
            DropIndex("dbo.Products", new[] { "SellerProfile_Id" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropIndex("dbo.Products", new[] { "SellerId" });
            DropTable("dbo.Tokens");
            DropTable("dbo.ReviewReplies");
            DropTable("dbo.Reviews");
            DropTable("dbo.Messages");
            DropTable("dbo.Conversations");
            DropTable("dbo.CategoryBrands");
            DropTable("dbo.ShopProfiles");
            DropTable("dbo.SellerProfiles");
            DropTable("dbo.Roles");
            DropTable("dbo.LikeDislikes");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.BuyerProfiles");
            DropTable("dbo.Users");
            DropTable("dbo.Specifications");
            DropTable("dbo.SpecificationCategories");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Brands");
        }
    }
}
