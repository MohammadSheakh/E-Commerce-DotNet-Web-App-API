namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewUpdated : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.LikeDislikes", new[] { "Review_id" });
            DropIndex("dbo.Reviews", new[] { "postedBy" });
            DropIndex("dbo.ReviewReplies", new[] { "postedBy" });
            DropIndex("dbo.ReviewReplies", new[] { "reviewId" });
            CreateIndex("dbo.LikeDislikes", "Review_Id");
            CreateIndex("dbo.Reviews", "PostedBy");
            CreateIndex("dbo.ReviewReplies", "PostedBy");
            CreateIndex("dbo.ReviewReplies", "ReviewId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ReviewReplies", new[] { "ReviewId" });
            DropIndex("dbo.ReviewReplies", new[] { "PostedBy" });
            DropIndex("dbo.Reviews", new[] { "PostedBy" });
            DropIndex("dbo.LikeDislikes", new[] { "Review_Id" });
            CreateIndex("dbo.ReviewReplies", "reviewId");
            CreateIndex("dbo.ReviewReplies", "postedBy");
            CreateIndex("dbo.Reviews", "postedBy");
            CreateIndex("dbo.LikeDislikes", "Review_id");
        }
    }
}
