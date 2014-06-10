using QuizzyQuiz.Data;
using QuizzyQuiz.Data.Models;
using QuizzyQuiz.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizzyQuiz.Web.Adapters.Adapters
{
    public class QuizAdapter : IQuiz
    {
        public Quiz getQuiz(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Quiz quiz = db.Quizs.Where(q => q.Id == id).FirstOrDefault();
            quiz.Questions = db.Questions.Where(qu => qu.QuizId == quiz.Id).ToList();
            return quiz;
        }

        public List<Quiz> getQuizs()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Quiz> Quizs = db.Quizs.ToList();
            foreach (Quiz quiz in Quizs)
            {
                quiz.Questions = db.Questions.Where(q => q.QuizId == quiz.Id).ToList();
            }
            return Quizs;
        }

        public void Create(Quiz quiz)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Quizs.Add(quiz);
            db.SaveChanges();
        }
    }
}