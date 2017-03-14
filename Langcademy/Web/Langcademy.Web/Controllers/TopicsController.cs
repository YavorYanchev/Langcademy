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
            return View(topic);
        }

        [HttpPost]
        public ActionResult Solve(Topic topic)
        {
            //var topic = this.topics.GetById(id);

            return RedirectToAction("Index");
        }
    }
}