using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello there!";

            return View();
        }

        public ActionResult Lan()
        {
            ViewBag.Message = "It's a party!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Me. All about me.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}
