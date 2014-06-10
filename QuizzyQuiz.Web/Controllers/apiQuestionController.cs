using QuizzyQuiz.Data.Models;
using QuizzyQuiz.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizzyQuiz.Web.Controllers
{
    public class apiQuestionController : ApiController
    {
        private IQuestion _adapter;

        public IHttpActionResult Post(Question question)
        {
            _adapter.Create(question);
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            _adapter.Delete(id);
            return Ok();
        }
    }
}
