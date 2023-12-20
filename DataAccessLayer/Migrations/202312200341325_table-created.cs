namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablecreated : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Users", t => t.SellerId)
                .Index(t => t.SellerId)
                .Index(t => t.BrandId)
                .Index(t => t.CategoryId);
            
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
            
            AddColumn("dbo.Brands", "Name", c => c.String());
            AddColumn("dbo.Buyers", "DOB", c => c.DateTime());
            AddColumn("dbo.Buyers", "PhoneNumber", c => c.String());
            AddColumn("dbo.Buyers", "Address", c => c.String());
            AddColumn("dbo.OrderItems", "Quantity", c => c.Int());
            AddColumn("dbo.OrderItems", "UnitPrice", c => c.Int());
            AddColumn("dbo.OrderItems", "Order_Id", c => c.Int());
            AddColumn("dbo.Orders", "totalQuantity", c => c.String());
            AddColumn("dbo.Orders", "totalPrice", c => c.String());
            AddColumn("dbo.Orders", "Buyer_Id", c => c.Int());
            AddColumn("dbo.Users", "CreatedAt", c => c.DateTime());
            CreateIndex("dbo.Orders", "Buyer_Id");
            CreateIndex("dbo.OrderItems", "Order_Id");
            AddForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders", "Id");
            AddForeignKey("dbo.Orders", "Buyer_Id", "dbo.Buyers", "Id");
            DropColumn("dbo.Users", "rating");
            DropTable("dbo.News");
            DropTable("dbo.Products");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "rating", c => c.Int());
            DropForeignKey("dbo.Orders", "Buyer_Id", "dbo.Buyers");
            DropForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Products", "SellerId", "dbo.Users");
            DropForeignKey("dbo.SpecificationCategories", "Products_Id", "dbo.Products");
            DropForeignKey("dbo.Specifications", "SpecificationCategory_Id", "dbo.SpecificationCategories");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.OrderItems", new[] { "Order_Id" });
            DropIndex("dbo.Orders", new[] { "Buyer_Id" });
            DropIndex("dbo.Specifications", new[] { "SpecificationCategory_Id" });
            DropIndex("dbo.SpecificationCategories", new[] { "Products_Id" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropIndex("dbo.Products", new[] { "SellerId" });
            DropColumn("dbo.Users", "CreatedAt");
            DropColumn("dbo.Orders", "Buyer_Id");
            DropColumn("dbo.Orders", "totalPrice");
            DropColumn("dbo.Orders", "totalQuantity");
            DropColumn("dbo.OrderItems", "Order_Id");
            DropColumn("dbo.OrderItems", "UnitPrice");
            DropColumn("dbo.OrderItems", "Quantity");
            DropColumn("dbo.Buyers", "Address");
            DropColumn("dbo.Buyers", "PhoneNumber");
            DropColumn("dbo.Buyers", "DOB");
            DropColumn("dbo.Brands", "Name");
            DropTable("dbo.Specifications");
            DropTable("dbo.SpecificationCategories");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
        }
    }
}
