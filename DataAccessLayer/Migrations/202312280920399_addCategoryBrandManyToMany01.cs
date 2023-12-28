namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategoryBrandManyToMany01 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Brands", "CategoryBrand_Id", "dbo.CategoryBrands");
            DropForeignKey("dbo.Categories", "CategoryBrand_Id", "dbo.CategoryBrands");
            DropIndex("dbo.Brands", new[] { "CategoryBrand_Id" });
            DropIndex("dbo.Categories", new[] { "CategoryBrand_Id" });
            AddColumn("dbo.CategoryBrands", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.CategoryBrands", "BrandId", c => c.Int(nullable: false));
            CreateIndex("dbo.CategoryBrands", "CategoryId");
            CreateIndex("dbo.CategoryBrands", "BrandId");
            AddForeignKey("dbo.CategoryBrands", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CategoryBrands", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            DropColumn("dbo.Brands", "CategoryBrand_Id");
            DropColumn("dbo.Categories", "CategoryBrand_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryBrand_Id", c => c.Int());
            AddColumn("dbo.Brands", "CategoryBrand_Id", c => c.Int());
            DropForeignKey("dbo.CategoryBrands", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryBrands", "BrandId", "dbo.Brands");
            DropIndex("dbo.CategoryBrands", new[] { "BrandId" });
            DropIndex("dbo.CategoryBrands", new[] { "CategoryId" });
            DropColumn("dbo.CategoryBrands", "BrandId");
            DropColumn("dbo.CategoryBrands", "CategoryId");
            CreateIndex("dbo.Categories", "CategoryBrand_Id");
            CreateIndex("dbo.Brands", "CategoryBrand_Id");
            AddForeignKey("dbo.Categories", "CategoryBrand_Id", "dbo.CategoryBrands", "Id");
            AddForeignKey("dbo.Brands", "CategoryBrand_Id", "dbo.CategoryBrands", "Id");
        }
    }
}
