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
            int ınstructorID = context.Instructors.Where(x => x.Email == value).Select(y => y.InstructorID).FirstOrDefault();
            var instructorStudents = context.CourseRegisters.Where(x => x.Course.InstructorID == ınstructorID).Select(x => x.Student).ToList();
            return View(instructorStudents);
        }
    }
}