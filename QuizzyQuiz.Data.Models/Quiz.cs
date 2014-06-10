using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzyQuiz.Data.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string QuizName { get; set; }
        public virtual List<Question> Questions { get; set; }
    }
}
