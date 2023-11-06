using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class ContactInformationController : Controller
    {
        ELearningContext context = new ELearningContext();

        public ActionResult Index()
        {
            TempData["Location"] = "İletişim";
            ViewBag.contactInformationCount = context.ContactInformations.Count();
            var values = context.ContactInformations.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddContactInformation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContactInformation(ContactInformation contactInformation)
        {
            context.ContactInformations.Add(contactInformation);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteContactInformation(int id)
        {
            var value = context.ContactInformations.Find(id);
            context.ContactInformations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateContactInformation(int id)
        {
            var value = context.ContactInformations.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateContactInformation(ContactInformation contactInformation)
        {
            var value = context.ContactInformations.Find(contactInformation.ContactInformationID);
            value.InformationTitle = contactInformation.InformationTitle;
            value.InformationIcon = contactInformation.InformationIcon;
            value.Information = contactInformation.Information;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}