using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VueJSNetCore.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpGet("[action]")]
        public IEnumerable<Question> Questions()
        {
            var questions = new List<Question>();
            questions.Add(new Question(){Id = 1, QuestionBody = "Does a cat run fast?", AnswerOption1="option 1", AnswerOption2="option 2", AnswerOption3 = "option 3", AnswerOption4 = "option 4"});
            questions.Add(new Question(){Id = 2, QuestionBody = "Can a dog fly?", AnswerOption1="option 1", AnswerOption2="option 2", AnswerOption3 = "option 3", AnswerOption4 = "option 4"});
            questions.Add(new Question(){Id = 3, QuestionBody = "Can a dolphin ski?", AnswerOption1="option 1", AnswerOption2="option 2", AnswerOption3 = "option 3", AnswerOption4 = "option 4"});
            questions.Add(new Question(){Id = 4, QuestionBody = "Can an elephant play piano?", AnswerOption1="option 1", AnswerOption2="option 2", AnswerOption3 = "option 3", AnswerOption4 = "option 4"});
            questions.Add(new Question(){Id = 5, QuestionBody = "Can a panguin surf?", AnswerOption1="option 1", AnswerOption2="option 2", AnswerOption3 = "option 3", AnswerOption4 = "option 4"});
            return questions;
        }

        [HttpGet("[action]")]
        public Question Question()
        {
            return new Question() { Id = 1, QuestionBody = "Does a cat run fast?", AnswerOption1 = "option 1", AnswerOption2 = "option 2", AnswerOption3 = "option 3", AnswerOption4 = "option 4" };
        }


      
    }

    public class WeatherForecast
    {
        public string DateFormatted { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }

        public int TemperatureF
        {
            get
            {
                return 32 + (int)(TemperatureC / 0.5556);
            }
        }
    }

    public class Question
    {
        public int Id { get; set; }
        public string QuestionBody { get; set; }
        public string AnswerOption1 { get; set; }
        public string AnswerOption2 { get; set; }
        public string AnswerOption3 { get; set; }
        public string AnswerOption4 { get; set; }
    }
}
