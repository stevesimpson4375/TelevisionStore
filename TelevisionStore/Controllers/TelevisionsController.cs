using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TelevisionStore.Models;

namespace TelevisionStore.Controllers
{
    public class TelevisionsController : Controller
    {
        private TelevisionStoreContext db = new TelevisionStoreContext();

        // GET: Televisions
        public ActionResult Index()
        {
            return View(db.Televisions.ToList());
        }

        // GET: Televisions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Television television = db.Televisions.Find(id);
            if (television == null)
            {
                return HttpNotFound();
            }
            return View(television);
        }

        // GET: Televisions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Televisions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TelevisionId,Manufacturer,Size,Price")] Television television)
        {
            if (ModelState.IsValid)
            {
                db.Televisions.Add(television);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(television);
        }

        // GET: Televisions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Television television = db.Televisions.Find(id);
            if (television == null)
            {
                return HttpNotFound();
            }
            return View(television);
        }

        // POST: Televisions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TelevisionId,Manufacturer,Size,Price")] Television television)
        {
            if (ModelState.IsValid)
            {
                db.Entry(television).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(television);
        }

        // GET: Televisions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Television television = db.Televisions.Find(id);
            if (television == null)
            {
                return HttpNotFound();
            }
            return View(television);
        }

        // POST: Televisions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Television television = db.Televisions.Find(id);
            db.Televisions.Remove(television);
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
