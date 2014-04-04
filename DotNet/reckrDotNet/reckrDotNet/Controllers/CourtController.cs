using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using reckrDotNet.Models;
using reckrDotNet.DAL;

namespace reckrDotNet.Controllers
{
    public class CourtController : Controller
    {
        private ReckrContext db = new ReckrContext();

        // GET: /Court/
        public ActionResult Index()
        {
            return View(db.Courts.ToList());
        }

        // GET: /Court/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Court court = db.Courts.Find(id);
            if (court == null)
            {
                return HttpNotFound();
            }
            return View(court);
        }

        // GET: /Court/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Court/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CourtID,Name,NumberOfCourts,CourtType,AvgPlayerRating,NumberOfPlayers")] Court court)
        {
            if (ModelState.IsValid)
            {
                db.Courts.Add(court);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(court);
        }

        // GET: /Court/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Court court = db.Courts.Find(id);
            if (court == null)
            {
                return HttpNotFound();
            }
            return View(court);
        }

        // POST: /Court/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CourtID,Name,NumberOfCourts,CourtType,AvgPlayerRating,NumberOfPlayers")] Court court)
        {
            if (ModelState.IsValid)
            {
                db.Entry(court).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(court);
        }

        // GET: /Court/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Court court = db.Courts.Find(id);
            if (court == null)
            {
                return HttpNotFound();
            }
            return View(court);
        }

        // POST: /Court/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Court court = db.Courts.Find(id);
            db.Courts.Remove(court);
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
