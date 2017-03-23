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
    public class SubmissionsAdministrationController:Controller
    {

        private readonly ITopicSubmissionsService submissions;

        public SubmissionsAdministrationController(ITopicSubmissionsService submissions)
        {
            this.submissions = submissions;
        }

        public ActionResult Index()
        {
            var allSubmissions = this.submissions.GetAllTopicSubmissions();
            return View(allSubmissions);
        }
    }
}