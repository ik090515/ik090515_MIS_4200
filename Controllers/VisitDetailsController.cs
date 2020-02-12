using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ik090515_MIS4200.DAL;
using ik090515_MIS4200.Models;

namespace ik090515_MIS4200.Controllers
{
    public class VisitDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: VisitDetails
        public ActionResult Index()
        {
            var visitDetails = db.VisitDetails.Include(v => v.Owners).Include(v => v.Visits);
            return View(visitDetails.ToList());
        }

        // GET: VisitDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitDetails visitDetails = db.VisitDetails.Find(id);
            if (visitDetails == null)
            {
                return HttpNotFound();
            }
            return View(visitDetails);
        }

        // GET: VisitDetails/Create
        public ActionResult Create()
        {
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "petName");
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description");
            return View();
        }

        // POST: VisitDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "visitDetailID,diagnosis,visitDate,visitID,ownerID")] VisitDetails visitDetails)
        {
            if (ModelState.IsValid)
            {
                db.VisitDetails.Add(visitDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "petName", visitDetails.ownerID);
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description", visitDetails.visitID);
            return View(visitDetails);
        }

        // GET: VisitDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitDetails visitDetails = db.VisitDetails.Find(id);
            if (visitDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "petName", visitDetails.ownerID);
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description", visitDetails.visitID);
            return View(visitDetails);
        }

        // POST: VisitDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "visitDetailID,diagnosis,visitDate,visitID,ownerID")] VisitDetails visitDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visitDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "petName", visitDetails.ownerID);
            ViewBag.visitID = new SelectList(db.Visits, "visitID", "description", visitDetails.visitID);
            return View(visitDetails);
        }

        // GET: VisitDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitDetails visitDetails = db.VisitDetails.Find(id);
            if (visitDetails == null)
            {
                return HttpNotFound();
            }
            return View(visitDetails);
        }

        // POST: VisitDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VisitDetails visitDetails = db.VisitDetails.Find(id);
            db.VisitDetails.Remove(visitDetails);
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
