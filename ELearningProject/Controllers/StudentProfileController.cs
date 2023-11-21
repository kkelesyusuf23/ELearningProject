using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using ELearningProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class StudentProfileController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: Profile
        public ActionResult Index()
        {
            TempData["Location"] = "Profil";
            string value = Session["CurrentMail"].ToString();
            int studentID = context.Students.Where(x => x.Name == value).Select(y => y.StudentID).FirstOrDefault();
            var studentInformations = context.Students.Where(x => x.StudentID == studentID).FirstOrDefault();
            return View(studentInformations);
        }
        public ActionResult MyCourseList()
        {
            TempData["Location"] = "Kurslarım";
            string values = Session["CurrentMail"].ToString();
            int id = context.Students.Where(x => x.Mail == values).Select(y => y.StudentID).FirstOrDefault();
            var courseList = context.Processes.Where(x => x.StudentID == id).ToList();
            return View(courseList);
        }
        public ActionResult WatchCourse(int? id)
		{
            TempData["Location"] = "Kurslarım";
            ViewBag.id = id;
            ViewBag.courseName = context.Courses.Where(x => x.CourseID == id).Select(x => x.Title).FirstOrDefault();
            var values = context.CourseWatchLists.Where(x => x.CourseID == id).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult RewievCourse(int id)
		{
            TempData["Location"] = "Değerlendirme";
            ViewBag.courseID = id;
            return View();
		}
        [HttpPost]
        public ActionResult RewievCourse(ReviewCommentViewModel model)
        {
            TempData["Location"] = "Değerlendirme";
            string userEmail = Session["CurrentMail"].ToString();
            int studentId = context.Students
                .Where(x => x.Mail == userEmail)
                .Select(y => y.StudentID)
                .FirstOrDefault();

            Review existingReview = context.Reviews
                .FirstOrDefault(r => r.StudentID == studentId && r.CourseID == model.CourseID);

            Comment existingComment = context.Comments
                .FirstOrDefault(c => c.StudentID == studentId && c.CourseID == model.CourseID);

            if (existingReview != null)
            {
                existingReview.ReviewScore = model.ReviewScore;
                context.SaveChanges();
            }
            else
            {
                Review newReview = new Review
                {
                    StudentID = studentId,
                    CourseID = model.CourseID,
                    ReviewScore = model.ReviewScore
                };

                context.Reviews.Add(newReview);
                context.SaveChanges();
            }

            if (existingComment != null)
            {
                existingComment.CommentText = model.CommentText;
                context.SaveChanges();
            }
            else
            {
                Comment newComment = new Comment
                {
                    StudentID = studentId,
                    CourseID = model.CourseID,
                    CommentText = model.CommentText,
                    CommentDate = DateTime.Now
                };

                context.Comments.Add(newComment);
                context.SaveChanges();
            }

            TempData["ReviewSuccess"] = "Değerlendirme ve yorum başarıyla kaydedildi.";

            return RedirectToAction("RewievCourse", "StudentProfile");
        }

    }
}