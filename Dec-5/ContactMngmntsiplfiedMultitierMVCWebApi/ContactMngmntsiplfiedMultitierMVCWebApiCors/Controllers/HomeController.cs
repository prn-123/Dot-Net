using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactMngmntSimplLibBLL;

namespace ContactMngmntsiplfiedMultitierMVCWebApiCors.Controllers
{
    public class   HomeController : Controller
    {
        ContactRepository cr = new ContactRepository();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View(cr.GetContacts().ToList());
        }
    }
}
