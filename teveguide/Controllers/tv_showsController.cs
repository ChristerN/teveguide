﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using teveguide.Models;
using teveguide.Models.db;


namespace teveguide.Controllers
{
    public class tv_showsController : Controller
    {
        private TeveGuideEntities2 db = new TeveGuideEntities2();

        //public ActionResult Startsida()
        //{
        //    var tvShow = db.GetTvShowNow();
        //    return View(db.tvShow.ToList());
        //}

        // GET: tv_shows
        public ActionResult Index()
        {
            return View(db.tv_shows.ToList());
        }

        //Get current Tv-table
        public ActionResult CurrentTvTable(string channel)
        {
            var currentChannel = from c in db.tv_shows
                                 where c.Channel.Contains(channel)
                                 select c;

            return View(currentChannel.ToList());
        }

        public ActionResult TomorrowTvTable(string channel)
        {
            var currentChannel = from c in db.tv_shows
                                 where c.Channel.Contains(channel)
                                 select c;

            return View(currentChannel.ToList());
        }

        public ActionResult InTwoDaysTvTable(string channel)
        {
            var currentChannel = from c in db.tv_shows
                                 where c.Channel.Contains(channel)
                                 select c;

            return View(currentChannel.ToList());
        }

        public ActionResult InThreeDaysTvTable(string channel)
        {
            var currentChannel = from c in db.tv_shows
                                 where c.Channel.Contains(channel)
                                 select c;

            return View(currentChannel.ToList());
        }

        public ActionResult InFourDaysTvTable(string channel)
        {
            var currentChannel = from c in db.tv_shows
                                 where c.Channel.Contains(channel)
                                 select c;

            return View(currentChannel.ToList());
        }

        public ActionResult InFiveDaysTvTable(string channel)
        {
            var currentChannel = from c in db.tv_shows
                                 where c.Channel.Contains(channel)
                                 select c;

            return View(currentChannel.ToList());
        }

        public ActionResult InSixDaysTvTable(string channel)
        {
            var currentChannel = from c in db.tv_shows
                                 where c.Channel.Contains(channel)
                                 select c;

            return View(currentChannel.ToList());
        }

        [Authorize]

        public ActionResult MyPage()
        {
            return View(db.tv_shows.ToList());
        }

        // GET: tv_shows/Details/5
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

        // GET: tv_shows/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tv_shows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Starttime,Endtime,Substance,Category,Channel")] tv_shows tv_shows)
        {
            if (ModelState.IsValid)
            {
              
                db.tv_shows.Add(tv_shows);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tv_shows);
        }

        // GET: tv_shows/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: tv_shows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Starttime,Endtime,Substance,Category,Channel")] tv_shows tv_shows)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tv_shows).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tv_shows);
        }

        // GET: tv_shows/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: tv_shows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tv_shows tv_shows = db.tv_shows.Find(id);
            db.tv_shows.Remove(tv_shows);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
