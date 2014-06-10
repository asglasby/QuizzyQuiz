namespace QuizzyQuiz.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuizSeedInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionText = c.String(),
                        Answer1 = c.String(),
                        Answer2 = c.String(),
                        Answer3 = c.String(),
                        Answer4 = c.String(),
                        CorrectAnswer = c.String(),
                        QuizId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Quizs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuizName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quizs");
            DropTable("dbo.Questions");
        }
    }
}
