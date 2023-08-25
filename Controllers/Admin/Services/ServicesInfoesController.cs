using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjeSon.Models.DataContext;
using ProjeSon.Models.Services;

namespace ProjeSon.Controllers.Admin.Services
{
    public class ServicesInfoesController : Controller
    {
        private PersonelSiteDB db = new PersonelSiteDB();

        // GET: ServicesInfoes
        public ActionResult Index()
        {
            return View(db.Servicesinfos.ToList());
        }

        // GET: ServicesInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicesInfo servicesInfo = db.Servicesinfos.Find(id);
            if (servicesInfo == null)
            {
                return HttpNotFound();
            }
            return View(servicesInfo);
        }

        // GET: ServicesInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicesInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Icon1URL,Title1,String11,String12")] ServicesInfo servicesInfo)
        {
            if (ModelState.IsValid)
            {
                db.Servicesinfos.Add(servicesInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicesInfo);
        }

        // GET: ServicesInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicesInfo servicesInfo = db.Servicesinfos.Find(id);
            if (servicesInfo == null)
            {
                return HttpNotFound();
            }
            return View(servicesInfo);
        }

        // POST: ServicesInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Icon1URL,Title1,String11,String12")] ServicesInfo servicesInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicesInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicesInfo);
        }

        // GET: ServicesInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicesInfo servicesInfo = db.Servicesinfos.Find(id);
            if (servicesInfo == null)
            {
                return HttpNotFound();
            }
            return View(servicesInfo);
        }

        // POST: ServicesInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServicesInfo servicesInfo = db.Servicesinfos.Find(id);
            db.Servicesinfos.Remove(servicesInfo);
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
