using ELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class InstructorAnalysisController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: InstructorAnalysis
        public ActionResult Index()
        {
            TempData["Location"] = "Profil";
            return View();
        }
        public PartialViewResult InstructorPanelPartial()
        {
            string value = Session["CurrentMail"].ToString();
            int ınstructorID = context.Instructors.Where(x => x.Email == value).Select(y => y.InstructorID).FirstOrDefault();
            var values = context.Instructors.Where(x => x.InstructorID == ınstructorID).ToList();
            var v1 = context.Instructors.Where(x => x.InstructorID == ınstructorID).Select(y => y.InstructorID).FirstOrDefault();

            ViewBag.courseCount = context.Courses.Where(x => x.InstructorID == ınstructorID).Count();
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(y => y.CourseID).ToList();
            ViewBag.commentCount = context.Comments.Where(x => v2.Contains(x.CourseID)).Count();
            return PartialView(values);
        }
        public PartialViewResult CommentPartial()
        {
            string value = Session["CurrentMail"].ToString();
            int ınstructorID = context.Instructors.Where(x => x.Email == value).Select(y => y.InstructorID).FirstOrDefault();
            var v1 = context.Instructors.Where(x => x.InstructorID == ınstructorID).Select(y => y.InstructorID).FirstOrDefault();
            ViewBag.courseCount = context.Courses.Where(x => x.InstructorID == ınstructorID).Count();
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(y => y.CourseID).ToList();
            ViewBag.commentCount = context.Comments.Where(x => v2.Contains(x.CourseID)).Count();
            var v3 = context.Comments.Where(x => v2.Contains(x.CourseID)).ToList();
            return PartialView(v3);
        }
        public PartialViewResult CourseListByInstructor()
        {
            string value = Session["CurrentMail"].ToString();
            int ınstructorID = context.Instructors.Where(x => x.Email == value).Select(y => y.InstructorID).FirstOrDefault();
            var values = context.Courses.Where(x => x.InstructorID == ınstructorID).ToList();
            return PartialView(values);
        }
        public PartialViewResult InstructorContactInformation()
        {
            string value = Session["CurrentMail"].ToString();
            int ınstructorID = context.Instructors.Where(x => x.Email == value).Select(y => y.InstructorID).FirstOrDefault();
            var values = context.Instructors.Where(x => x.InstructorID == ınstructorID).FirstOrDefault();
            return PartialView(values);
        }
    }
}