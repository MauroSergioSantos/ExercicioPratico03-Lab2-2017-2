using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp_ExercicioPratico03_Lab2_2017_2.Models;

namespace WebApp_ExercicioPratico03_Lab2_2017_2.Controllers
{
    public class NivelEnsinoController : Controller
    {
        private SistemaAcademicoContext db = new SistemaAcademicoContext();

        // GET: NivelEnsino
        public ActionResult Index()
        {
            return View(db.NivelEnsinos.ToList());
        }

        // GET: NivelEnsino/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEnsino nivelEnsino = db.NivelEnsinos.Find(id);
            if (nivelEnsino == null)
            {
                return HttpNotFound();
            }
            return View(nivelEnsino);
        }

        // GET: NivelEnsino/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NivelEnsino/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NivelEnsinoId,Descricao")] NivelEnsino nivelEnsino)
        {
            if (ModelState.IsValid)
            {
                db.NivelEnsinos.Add(nivelEnsino);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nivelEnsino);
        }

        // GET: NivelEnsino/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEnsino nivelEnsino = db.NivelEnsinos.Find(id);
            if (nivelEnsino == null)
            {
                return HttpNotFound();
            }
            return View(nivelEnsino);
        }

        // POST: NivelEnsino/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NivelEnsinoId,Descricao")] NivelEnsino nivelEnsino)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nivelEnsino).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nivelEnsino);
        }

        // GET: NivelEnsino/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NivelEnsino nivelEnsino = db.NivelEnsinos.Find(id);
            if (nivelEnsino == null)
            {
                return HttpNotFound();
            }
            return View(nivelEnsino);
        }

        // POST: NivelEnsino/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NivelEnsino nivelEnsino = db.NivelEnsinos.Find(id);
            db.NivelEnsinos.Remove(nivelEnsino);
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
