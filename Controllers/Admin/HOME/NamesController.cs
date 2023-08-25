using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjeSon.Models.DataContext;
using ProjeSon.Models.Home;

namespace ProjeSon.Controllers.Admin.HOME
{
    public class NamesController : Controller
    {
        private PersonelSiteDB db = new PersonelSiteDB();

        // GET: Names
        public ActionResult Index()
        {
            return View(db.Nameinfos.ToList());
        }

        // GET: Names/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Name name = db.Nameinfos.Find(id);
            if (name == null)
            {
                return HttpNotFound();
            }
            return View(name);
        }

        // GET: Names/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Names/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,Surname")] Name name)
        {
            if (ModelState.IsValid)
            {
                db.Nameinfos.Add(name);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(name);
        }

        // GET: Names/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Name name = db.Nameinfos.Find(id);
            if (name == null)
            {
                return HttpNotFound();
            }
            return View(name);
        }

        // POST: Names/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name,Surname")] Name name)
        {
            if (ModelState.IsValid)
            {
                db.Entry(name).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(name);
        }

        // GET: Names/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Name name = db.Nameinfos.Find(id);
            if (name == null)
            {
                return HttpNotFound();
            }
            return View(name);
        }

        // POST: Names/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Name name = db.Nameinfos.Find(id);
            db.Nameinfos.Remove(name);
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
