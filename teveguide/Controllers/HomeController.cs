using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace teveguide.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Today()
        {
            return View();
        }

        public ActionResult Tomorrow()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TwoDaysFromNow()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ThreeDaysFromNow()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult FourDaysFromNow()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult FiveDaysFromNow()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult SixDaysFromNow()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}