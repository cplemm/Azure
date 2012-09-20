using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureWebSiteTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Azure WebSite App deployed from GitHub";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
