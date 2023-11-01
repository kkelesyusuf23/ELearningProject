using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class CourseController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: Course
        public ActionResult Index()
        {
            TempData["Location"] = "Kurs";
            ViewBag.courseCount = context.Courses.Count();
            var values = context.Courses.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCourse()
        {
            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.categories = categories;

            List<SelectListItem> ınstructors = (from x in context.Instructors.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name + " "+ x.Surname,
                                                   Value = x.InstructorID.ToString()
                                               }).ToList();
            ViewBag.ınstructors = ınstructors;
            return View();
        }
        [HttpPost]
        public ActionResult AddCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCourse(int id)
        {
            var value = context.Courses.Find(id);
            context.Courses.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCourse(int id)
        {
            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.categories = categories;

            List<SelectListItem> ınstructors = (from x in context.Instructors.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name + " " + x.Surname,
                                                    Value = x.InstructorID.ToString()
                                                }).ToList();
            ViewBag.ınstructors = ınstructors;
            var values = context.Courses.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCourse(Course course)
        {
            var value = context.Courses.Find(course.CourseID);
            value.Title = course.Title;
            value.CategoryID = course.CategoryID;
            value.Duration = course.Duration;
            value.ImageURL = course.ImageURL;
            value.InstructorID = course.InstructorID;
            value.Price = course.Price;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}