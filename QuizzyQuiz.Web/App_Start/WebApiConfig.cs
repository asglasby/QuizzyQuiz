﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace QuizzyQuiz.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/plain"));
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
           name: "QuestionApi",
           routeTemplate: "api/v1/Question/{id}",
           defaults: new { controller = "apiQuestion", id = RouteParameter.Optional }
       );

            config.Routes.MapHttpRoute(
              name: "QuizApi",
              routeTemplate: "api/v1/Quiz/{id}",
              defaults: new { controller = "apiQuiz", id = RouteParameter.Optional }
          );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
