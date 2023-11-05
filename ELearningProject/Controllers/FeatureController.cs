using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class FeatureController : Controller
    {
        ELearningContext context = new ELearningContext();
        public ActionResult Index()
        {
            TempData["Location"] = "Öne Çıkanlar";
            ViewBag.featureCount = context.Features.Count();
            var values = context.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddFeature()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFeature(Feature feature)
        {
            context.Features.Add(feature);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteFeature(int id)
        {
            var value = context.Features.Find(id);
            context.Features.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateFeature(Feature feature)
        {
            var value = context.Features.Find(feature.FeatureID);
            value.Title = feature.Title;
            value.SubTitle = feature.SubTitle;
            value.ShortDescription = feature.ShortDescription;
            value.LongDescription = feature.LongDescription;
            value.ImageURL = feature.ImageURL;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}