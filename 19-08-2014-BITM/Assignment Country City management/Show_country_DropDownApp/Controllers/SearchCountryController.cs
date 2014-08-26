using System;
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
    public class SearchCountryController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: /SearchCountry/
        public ActionResult Index()
        {
            var acity = db.Acity.Include(c => c.Countries);
            ViewBag.CountryId = new SelectList(db.Acountry, "CountryId", "CountryName");
            return View(acity.ToList());
        }

        // GET: /SearchCountry/Details/5
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

        // GET: /SearchCountry/Create
        public ActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Acountry, "CountryId", "CountryName");
            return View();
        }

        // POST: /SearchCountry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(int? countryId)
        {
          //  int count = 0;
            DatabaseContext myDB = new DatabaseContext();
            ViewBag.CountryId = new SelectList(db.Acountry, "CountryId", "CountryName");
          
            var city = (from aCountry in myDB.Acity
                where (int) aCountry.CountryId == countryId
                select aCountry);
  //          city.Count();
 //           city.Count()
            return View(city.ToList());
        }

        // GET: /SearchCountry/Edit/5
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

        // POST: /SearchCountry/Edit/5
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

        // GET: /SearchCountry/Delete/5
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

        // POST: /SearchCountry/Delete/5
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
