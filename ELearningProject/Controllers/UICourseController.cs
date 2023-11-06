using ELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class UICourseController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: UICourse
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PageFeaturePartial()
        {
            return PartialView();
        }
        public PartialViewResult CategoryPartial()
        {
            var values = context.Categories.ToList();
            return PartialView(values);
        }
        public PartialViewResult CoursePartial()
        {
            var values = context.Courses.ToList();
            return PartialView(values);
        }
        public PartialViewResult TestimonialPartial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }
    }
}