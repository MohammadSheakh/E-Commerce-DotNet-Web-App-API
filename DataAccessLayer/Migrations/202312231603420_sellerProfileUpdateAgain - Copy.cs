namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sellerProfileUpdateAgain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "SellerProfileId", "dbo.SellerProfiles");
            DropIndex("dbo.Users", new[] { "SellerProfileId" });
            AlterColumn("dbo.Users", "SellerProfileId", c => c.Int());
            CreateIndex("dbo.Users", "SellerProfileId");
            AddForeignKey("dbo.Users", "SellerProfileId", "dbo.SellerProfiles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "SellerProfileId", "dbo.SellerProfiles");
            DropIndex("dbo.Users", new[] { "SellerProfileId" });
            AlterColumn("dbo.Users", "SellerProfileId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "SellerProfileId");
            AddForeignKey("dbo.Users", "SellerProfileId", "dbo.SellerProfiles", "Id", cascadeDelete: true);
        }
    }
}
