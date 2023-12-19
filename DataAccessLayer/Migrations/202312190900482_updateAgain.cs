namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAgain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ReviewReplies", "reviewId", "dbo.Reviews");
            DropForeignKey("dbo.Reviews", "postedBy", "dbo.Users");
            DropForeignKey("dbo.ReviewReplies", "postedBy", "dbo.Users");
            DropIndex("dbo.Reviews", new[] { "postedBy" });
            DropIndex("dbo.ReviewReplies", new[] { "postedBy" });
            DropIndex("dbo.ReviewReplies", new[] { "reviewId" });
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        DestroyedAt = c.DateTime(),
                        userId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Users", "email", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "postedBy", c => c.Int());
            AlterColumn("dbo.ReviewReplies", "postedBy", c => c.Int());
            AlterColumn("dbo.ReviewReplies", "reviewId", c => c.Int());
            CreateIndex("dbo.Reviews", "postedBy");
            CreateIndex("dbo.ReviewReplies", "postedBy");
            CreateIndex("dbo.ReviewReplies", "reviewId");
            AddForeignKey("dbo.ReviewReplies", "reviewId", "dbo.Reviews", "id");
            AddForeignKey("dbo.Reviews", "postedBy", "dbo.Users", "id");
            AddForeignKey("dbo.ReviewReplies", "postedBy", "dbo.Users", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReviewReplies", "postedBy", "dbo.Users");
            DropForeignKey("dbo.Reviews", "postedBy", "dbo.Users");
            DropForeignKey("dbo.ReviewReplies", "reviewId", "dbo.Reviews");
            DropIndex("dbo.ReviewReplies", new[] { "reviewId" });
            DropIndex("dbo.ReviewReplies", new[] { "postedBy" });
            DropIndex("dbo.Reviews", new[] { "postedBy" });
            AlterColumn("dbo.ReviewReplies", "reviewId", c => c.Int(nullable: false));
            AlterColumn("dbo.ReviewReplies", "postedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Reviews", "postedBy", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "email");
            DropTable("dbo.Tokens");
            CreateIndex("dbo.ReviewReplies", "reviewId");
            CreateIndex("dbo.ReviewReplies", "postedBy");
            CreateIndex("dbo.Reviews", "postedBy");
            AddForeignKey("dbo.ReviewReplies", "postedBy", "dbo.Users", "id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "postedBy", "dbo.Users", "id", cascadeDelete: true);
            AddForeignKey("dbo.ReviewReplies", "reviewId", "dbo.Reviews", "id", cascadeDelete: true);
        }
    }
}
