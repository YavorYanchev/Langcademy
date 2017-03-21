using Langcademy.Common;
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
        // GET: Admin/TopicsAdministration
        public ActionResult Index()
        {
            return View();
        }
    }
}