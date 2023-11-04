using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult FeaturePartial()
        {
            return PartialView();
        }
        public PartialViewResult ServicePartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
        public PartialViewResult CategoryPartial()
        {
            return PartialView();
        }
        public PartialViewResult CoursePartial()
        {
            return PartialView();
        }
        public PartialViewResult InstructorPartial()
        {
            return PartialView();
        }
        public PartialViewResult TestimonialPartial()
        {
            return PartialView();
        }
    }
}