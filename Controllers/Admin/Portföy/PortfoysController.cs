using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjeSon.Models.DataContext;
using ProjeSon.Models.Portföy;

namespace ProjeSon.Controllers.Admin.Portföy
{
    public class PortfoysController : Controller
    {
        private PersonelSiteDB db = new PersonelSiteDB();

        // GET: Portfoys
        public ActionResult Index()
        {
            return View(db.Portfoyinfos.ToList());
        }

        // GET: Portfoys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portfoy portfoy = db.Portfoyinfos.Find(id);
            if (portfoy == null)
            {
                return HttpNotFound();
            }
            return View(portfoy);
        }

        // GET: Portfoys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Portfoys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name1,PhotoPath11,PhotoPath12,PhotoPath13,PhotoPath14,PhotoPath15,PhotoPath16")] Portfoy portfoy)
        {
            if (ModelState.IsValid)
            {
                db.Portfoyinfos.Add(portfoy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(portfoy);
        }

        // GET: Portfoys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portfoy portfoy = db.Portfoyinfos.Find(id);
            if (portfoy == null)
            {
                return HttpNotFound();
            }
            return View(portfoy);
        }

        // POST: Portfoys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name1,PhotoPath11,PhotoPath12,PhotoPath13,PhotoPath14,PhotoPath15,PhotoPath16")] Portfoy portfoy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(portfoy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(portfoy);
        }

        // GET: Portfoys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portfoy portfoy = db.Portfoyinfos.Find(id);
            if (portfoy == null)
            {
                return HttpNotFound();
            }
            return View(portfoy);
        }

        // POST: Portfoys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Portfoy portfoy = db.Portfoyinfos.Find(id);
            db.Portfoyinfos.Remove(portfoy);
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
