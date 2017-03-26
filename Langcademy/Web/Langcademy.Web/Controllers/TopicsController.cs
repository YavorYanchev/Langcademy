using Langcademy.Data.Models;
using Langcademy.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Langcademy.Web.Infrastructure;
using Langcademy.Web.ViewModels.Topics;
using AutoMapper.QueryableExtensions;

namespace Langcademy.Web.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ITopicsService topics;
        private readonly IUsersService users;
        private readonly ITopicSubmissionsService submissions;

        public TopicsController(ITopicsService topics, IUsersService users, ITopicSubmissionsService submissions)
        {
            this.topics = topics;
            this.users = users;
            this.submissions = submissions;
        }

        // GET: Topics
        public ActionResult Index()
        {
            //return View(allTopics);
            // return this.PartialView("_AllTopicsPartial", allTopics);
            return this.View();
        }

        [HttpGet]
        [ChildActionOnly]
        public ActionResult AllTopics()
        {
            var allTopics = this.topics.GetAllTopics().ToList()
                //.ProjectTo<TopicViewModel>();
                .Select(c => new TopicViewModel(c));

            //var viewModel = new TopicsListViewModel()
            //{
            //    Topics = allTopics
            //};

            return this.PartialView("_AllTopicsPartial", allTopics);

        }

        [Authorize]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Topic topic)
        {
            topic.CreatorId = this.User.Identity.GetUserId();
            this.topics.Add(topic);
            return this.RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var topic = this.topics.GetById(id);

            var topicViewModel = new TopicDetailsViewModel(topic);

            return this.View(topicViewModel);
        }

        public ActionResult Solve(int id)
        {
            var topic = this.topics.GetById(id);
            this.ViewBag.NumWords = topic.WordsToTranslate.Count;
            var ts = new TopicSubmission()
            {
                ForTopic = topic
            };
            return this.View(ts);
        }

        [HttpPost]
        public ActionResult Solve(int id, TopicSubmission topicSubmission, string elapsedTime, int elapsedTimeInSeconds)
        {
            var topic = this.topics.GetById(id);
            topicSubmission.ForTopic = topic;
            topicSubmission.ForTopicId = topic.Id;

            var correctTopic = topicSubmission.ForTopic;
            int correctAnswers = 0;
            int numberWords = correctTopic.WordsToTranslate.Count;

            var wrongTranslations = new List<object>();

            for (int i = 0; i < numberWords; i++)
            {
                if (correctTopic.WordsToTranslate[i].Translation == topicSubmission.SelectedTranslations[i])
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

            double percent = (correctAnswers * 100) / numberWords;
            this.TempData["time-elapsed"] = elapsedTime;
            this.TempData["time-elapsed-seconds"] = elapsedTimeInSeconds;
            this.TempData["result"] = percent + "% correct answers";
            this.TempData["percentage"] = percent;

            if (this.User.Identity.IsAuthenticated)
            {
                var userId = this.User.Identity.GetUserId();

                topicSubmission.ByUserId = userId;
                topicSubmission.TimeElapsed = elapsedTime;
                topicSubmission.TimeElapsedInSeconds = elapsedTimeInSeconds;
                topicSubmission.PercentageCorrectTranslations = percent;
                this.submissions.Add(topicSubmission);
            }

            //this.TempData["wrong"] = wrongTranslations.ToArray();
            return this.RedirectToAction("Results");
        }

        public ActionResult Results(string elapsed)
        {
            var data = this.TempData["result"];
            var time = elapsed;

            return this.View();
        }

        [HttpPost]
        [AjaxOnly]
        public ActionResult FilteredTopics(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return this.AllTopics();
            }
            else
            {
                var filteredTopics = this.topics.GetTopicByNameOrDescription(searchTerm);
                return this.PartialView("_FilteredTopicsPartial", filteredTopics);
            }
        }


    }
}