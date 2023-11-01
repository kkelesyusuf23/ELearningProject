using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class TestimonialController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: Testimonial
        public ActionResult Index()
        {
            TempData["Location"] = "Referans";
            ViewBag.testimonialCount = context.Testimonials.Count();
            var values = context.Testimonials.ToList();
            return View(values);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = context.Testimonials.Find(testimonial.TestimonialID);
            value.NameSurname = testimonial.NameSurname;
            value.Title = testimonial.Title;
            value.ImageURL = testimonial.ImageURL;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}