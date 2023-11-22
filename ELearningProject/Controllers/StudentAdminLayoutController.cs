using ELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ELearningProject.Controllers
{
    public class StudentAdminLayoutController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            var values = Session["CurrentMail"].ToString();
            ViewBag.mail = Session["CurrentMail"];
            ViewBag.NameSurname = context.Students.Where(x => x.Mail == values).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialPageRowTitle()
        {
            return PartialView();
        }
        public PartialViewResult PartialPreloader()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        
    }
}