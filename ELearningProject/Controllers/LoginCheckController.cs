using ELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class LoginCheckController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: LoginCheck
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
    }
}