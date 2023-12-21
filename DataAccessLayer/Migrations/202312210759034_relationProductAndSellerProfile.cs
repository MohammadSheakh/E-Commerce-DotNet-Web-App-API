namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationProductAndSellerProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SellerProfile_Id", c => c.Int());
            CreateIndex("dbo.Products", "SellerProfile_Id");
            AddForeignKey("dbo.Products", "SellerProfile_Id", "dbo.SellerProfiles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SellerProfile_Id", "dbo.SellerProfiles");
            DropIndex("dbo.Products", new[] { "SellerProfile_Id" });
            DropColumn("dbo.Products", "SellerProfile_Id");
        }
    }
}
