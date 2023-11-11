using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ELearningProject.Controllers
{
    public class LoginController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PageFeaturePartial()
        {
            return PartialView();
        }
        public PartialViewResult LoginCheckPartial()
        {
            var values = context.Services.ToList();
            return PartialView(values);
        }

        [HttpGet]
        public ActionResult StudentIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentIndex(Student student)
        {
            var values = context.Students.FirstOrDefault(x => x.Mail == student.Mail && x.Password == student.Password);
            if(values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Mail, false);
                Session["CurrentMail"] = values.Mail;
                Session.Timeout = 60;
                return RedirectToAction("Index", "Profile");
            }
            return View();
        }

        [HttpGet]
        public ActionResult InstructorIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InstructorIndex(Instructor ınstructor)
        {
            var values = context.Instructors.FirstOrDefault(x => x.Email == ınstructor.Email && x.Password == ınstructor.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Email, false);
                Session["CurrentMail"] = values.Email;
                Session.Timeout = 60;
                return RedirectToAction("Index", "InstructorCourse");
            }
            return View();
        }
    }
}