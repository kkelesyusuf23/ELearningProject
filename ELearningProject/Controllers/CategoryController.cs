using ELearningProject.DAL.Context;
using ELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningProject.Controllers
{
    public class CategoryController : Controller
    {
        ELearningContext context = new ELearningContext();
        // GET: Category
        public ActionResult Index()
        {
            var values = context.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
		{
            return View();
		}

        [HttpPost]
        public ActionResult AddCategory(Category category)
		{
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
		}
    }
}