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
    public class VeterinariansController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Veterinarians
        public ActionResult Index()
        {
            return View(db.Veterinarians.ToList());
        }

        // GET: Veterinarians/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinarians veterinarians = db.Veterinarians.Find(id);
            if (veterinarians == null)
            {
                return HttpNotFound();
            }
            return View(veterinarians);
        }

        // GET: Veterinarians/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veterinarians/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vetID,vetFirstName,vetLastName,vetEmail,vetPhone")] Veterinarians veterinarians)
        {
            if (ModelState.IsValid)
            {
                db.Veterinarians.Add(veterinarians);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veterinarians);
        }

        // GET: Veterinarians/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinarians veterinarians = db.Veterinarians.Find(id);
            if (veterinarians == null)
            {
                return HttpNotFound();
            }
            return View(veterinarians);
        }

        // POST: Veterinarians/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vetID,vetFirstName,vetLastName,vetEmail,vetPhone")] Veterinarians veterinarians)
        {
            if (ModelState.IsValid)
            {
                db.Entry(veterinarians).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veterinarians);
        }

        // GET: Veterinarians/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinarians veterinarians = db.Veterinarians.Find(id);
            if (veterinarians == null)
            {
                return HttpNotFound();
            }
            return View(veterinarians);
        }

        // POST: Veterinarians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Veterinarians veterinarians = db.Veterinarians.Find(id);
            db.Veterinarians.Remove(veterinarians);
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
