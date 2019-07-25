namespace MyWheel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAnswers", "Question_Id", c => c.Int());
            CreateIndex("dbo.UserAnswers", "Question_Id");
            AddForeignKey("dbo.UserAnswers", "Question_Id", "dbo.Questions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAnswers", "Question_Id", "dbo.Questions");
            DropIndex("dbo.UserAnswers", new[] { "Question_Id" });
            DropColumn("dbo.UserAnswers", "Question_Id");
        }
    }
}
