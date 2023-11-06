using ELearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class ContactController : Controller
    {
        ELearningContext context = new ELearningContext();

        public ActionResult Index()
        {
            TempData["Location"] = "Gelen Mesajlar";
            ViewBag.contactCount = context.Contacts.Count();
            var values = context.Contacts.ToList();
            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DetailContact(int id)
        {
            TempData["Location"] = "Mesaj Detay";
            var value = context.Contacts.Find(id);
            return View(value);
        }
    }
}