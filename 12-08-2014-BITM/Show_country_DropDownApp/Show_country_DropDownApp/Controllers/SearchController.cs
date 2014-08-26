﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Show_country_DropDownApp.Models;

namespace Show_country_DropDownApp.Controllers
{
    public class SearchController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: /Search/
        public ActionResult Index()
        {
            var acity = db.Acity.Include(c => c.Countries);
            return View(acity.ToList());
        }

        // GET: /Search/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City city = db.Acity.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(city);
        }

        // GET: /Search/Create
        public ActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Acountry, "CountryId", "CountryName");
            return View();
        }

        // POST: /Search/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CityId,CityName,About,NoOfDwellers,Location,Weather,CountryId")] City city)
        {
            if (ModelState.IsValid)
            {
                db.Acity.Add(city);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(db.Acountry, "CountryId", "CountryName", city.CountryId);
            return View(city);
        }

        // GET: /Search/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City city = db.Acity.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            ViewBag.CountryId = new SelectList(db.Acountry, "CountryId", "CountryName", city.CountryId);
            return View(city);
        }

        // POST: /Search/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CityId,CityName,About,NoOfDwellers,Location,Weather,CountryId")] City city)
        {
            if (ModelState.IsValid)
            {
                db.Entry(city).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CountryId = new SelectList(db.Acountry, "CountryId", "CountryName", city.CountryId);
            return View(city);
        }

        // GET: /Search/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City city = db.Acity.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(city);
        }

        // POST: /Search/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            City city = db.Acity.Find(id);
            db.Acity.Remove(city);
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