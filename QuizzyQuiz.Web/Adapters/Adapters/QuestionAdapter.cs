using QuizzyQuiz.Data;
using QuizzyQuiz.Data.Models;
using QuizzyQuiz.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizzyQuiz.Web.Adapters.Adapters
{
    public class QuestionAdapter : IQuestion
    {
        public void Create(Question question)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Questions.Add(question);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Question question = db.Questions.Where(q => q.Id == id).FirstOrDefault();
            db.Questions.Remove(question);
            db.SaveChanges();
        }
    }
}