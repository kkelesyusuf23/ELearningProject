using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class StudentSettingController : Controller
    {
        // GET: StudentSetting
        ELearningContext context = new ELearningContext();
        [HttpGet]
        public ActionResult Index()
        {
            TempData["Location"] = "Ayarlar";
            string value = Session["CurrentMail"].ToString();
            int studentID = context.Students.Where(x => x.Mail == value).Select(y => y.StudentID).FirstOrDefault();
            var studentInformations = context.Students.Where(x => x.StudentID == studentID).FirstOrDefault();
            return View(studentInformations);
        }
        [HttpPost]
        public ActionResult Index(Student student)
        {
            var value = context.Students.Find(student.StudentID);
            value.Name = student.Name;
            value.Surname = student.Surname;
            value.Mail = student.Mail;
            value.Password = student.Password;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}