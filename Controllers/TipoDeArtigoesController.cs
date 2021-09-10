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
    public class TipoDeArtigoesController : Controller
    {
        private EconomatoWEBContext db = new EconomatoWEBContext();

        // GET: TipoDeArtigoes
        public ActionResult Index()
        {
            return View(db.TipoDeArtigos.ToList());
        }

        // GET: TipoDeArtigoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeArtigo tipoDeArtigo = db.TipoDeArtigos.Find(id);
            if (tipoDeArtigo == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeArtigo);
        }

        // GET: TipoDeArtigoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDeArtigoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTipoDeArtigos,Nome")] TipoDeArtigo tipoDeArtigo)
        {
            if (ModelState.IsValid)
            {
                db.TipoDeArtigos.Add(tipoDeArtigo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoDeArtigo);
        }

        // GET: TipoDeArtigoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeArtigo tipoDeArtigo = db.TipoDeArtigos.Find(id);
            if (tipoDeArtigo == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeArtigo);
        }

        // POST: TipoDeArtigoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTipoDeArtigos,Nome")] TipoDeArtigo tipoDeArtigo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoDeArtigo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoDeArtigo);
        }

        // GET: TipoDeArtigoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeArtigo tipoDeArtigo = db.TipoDeArtigos.Find(id);
            if (tipoDeArtigo == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeArtigo);
        }

        // POST: TipoDeArtigoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoDeArtigo tipoDeArtigo = db.TipoDeArtigos.Find(id);
            db.TipoDeArtigos.Remove(tipoDeArtigo);
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
