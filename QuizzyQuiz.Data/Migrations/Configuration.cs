namespace QuizzyQuiz.Data.Migrations
{
    using QuizzyQuiz.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuizzyQuiz.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuizzyQuiz.Data.ApplicationDbContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            db.Quizs.AddOrUpdate(
                q => q.QuizName,
                new Quiz { QuizName = "CSharp" },
                new Quiz { QuizName = "Javascript"},
                new Quiz { QuizName = "BootStrap"},
                new Quiz { QuizName = "Angular"},
                new Quiz { QuizName = "Knockout"},
                new Quiz { QuizName = "JQuery"},
                new Quiz { QuizName = "SQL"}
                );
        }
    }
}
