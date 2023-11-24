using ELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class DefaultController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult FeaturePartial()
		{
            var values = context.Features.ToList();
            return PartialView(values);
		}
        public PartialViewResult ServicePartial()
        {
            var values = context.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutPartial()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutPurposePartial()
        {
            var values = context.AboutPurposes.ToList();
            return PartialView(values);
        }
        public PartialViewResult CategoryPartial()
        {
            var values = context.Categories.Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult CoursePartial()
        {
            var values = context.Courses.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult InstructorPartial()
        {
            var values = context.Instructors.ToList();
            return PartialView(values);
        }
        public PartialViewResult TestimonialPartial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }
    }
}