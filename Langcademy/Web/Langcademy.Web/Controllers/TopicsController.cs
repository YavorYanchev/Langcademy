using Langcademy.Data.Models;
using Langcademy.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace Langcademy.Web.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ITopicsService topics;
        private readonly IUsersService users;

        public TopicsController(ITopicsService topics,IUsersService users)
        {
            this.topics = topics;
            this.users = users;
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
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Topic topic)
        {
            //topic.User = this.User.Identity;
            var id = this.HttpContext.User.Identity.GetUserId();
            var user = users.GetById(id);
            topic.CreatorId = id;
            topic.Creator = user.FirstOrDefault();
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
            var ts = new TopicSubmission()
            {
                
                ForTopic = topic
            };
            return View(ts);
        }

        [HttpPost]
        public ActionResult Solve(int id,TopicSubmission topicSubmission, string elapsedTime,int elapsedTimeInSeconds)
        {
            //var idFromUrl = int.Parse(this.Request.Url.AbsolutePath.Split('/').Last());
           var topic = this.topics.GetById(id);
            topicSubmission.ForTopic = topic;
            topicSubmission.ForTopicId = topic.Id;
         
            var correctTopic = topicSubmission.ForTopic;
            

            int correctAnswers = 0;
            int numberWords = correctTopic.WordsToTranslate.Count;

            var wrongTranslations = new List<object>();

            for (int i = 0; i < numberWords; i++)
            {
                if (correctTopic.WordsToTranslate[i].Translation == topicSubmission.SelectedTranslations[i].Translation)
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
            this.TempData["time-elapsed"] = elapsedTime;
            this.TempData["time-elapsed-seconds"] = elapsedTimeInSeconds;
            this.TempData["result"] = percent + "% correct answers";

            //if(this.User.Identity.IsAuthenticated)
            //{
            //    var id = this.HttpContext.User.Identity.GetUserId();
            //    var user = users.GetById(id);
            //    user.FirstOrDefault().Topics.Add(topic);
            //    var all = user.FirstOrDefault().Topics;
            //}

            //this.TempData["wrong"] = wrongTranslations.ToArray();
            return RedirectToAction("Results");
        }

        
        public ActionResult Results(string elapsed)
        {
            var data = this.TempData["result"];
            var time = elapsed;
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