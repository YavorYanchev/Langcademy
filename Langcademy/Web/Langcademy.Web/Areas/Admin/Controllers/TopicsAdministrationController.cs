using Langcademy.Common;
using Langcademy.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Langcademy.Web.Areas.Admin.Controllers
{

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    //[Authorize]
    public class TopicsAdministrationController : Controller
    {
        private readonly ITopicsService topics;

        public TopicsAdministrationController(ITopicsService topics)
        {
            this.topics = topics;
        }

        // GET: Admin/TopicsAdministration
        public ActionResult Index()
        {
            var allTopics = this.topics.GetAllTopics();
            return View(allTopics);
        }
    }
}