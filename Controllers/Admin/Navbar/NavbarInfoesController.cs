using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjeSon.Models.DataContext;
using ProjeSon.Models.Navbar;

namespace ProjeSon.Controllers.Admin.Navbar
{
    public class NavbarInfoesController : Controller
    {
        private PersonelSiteDB db = new PersonelSiteDB();

        // GET: NavbarInfoes
        public ActionResult Index()
        {
            return View(db.Navbarinfos.ToList());
        }

        // GET: NavbarInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NavbarInfo navbarInfo = db.Navbarinfos.Find(id);
            if (navbarInfo == null)
            {
                return HttpNotFound();
            }
            return View(navbarInfo);
        }

        // GET: NavbarInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NavbarInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Logo,section1,section2,section3,section4,section5,Github,Linkedin,Youtube,İnstagram")] NavbarInfo navbarInfo)
        {
            if (ModelState.IsValid)
            {
                db.Navbarinfos.Add(navbarInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(navbarInfo);
        }

        // GET: NavbarInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NavbarInfo navbarInfo = db.Navbarinfos.Find(id);
            if (navbarInfo == null)
            {
                return HttpNotFound();
            }
            return View(navbarInfo);
        }

        // POST: NavbarInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Logo,section1,section2,section3,section4,section5,Github,Linkedin,Youtube,İnstagram")] NavbarInfo navbarInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(navbarInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(navbarInfo);
        }

        // GET: NavbarInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NavbarInfo navbarInfo = db.Navbarinfos.Find(id);
            if (navbarInfo == null)
            {
                return HttpNotFound();
            }
            return View(navbarInfo);
        }

        // POST: NavbarInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NavbarInfo navbarInfo = db.Navbarinfos.Find(id);
            db.Navbarinfos.Remove(navbarInfo);
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
