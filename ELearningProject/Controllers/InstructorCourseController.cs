using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class InstructorCourseController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: InstructorCourse
        public ActionResult Index()
        {
            TempData["Location"] ="Kurslarım";
            string value = Session["CurrentMail"].ToString();
            int ınstructorID = context.Instructors.Where(x => x.Email == value).Select(y => y.InstructorID).FirstOrDefault();
            var courseToInstructorById = context.Courses.Where(x => x.InstructorID == ınstructorID).ToList();
            ViewBag.ınstructorCourseCount = context.Courses.Where(x => x.InstructorID == ınstructorID).Count();
            return View(courseToInstructorById);
        }
        
        public ActionResult DeleteInstructorCourse(int id)
        {
            var value = context.Courses.Find(id);
            context.Courses.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateInstructorCourse(int id)
        {
            List<SelectListItem> categories = (from x in context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.categories = categories;
            List<SelectListItem> instructors = (from x in context.Instructors.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name + " " + x.Surname,
                                                   Value = x.InstructorID.ToString()
                                               }).ToList();
            ViewBag.instructors = instructors;

            var value = context.Courses.Where(x => x.CourseID == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateInstructorCourse(Course course)
        {
            var value = context.Courses.Find(course.CourseID);
            value.Title = course.Title;
            value.Price = course.Price;
            value.Duration = course.Duration;
            value.ImageURL = course.ImageURL;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddVideo(int id)
        {
            TempData["Location"] = "Video";
            ViewBag.id = id;
            var values = context.CourseWatchLists.Where(x => x.CourseID == id).ToList();
            return View(values);
        }
        [HttpPost]
        public ActionResult AddVideo(CourseWatchList courseWatchList)
        {
            context.CourseWatchLists.Add(courseWatchList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}