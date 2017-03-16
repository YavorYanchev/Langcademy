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
            return View();
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
            for (int i = 0; i < numberWords; i++)
            {
                if (correctTopic.WordsToTranslate[i].Translation == topic.SelectedTranslations[i].Translation)
                {
                    correctAnswers += 1;
                }
            }
            //int num = topic.WordsToTranslate.Count;

            double percent = (correctAnswers * 100 ) / numberWords;

            this.TempData["result"] = percent + "% correct answers";
            return RedirectToAction("Results");
        }

        public ActionResult Results()
        {
            var data = this.TempData["result"];
            return View(data);
        }

    }
}