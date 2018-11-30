using EFContactManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFContactManagement.Controllers
{
    public class GroupController : Controller
    {
        ContactManagementSystemEntities ctx = new ContactManagementSystemEntities();
        // GET: Group
        public ActionResult Index()
        {
            return View(ctx.ContactGroups.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}