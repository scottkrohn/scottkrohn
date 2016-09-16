using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scottkrohn.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult TextRPG()
		{
			return View();
		}

		public ActionResult KrohnDesignsOrdersJava()
		{
			return View();
		}

		public ActionResult PersonalGradebook()
		{
			return View();
		}
	}
}
