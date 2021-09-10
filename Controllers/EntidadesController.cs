using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EconomatoWEB.DAL;
using EconomatoWEB.Models;

namespace EconomatoWEB.Controllers
{
    public class EntidadesController : Controller
    {
        private EconomatoWEBContext db = new EconomatoWEBContext();

        // GET: Entidades
        public ActionResult Index()
        {
 
                return View(db.Entidades.ToList());
 
        }

        // GET: Entidades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidade entidade = db.Entidades.Find(id);
            if (entidade == null)
            {
                return HttpNotFound();
            }
            return View(entidade);
        }

        // GET: Entidades/Create
        public ActionResult Create()
        {
            

            return View();
        }

        // POST: Entidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEntidade,Designacao")] Entidade entidade)
        {
            if (ModelState.IsValid)
            {
                db.Entidades.Add(entidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entidade);
        }

        // GET: Entidades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidade entidade = db.Entidades.Find(id);
            if (entidade == null)
            {
                return HttpNotFound();
            }
            return View(entidade);
        }

        // POST: Entidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEntidade,Designacao")] Entidade entidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entidade);
        }

        // GET: Entidades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidade entidade = db.Entidades.Find(id);
            if (entidade == null)
            {
                return HttpNotFound();
            }
            return View(entidade);
        }

        // POST: Entidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entidade entidade = db.Entidades.Find(id);
            db.Entidades.Remove(entidade);
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
