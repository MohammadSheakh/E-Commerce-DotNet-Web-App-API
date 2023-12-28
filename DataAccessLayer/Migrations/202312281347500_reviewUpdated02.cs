namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reviewUpdated02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "ShopProfileId", c => c.Int());
            CreateIndex("dbo.Reviews", "ShopProfileId");
            AddForeignKey("dbo.Reviews", "ShopProfileId", "dbo.ShopProfiles", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "ShopProfileId", "dbo.ShopProfiles");
            DropIndex("dbo.Reviews", new[] { "ShopProfileId" });
            DropColumn("dbo.Reviews", "ShopProfileId");
        }
    }
}
