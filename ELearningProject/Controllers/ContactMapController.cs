using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class ContactMapController : Controller
    {
        ELearningContext context = new ELearningContext();

        public ActionResult Index()
        {
            TempData["Location"] = "Harita";
            ViewBag.contactMapCount = context.ContactMaps.Count();
            var values = context.ContactMaps.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddContactMap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContactMap(ContactMap contactMap)
        {
            context.ContactMaps.Add(contactMap);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteContactMap(int id)
        {
            var value = context.ContactMaps.Find(id);
            context.ContactMaps.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateContactMap(int id)
        {
            var value = context.ContactMaps.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateContactMap(ContactMap contactMap)
        {
            var value = context.ContactMaps.Find(contactMap.ContactMapID);
            value.EmbedLink = contactMap.EmbedLink;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}