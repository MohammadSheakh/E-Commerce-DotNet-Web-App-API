namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataPushToDB2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "name", c => c.String(nullable: false));
            DropColumn("dbo.Roles", "RoleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "RoleName", c => c.String(nullable: false));
            DropColumn("dbo.Roles", "name");
        }
    }
}
