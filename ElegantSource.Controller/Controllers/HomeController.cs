using MvcSiteMapProvider.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElegantSource.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Parent()
        {
            ViewBag.Message = "Parent";
            return View();
        }

        public ActionResult Child()
        {
            ViewBag.Message = "Parent";
            return View();
        }

        //[SiteMapTitle("Key")]
        public ActionResult GrandChild()
        {
            ViewBag.Message = "Parent";
            //ViewData["Key"] = "I am a fucking grand child!!!";
            SiteMap.CurrentNode.Title = "Still working!!";
            return View();
        }
    }
}
