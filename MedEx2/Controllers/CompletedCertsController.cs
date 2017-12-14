using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MedEx2.Models;

namespace MedEx2.Controllers
{
    public class CompletedCertsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CompletedCerts
        public ActionResult Index()
        {
            return View(db.CompletedCerts.ToList());
        }

        // GET: CompletedCerts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompletedCert completedCert = db.CompletedCerts.Find(id);
            if (completedCert == null)
            {
                return HttpNotFound();
            }
            return View(completedCert);
        }

        // GET: CompletedCerts/Create
        public ActionResult Create(int? id)
        {
            ViewBag.ID = id;
            return View();
        }

        // POST: CompletedCerts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CertID,DoctorID,FilePath,ExpirationDate")] CompletedCert completedCert, int? id)
        {
            if (ModelState.IsValid)
            {
                //db.Database.ExecuteSqlCommand("");
                // completedCert.DoctorID = ViewBag.ID;
                completedCert.DoctorID = id;
                db.CompletedCerts.Add(completedCert);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(completedCert);
        }

        // GET: CompletedCerts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompletedCert completedCert = db.CompletedCerts.Find(id);
            if (completedCert == null)
            {
                return HttpNotFound();
            }
            return View(completedCert);
        }

        // POST: CompletedCerts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CertID,DoctorID,FilePath,ExpirationDate")] CompletedCert completedCert)
        {
            if (ModelState.IsValid)
            {
                db.Entry(completedCert).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(completedCert);
        }

        // GET: CompletedCerts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompletedCert completedCert = db.CompletedCerts.Find(id);
            if (completedCert == null)
            {
                return HttpNotFound();
            }
            return View(completedCert);
        }

        // POST: CompletedCerts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompletedCert completedCert = db.CompletedCerts.Find(id);
            db.CompletedCerts.Remove(completedCert);
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
