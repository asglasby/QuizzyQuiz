using QuizzyQuiz.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzyQuiz.Web.Adapters.Interfaces
{
    interface IQuestion
    {
        void Create(Question question);
        void Delete(int id);
    }
}
