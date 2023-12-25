namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewUpdated01 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "ProductId", c => c.Int());
            CreateIndex("dbo.Reviews", "ProductId");
            AddForeignKey("dbo.Reviews", "ProductId", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "ProductId", "dbo.Products");
            DropIndex("dbo.Reviews", new[] { "ProductId" });
            DropColumn("dbo.Reviews", "ProductId");
        }
    }
}
