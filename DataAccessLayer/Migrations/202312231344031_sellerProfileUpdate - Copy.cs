namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sellerProfileUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "BuyerProfileId", "dbo.BuyerProfiles");
            DropIndex("dbo.Users", new[] { "BuyerProfileId" });
            AlterColumn("dbo.Users", "BuyerProfileId", c => c.Int());
            CreateIndex("dbo.Users", "BuyerProfileId");
            AddForeignKey("dbo.Users", "BuyerProfileId", "dbo.BuyerProfiles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "BuyerProfileId", "dbo.BuyerProfiles");
            DropIndex("dbo.Users", new[] { "BuyerProfileId" });
            AlterColumn("dbo.Users", "BuyerProfileId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "BuyerProfileId");
            AddForeignKey("dbo.Users", "BuyerProfileId", "dbo.BuyerProfiles", "Id", cascadeDelete: true);
        }
    }
}
