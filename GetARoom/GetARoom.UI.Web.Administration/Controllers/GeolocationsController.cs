using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GetARoom.DAL;

namespace GetARoom.UI.Web.Administration.Controllers
{
    public class GeolocationsController : Controller
    {
        private GetARoomEntities db = new GetARoomEntities();

        // GET: Geolocations
        public ActionResult Index()
        {
            return View(db.Geolocation.ToList());
        }

        // GET: Geolocations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Geolocation geolocation = db.Geolocation.Find(id);
            if (geolocation == null)
            {
                return HttpNotFound();
            }
            return View(geolocation);
        }

        // GET: Geolocations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Geolocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GeolocationId,GeoLatitude,GeoLongitude")] Geolocation geolocation)
        {
            if (ModelState.IsValid)
            {
                db.Geolocation.Add(geolocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(geolocation);
        }

        // GET: Geolocations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Geolocation geolocation = db.Geolocation.Find(id);
            if (geolocation == null)
            {
                return HttpNotFound();
            }
            return View(geolocation);
        }

        // POST: Geolocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GeolocationId,GeoLatitude,GeoLongitude")] Geolocation geolocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(geolocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(geolocation);
        }

        // GET: Geolocations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Geolocation geolocation = db.Geolocation.Find(id);
            if (geolocation == null)
            {
                return HttpNotFound();
            }
            return View(geolocation);
        }

        // POST: Geolocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Geolocation geolocation = db.Geolocation.Find(id);
            db.Geolocation.Remove(geolocation);
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
