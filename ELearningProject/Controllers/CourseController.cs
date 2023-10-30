using ELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class CourseController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: Course
        public ActionResult Index()
        {
            ViewBag.courseCount = context.Courses.Count();
            var values = context.Courses.ToList();
            return View(values);
        }
    }
}