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
    public class AmenitiesController : Controller
    {
        private GetARoomEntities db = new GetARoomEntities();

        // GET: Amenities
        public ActionResult Index()
        {
            return View(db.Amenity.ToList());
        }

        // GET: Amenities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amenity amenity = db.Amenity.Find(id);
            if (amenity == null)
            {
                return HttpNotFound();
            }
            return View(amenity);
        }

        // GET: Amenities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Amenities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AmenityId,Amenity1,AmenityDescription")] Amenity amenity)
        {
            if (ModelState.IsValid)
            {
                db.Amenity.Add(amenity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(amenity);
        }

        // GET: Amenities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amenity amenity = db.Amenity.Find(id);
            if (amenity == null)
            {
                return HttpNotFound();
            }
            return View(amenity);
        }

        // POST: Amenities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AmenityId,Amenity1,AmenityDescription")] Amenity amenity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(amenity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(amenity);
        }

        // GET: Amenities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amenity amenity = db.Amenity.Find(id);
            if (amenity == null)
            {
                return HttpNotFound();
            }
            return View(amenity);
        }

        // POST: Amenities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Amenity amenity = db.Amenity.Find(id);
            db.Amenity.Remove(amenity);
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
