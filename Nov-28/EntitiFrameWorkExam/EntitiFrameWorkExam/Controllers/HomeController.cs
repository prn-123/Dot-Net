using EntitiFrameWorkExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntitiFrameWorkExam.Controllers
{
    public class HomeController : Controller
    {
        CourseManagementEntities ctx = new CourseManagementEntities();
        public ActionResult Index()
        {
            return View(ctx.Courses.ToList());
        }
        public ActionResult Detail(int? id)
        {
            var c= ctx.Courses.Find(id);
            return View(c);
        }
        public ActionResult Delete(int? id)
        {
            var c = ctx.Courses.Find(id);
            return View(c);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteCourse(int? id)
        {
            var c = ctx.Courses.Find(id);
            ctx.Courses.Remove(c);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Course c)
        {
            ctx.Courses.Add(c);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}