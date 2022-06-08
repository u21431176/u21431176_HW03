using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21431176_HW03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Everything to do with handling your media";
            return View();
        }

        public ActionResult Files()
        {
            ViewBag.Message = "Media/Documents/ folder";

            return View();
        }

        public ActionResult Images()
        {
            ViewBag.Message = "Media/Images/ folder";

            return View();
        }

        public ActionResult Videos()
        {
            ViewBag.Message = "Media/Videos/ folder";

            return View();
        }

        public ActionResult Aboutme()
        {
            ViewBag.Message = "I hope you're ready";

            return View();
        }

    }
}