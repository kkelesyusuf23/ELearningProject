using ELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class InstructorStudentController : Controller
    {
        // GET: InstructorStudent
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            TempData["Location"] = "Öğrencilerim";
            string value = Session["CurrentMail"].ToString();
            int instructorID = context.Instructors.Where(x => x.Email == value).Select(y => y.InstructorID).FirstOrDefault();
            var includetables = context.CourseRegisters.Include("Course").Include("Student");
            var instructorStudents = includetables.Where(x => x.Course.InstructorID == instructorID).ToList();
            return View(instructorStudents);
        }
    }
}