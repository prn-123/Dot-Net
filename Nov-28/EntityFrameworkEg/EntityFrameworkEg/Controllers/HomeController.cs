using EntityFrameworkEg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkEg.Controllers
{
    public class HomeController : Controller
    {
        ContactManagementSystemEntities ctx = new ContactManagementSystemEntities();
        public ActionResult Index()
        {
            return View(ctx.Contacts.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Contact c)
        {
            if(ModelState.IsValid)
            {
                ctx.Contacts.Add(c);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c);
        }
        public ActionResult Detail(int? id)
        {
            var c = ctx.Contacts.Find(id);
            return View(c);
        }
        public ActionResult Delete(int? id)
        {
            var c = ctx.Contacts.Find(id);
            return View(c);

        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteContact(int? id)
        {
            var c = ctx.Contacts.Find(id);
            ctx.Contacts.Remove(c);
            ctx.SaveChanges();
            return RedirectToAction("index");

        }
        public ActionResult Edit(int? id)
        {
            var c = ctx.Contacts.Find(id);
            return View(c);

        }
        [HttpPost]
        public ActionResult Edit(Contact c)
        {
            var ct = ctx.Contacts.Find(c.ContactId);
            ct.ContactName = c.ContactName;
            ct.Location = c.Location;
            ctx.SaveChanges();
            return RedirectToAction("index");

        }
    }
}