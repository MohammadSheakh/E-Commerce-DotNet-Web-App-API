namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class likeDislikeForReview : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.LikeDislikes", name: "Review_Id", newName: "ReviewId");
            RenameColumn(table: "dbo.LikeDislikes", name: "User_Id", newName: "UserId");
            RenameIndex(table: "dbo.LikeDislikes", name: "IX_Review_Id", newName: "IX_ReviewId");
            RenameIndex(table: "dbo.LikeDislikes", name: "IX_User_Id", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.LikeDislikes", name: "IX_UserId", newName: "IX_User_Id");
            RenameIndex(table: "dbo.LikeDislikes", name: "IX_ReviewId", newName: "IX_Review_Id");
            RenameColumn(table: "dbo.LikeDislikes", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.LikeDislikes", name: "ReviewId", newName: "Review_Id");
        }
    }
}
