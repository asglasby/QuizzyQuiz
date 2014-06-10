namespace QuizzyQuiz.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Questions", "QuizId");
            AddForeignKey("dbo.Questions", "QuizId", "dbo.Quizs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "QuizId", "dbo.Quizs");
            DropIndex("dbo.Questions", new[] { "QuizId" });
        }
    }
}
