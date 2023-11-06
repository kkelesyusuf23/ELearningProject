using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class UIContactController : Controller
    {
        ELearningContext context = new ELearningContext(); 
        // GET: UIContact
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PageFeaturePartial()
        {
            return PartialView();
        }
        public PartialViewResult ContactInformationPartial()
        {
            var values = context.ContactInformations.ToList();
            return PartialView(values);
        }
        public PartialViewResult ContactInformationMapPartial()
        {
            var values = context.ContactMaps.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult ContactPartial(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return PartialView();
        }
    }
}