using QuizzyQuiz.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzyQuiz.Web.Adapters.Interfaces
{
    interface IQuiz
    {
        Quiz getQuiz(int id);
        List<Quiz> getQuizs();
        void Create(Quiz quiz);
    }
}
