using ELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class UIAboutController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: UIAbout
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PageFeaturePartial()
        {
            return PartialView();
        }
    }
}