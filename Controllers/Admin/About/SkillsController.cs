﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjeSon.Models.About;
using ProjeSon.Models.DataContext;

namespace ProjeSon.Controllers.Admin.About
{
    public class SkillsController : Controller
    {
        private PersonelSiteDB db = new PersonelSiteDB();

        // GET: Skills
        public ActionResult Index()
        {
            return View(db.Skillsinfos.ToList());
        }

        // GET: Skills/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skills skills = db.Skillsinfos.Find(id);
            if (skills == null)
            {
                return HttpNotFound();
            }
            return View(skills);
        }

        // GET: Skills/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Skills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Skill,Percentage")] Skills skills)
        {
            if (ModelState.IsValid)
            {
                db.Skillsinfos.Add(skills);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skills);
        }

        // GET: Skills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skills skills = db.Skillsinfos.Find(id);
            if (skills == null)
            {
                return HttpNotFound();
            }
            return View(skills);
        }

        // POST: Skills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Skill,Percentage")] Skills skills)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skills).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skills);
        }

        // GET: Skills/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skills skills = db.Skillsinfos.Find(id);
            if (skills == null)
            {
                return HttpNotFound();
            }
            return View(skills);
        }

        // POST: Skills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Skills skills = db.Skillsinfos.Find(id);
            db.Skillsinfos.Remove(skills);
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
