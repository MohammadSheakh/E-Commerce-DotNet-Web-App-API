namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderTableRelation : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "BuyerProfile_Id", newName: "BuyerProfileId");
            RenameColumn(table: "dbo.OrderItems", name: "Order_Id", newName: "OrderId");
            RenameIndex(table: "dbo.OrderItems", name: "IX_Order_Id", newName: "IX_OrderId");
            RenameIndex(table: "dbo.Orders", name: "IX_BuyerProfile_Id", newName: "IX_BuyerProfileId");
            AddColumn("dbo.Orders", "SellerProfileId", c => c.Int());
            AddColumn("dbo.OrderItems", "ProductId", c => c.Int());
            CreateIndex("dbo.OrderItems", "ProductId");
            CreateIndex("dbo.Orders", "SellerProfileId");
            AddForeignKey("dbo.Orders", "SellerProfileId", "dbo.SellerProfiles", "Id");
            AddForeignKey("dbo.OrderItems", "ProductId", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Orders", "SellerProfileId", "dbo.SellerProfiles");
            DropIndex("dbo.Orders", new[] { "SellerProfileId" });
            DropIndex("dbo.OrderItems", new[] { "ProductId" });
            DropColumn("dbo.OrderItems", "ProductId");
            DropColumn("dbo.Orders", "SellerProfileId");
            RenameIndex(table: "dbo.Orders", name: "IX_BuyerProfileId", newName: "IX_BuyerProfile_Id");
            RenameIndex(table: "dbo.OrderItems", name: "IX_OrderId", newName: "IX_Order_Id");
            RenameColumn(table: "dbo.OrderItems", name: "OrderId", newName: "Order_Id");
            RenameColumn(table: "dbo.Orders", name: "BuyerProfileId", newName: "BuyerProfile_Id");
        }
    }
}
