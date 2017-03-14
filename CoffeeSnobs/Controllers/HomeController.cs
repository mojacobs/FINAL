using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeSnobs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learn a little more about what is CoffeeSnobs.com";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Discover how to get in touch with the folks at CoffeeSnobs.com";

            return View();
        }
    }
}