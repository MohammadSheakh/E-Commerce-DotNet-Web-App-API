namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNewsTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "Date", c => c.DateTime(nullable: false));
        }
    }
}
