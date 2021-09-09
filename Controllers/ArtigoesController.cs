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
    public class ArtigoesController : Controller
    {
        private EconomatoWEBContext db = new EconomatoWEBContext();

        // GET: Artigoes
        public ActionResult Index()
        {
            var artigos = db.Artigos.Include(a => a.TipoDeArtigo);
            return View(artigos.ToList());
        }

        // GET: Artigoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artigo artigo = db.Artigos.Find(id);
            if (artigo == null)
            {
                return HttpNotFound();
            }
            return View(artigo);
        }

        // GET: Artigoes/Create
        public ActionResult Create()
        {
            ViewBag.IdTipoDeArtigos = new SelectList(db.TipoDeArtigos, "IdTipoDeArtigos", "Nome");
            return View();
        }

        // POST: Artigoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdArtigo,IdEntidade,Nome,Preco,IdTipoDeArtigos,StockMinimo")] Artigo artigo)
        {
            if (ModelState.IsValid)
            {
                db.Artigos.Add(artigo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdTipoDeArtigos = new SelectList(db.TipoDeArtigos, "IdTipoDeArtigos", "Nome", artigo.IdTipoDeArtigos);
            return View(artigo);
        }

        // GET: Artigoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artigo artigo = db.Artigos.Find(id);
            if (artigo == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdTipoDeArtigos = new SelectList(db.TipoDeArtigos, "IdTipoDeArtigos", "Nome", artigo.IdTipoDeArtigos);
            return View(artigo);
        }

        // POST: Artigoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdArtigo,IdEntidade,Nome,Preco,IdTipoDeArtigos,StockMinimo")] Artigo artigo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artigo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdTipoDeArtigos = new SelectList(db.TipoDeArtigos, "IdTipoDeArtigos", "Nome", artigo.IdTipoDeArtigos);
            return View(artigo);
        }

        // GET: Artigoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artigo artigo = db.Artigos.Find(id);
            if (artigo == null)
            {
                return HttpNotFound();
            }
            return View(artigo);
        }

        // POST: Artigoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artigo artigo = db.Artigos.Find(id);
            db.Artigos.Remove(artigo);
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
