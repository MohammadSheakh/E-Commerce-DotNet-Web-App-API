namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class brandAndProduct : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "Brand_Id", newName: "BrandId");
            RenameIndex(table: "dbo.Products", name: "IX_Brand_Id", newName: "IX_BrandId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Products", name: "IX_BrandId", newName: "IX_Brand_Id");
            RenameColumn(table: "dbo.Products", name: "BrandId", newName: "Brand_Id");
        }
    }
}
