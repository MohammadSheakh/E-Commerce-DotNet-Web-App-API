namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategoryBrandManyToMany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "CategoryBrand_Id", c => c.Int());
            AddColumn("dbo.Categories", "CategoryBrand_Id", c => c.Int());
            CreateIndex("dbo.Brands", "CategoryBrand_Id");
            CreateIndex("dbo.Categories", "CategoryBrand_Id");
            AddForeignKey("dbo.Brands", "CategoryBrand_Id", "dbo.CategoryBrands", "Id");
            AddForeignKey("dbo.Categories", "CategoryBrand_Id", "dbo.CategoryBrands", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "CategoryBrand_Id", "dbo.CategoryBrands");
            DropForeignKey("dbo.Brands", "CategoryBrand_Id", "dbo.CategoryBrands");
            DropIndex("dbo.Categories", new[] { "CategoryBrand_Id" });
            DropIndex("dbo.Brands", new[] { "CategoryBrand_Id" });
            DropColumn("dbo.Categories", "CategoryBrand_Id");
            DropColumn("dbo.Brands", "CategoryBrand_Id");
        }
    }
}
