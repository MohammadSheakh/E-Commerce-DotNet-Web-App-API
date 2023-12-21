namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shopProfile : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("dbo.SellerProfiles", "PhoneNumber", c => c.Int());
            AddColumn("dbo.SellerProfiles", "ShopProfileId", c => c.Int(nullable: false));
            CreateIndex("dbo.SellerProfiles", "ShopProfileId");
            AddForeignKey("dbo.SellerProfiles", "ShopProfileId", "dbo.ShopProfiles", "id", cascadeDelete: true);
            DropColumn("dbo.SellerProfiles", "ShopName");
            DropColumn("dbo.SellerProfiles", "ShopDescription");
            DropColumn("dbo.SellerProfiles", "ShopLogo");
            DropColumn("dbo.SellerProfiles", "Status");
            DropColumn("dbo.SellerProfiles", "Rating");
            DropColumn("dbo.SellerProfiles", "OfflineShopAddress");
            DropColumn("dbo.SellerProfiles", "GoogleMapLocation");
            DropColumn("dbo.SellerProfiles", "SellerPhoneNumber");
            DropColumn("dbo.SellerProfiles", "ShopPhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SellerProfiles", "ShopPhoneNumber", c => c.Int());
            AddColumn("dbo.SellerProfiles", "SellerPhoneNumber", c => c.Int());
            AddColumn("dbo.SellerProfiles", "GoogleMapLocation", c => c.String());
            AddColumn("dbo.SellerProfiles", "OfflineShopAddress", c => c.String());
            AddColumn("dbo.SellerProfiles", "Rating", c => c.Int());
            AddColumn("dbo.SellerProfiles", "Status", c => c.String());
            AddColumn("dbo.SellerProfiles", "ShopLogo", c => c.String());
            AddColumn("dbo.SellerProfiles", "ShopDescription", c => c.String());
            AddColumn("dbo.SellerProfiles", "ShopName", c => c.String());
            DropForeignKey("dbo.SellerProfiles", "ShopProfileId", "dbo.ShopProfiles");
            DropIndex("dbo.SellerProfiles", new[] { "ShopProfileId" });
            DropColumn("dbo.SellerProfiles", "ShopProfileId");
            DropColumn("dbo.SellerProfiles", "PhoneNumber");
            DropTable("dbo.ShopProfiles");
        }
    }
}
