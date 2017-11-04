using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using teveguide.Models;
using teveguide.Models.db;
namespace teveguide.Controllers
{
    public class HomeController : Controller
    {
        private TeveGuideEntities2 db = new TeveGuideEntities2();

        public ActionResult Today()
        {
            ViewBag.Message = "På TV idag";
            return View(db.tv_shows.ToList());
        }

        public ActionResult Tomorrow()
        {
            ViewBag.Message = "På TV imorgon";

            return View(db.tv_shows.ToList());
        }

        public ActionResult TwoDaysFromNow()
        {
            ViewBag.Message = "På TV om två dagar";

            return View(db.tv_shows.ToList());
        }

        public ActionResult ThreeDaysFromNow()
        {
            ViewBag.Message = "På TV om tre dagar";

            return View(db.tv_shows.ToList());
        }

        public ActionResult FourDaysFromNow()
        {
            ViewBag.Message = "På TV om fyra dagar";

            return View(db.tv_shows.ToList());
        }

        public ActionResult FiveDaysFromNow()
        {
            ViewBag.Message = "På TV om fem dagar";

            return View(db.tv_shows.ToList());
        }

        public ActionResult SixDaysFromNow()
        {
            ViewBag.Message = "På TV om sex dagar";

            return View(db.tv_shows.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tv_shows tv_shows = db.tv_shows.Find(id);
            if (tv_shows == null)
            {
                return HttpNotFound();
            }
            return View(tv_shows);
        }

    }
}