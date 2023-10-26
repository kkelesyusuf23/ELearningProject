using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class InstructorController : Controller
    {
        // GET: Instructor
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            var values = context.Instructors.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddInstructor()
		{
            return View();
		}
        [HttpPost]
        public ActionResult AddInstructor(Instructor ınstructor)
		{
            context.Instructors.Add(ınstructor);
            context.SaveChanges();
            return RedirectToAction("Index");
		}
        public ActionResult DeleteInstructor(int id)
		{
            var value = context.Instructors.Find(id);
            context.Instructors.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
		}
        [HttpGet]
        public ActionResult UpdateInstructor(int id)
		{
            var value = context.Instructors.Find(id);
            return View(value);
		}
        [HttpPost]
        public ActionResult UpdateInstructor(Instructor ınstructor)
		{
            var value = context.Instructors.Find(ınstructor.InstructorID);
            value.Name = ınstructor.Name;
            value.Surname = ınstructor.Surname;
            context.SaveChanges();
            return RedirectToAction("Index");
		}
    }
}