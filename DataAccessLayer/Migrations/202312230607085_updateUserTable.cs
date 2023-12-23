namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ProfileId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ProfileId");
        }
    }
}
