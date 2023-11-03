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
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student student)
        {
            var values = context.Students.FirstOrDefault(x => x.Mail == student.Mail && x.Password == student.Password);
            if(values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Name, false);
                Session["CurrentMail"] = values.Mail;
                Session.Timeout = 60;
                return RedirectToAction("Index", "Profile");
            }
            return View();
        }
    }
}