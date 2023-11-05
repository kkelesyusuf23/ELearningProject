using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class UILayoutController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: UILayout
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Subscribe subscribe)
        {
            context.Subscribes.Add(subscribe);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult SpinnerPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptsPartial()
        {
            return PartialView();
        }
    }
}