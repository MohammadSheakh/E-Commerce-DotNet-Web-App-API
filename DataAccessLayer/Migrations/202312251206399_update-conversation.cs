namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateconversation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            AlterColumn("dbo.Products", "BrandId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "BrandId");
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            AlterColumn("dbo.Products", "CategoryId", c => c.Int());
            AlterColumn("dbo.Products", "BrandId", c => c.Int());
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Products", "BrandId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "Id");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "Id");
        }
    }
}
