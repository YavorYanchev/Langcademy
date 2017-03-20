using Langcademy.Data.Models;
using Langcademy.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Langcademy.Web.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ITopicsService topics;

        public TopicsController(ITopicsService topics)
        {
            this.topics = topics;
        }

        // GET: Topics
        public ActionResult Index()
        {
            var allTopics = this.topics.GetAllTopics();
            return View(allTopics);
        }

        //public ActionResult Index(int id)
        //{
        //    return View();
        //}

        //TODO: Uncomment this
        //[Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Topic topic)
        {
            this.topics.Add(topic);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var topic = this.topics.GetById(id);
            return View(topic);
        }

        public ActionResult Solve(int id)
        {
            var topic = this.topics.GetById(id);
            this.ViewBag.NumWords = topic.WordsToTranslate.Count;
            return View(topic);
        }

        [HttpPost]
        public ActionResult Solve(Topic topic)
        {
            //var topic = this.topics.GetById(id);

            //here we calculate the result
            //var wordsByUser = topic.WordsToTranslate.ToArray();

            var correctTopic = this.topics.GetById(topic.Id);
            //var words = correctTopic.WordsToTranslate.ToArray();

            int correctAnswers = 0;
            int numberWords = correctTopic.WordsToTranslate.Count;

            var wrongTranslations = new List<object>();

            for (int i = 0; i < numberWords; i++)
            {
                if (correctTopic.WordsToTranslate[i].Translation == topic.SelectedTranslations[i].Translation)
                {
                    correctAnswers += 1;
                }
                else
                {
                    //wrongTranslations.Add(new TranslationResult()
                    //{
                    //    Text = correctTopic.WordsToTranslate[i].Text,
                    //    WrongTranslation = topic.SelectedTranslations[i].Translation,
                    //    CorrectTranslation = correctTopic.WordsToTranslate[i].Translation
                    //});
                }
            }
            //int num = topic.WordsToTranslate.Count;

            double percent = (correctAnswers * 100 ) / numberWords;

            this.TempData["result"] = percent + "% correct answers";
            //this.TempData["wrong"] = wrongTranslations.ToArray();
            return RedirectToAction("Results");
        }

        public ActionResult Results()
        {
            var data = this.TempData["result"];
            //var arr = this.TempData["wrong"];
            return View();
        }

    }

    public class TranslationResult
    {
        public string Text { get; set; }

        public string WrongTranslation { get; set; }

        public string CorrectTranslation{ get; set; }
    }
}