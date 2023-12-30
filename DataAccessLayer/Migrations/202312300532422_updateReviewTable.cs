namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateReviewTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ReviewReplies", "ReviewId", "dbo.Reviews");
            DropForeignKey("dbo.Reviews", "PostedBy", "dbo.Users");
            DropForeignKey("dbo.ReviewReplies", "PostedBy", "dbo.Users");
            DropIndex("dbo.Reviews", new[] { "PostedBy" });
            DropIndex("dbo.ReviewReplies", new[] { "PostedBy" });
            DropIndex("dbo.ReviewReplies", new[] { "ReviewId" });
            AlterColumn("dbo.Reviews", "PostedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.ReviewReplies", "PostedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.ReviewReplies", "ReviewId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "PostedBy");
            CreateIndex("dbo.ReviewReplies", "PostedBy");
            CreateIndex("dbo.ReviewReplies", "ReviewId");
            AddForeignKey("dbo.ReviewReplies", "ReviewId", "dbo.Reviews", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "PostedBy", "dbo.Users", "Id", cascadeDelete: false);
            AddForeignKey("dbo.ReviewReplies", "PostedBy", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReviewReplies", "PostedBy", "dbo.Users");
            DropForeignKey("dbo.Reviews", "PostedBy", "dbo.Users");
            DropForeignKey("dbo.ReviewReplies", "ReviewId", "dbo.Reviews");
            DropIndex("dbo.ReviewReplies", new[] { "ReviewId" });
            DropIndex("dbo.ReviewReplies", new[] { "PostedBy" });
            DropIndex("dbo.Reviews", new[] { "PostedBy" });
            AlterColumn("dbo.ReviewReplies", "ReviewId", c => c.Int());
            AlterColumn("dbo.ReviewReplies", "PostedBy", c => c.Int());
            AlterColumn("dbo.Reviews", "PostedBy", c => c.Int());
            CreateIndex("dbo.ReviewReplies", "ReviewId");
            CreateIndex("dbo.ReviewReplies", "PostedBy");
            CreateIndex("dbo.Reviews", "PostedBy");
            AddForeignKey("dbo.ReviewReplies", "PostedBy", "dbo.Users", "Id");
            AddForeignKey("dbo.Reviews", "PostedBy", "dbo.Users", "Id");
            AddForeignKey("dbo.ReviewReplies", "ReviewId", "dbo.Reviews", "Id");
        }
    }
}
