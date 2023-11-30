namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMoreTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sellers", "rating", c => c.Int());
            AlterColumn("dbo.Sellers", "name", c => c.String(nullable: false, maxLength: 35));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sellers", "name", c => c.String());
            DropColumn("dbo.Sellers", "rating");
        }
    }
}
