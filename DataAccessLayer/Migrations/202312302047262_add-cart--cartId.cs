namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcartcartId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "CartId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carts", "CartId");
        }
    }
}
