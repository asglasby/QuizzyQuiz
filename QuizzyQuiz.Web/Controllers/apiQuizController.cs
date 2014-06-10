using QuizzyQuiz.Data.Models;
using QuizzyQuiz.Web.Adapters.Adapters;
using QuizzyQuiz.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizzyQuiz.Web.Controllers
{
    public class apiQuizController : ApiController
    {
        private IQuiz _adapter;

        public apiQuizController()
        {
            _adapter = new QuizAdapter();
        }

        public IHttpActionResult Get(int id = -1)
        {
            if( id != -1)
            {
                return Ok(_adapter.getQuiz(id));
            }
            else
            {
                return Ok(_adapter.getQuizs());
            }
        }

        public IHttpActionResult Post(Quiz quiz)
        {
            _adapter.Create(quiz);
            return Ok();
        }
    }
}
