namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LikeDislikeReviewUserRelation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LikeDislikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                        User_Id = c.Int(),
                        Review_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Reviews", t => t.Review_id)
                .Index(t => t.User_Id)
                .Index(t => t.Review_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LikeDislikes", "Review_id", "dbo.Reviews");
            DropForeignKey("dbo.LikeDislikes", "User_Id", "dbo.Users");
            DropIndex("dbo.LikeDislikes", new[] { "Review_id" });
            DropIndex("dbo.LikeDislikes", new[] { "User_Id" });
            DropTable("dbo.LikeDislikes");
        }
    }
}
