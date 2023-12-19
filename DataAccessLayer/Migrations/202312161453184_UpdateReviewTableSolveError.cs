namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReviewTableSolveError : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        category = c.String(nullable: false),
                        reviewDetails = c.String(nullable: false),
                        createdAt = c.DateTime(),
                        likeCount = c.Int(),
                        disLikeCount = c.Int(),
                        postedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.postedBy, cascadeDelete: false)
                .Index(t => t.postedBy);
            
            CreateTable(
                "dbo.ReviewReplies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        replyDetails = c.String(nullable: false),
                        createdAt = c.DateTime(),
                        postedBy = c.Int(nullable: false),
                        reviewId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Reviews", t => t.reviewId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.postedBy, cascadeDelete: false)
                .Index(t => t.postedBy)
                .Index(t => t.reviewId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        password = c.String(nullable: false),
                        type = c.String(nullable: false),
                        rating = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.Categories");
            DropTable("dbo.Sellers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 35),
                        rating = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Reviews", "postedBy", "dbo.Users");
            DropForeignKey("dbo.ReviewReplies", "postedBy", "dbo.Users");
            DropForeignKey("dbo.ReviewReplies", "reviewId", "dbo.Reviews");
            DropIndex("dbo.ReviewReplies", new[] { "reviewId" });
            DropIndex("dbo.ReviewReplies", new[] { "postedBy" });
            DropIndex("dbo.Reviews", new[] { "postedBy" });
            DropTable("dbo.Users");
            DropTable("dbo.ReviewReplies");
            DropTable("dbo.Reviews");
        }
    }
}
