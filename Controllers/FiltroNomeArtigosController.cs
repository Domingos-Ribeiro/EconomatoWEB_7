using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EconomatoWEB.DAL;

namespace EconomatoWEB.Controllers
{
    public class FiltroNomeArtigosController : Controller
    {
        EconomatoWEBContext db = new EconomatoWEBContext();

        // GET: FiltroNomeArtigos
        public ActionResult Index(string Filtro)
        {
            var NomeArtigos = db.Artigos.ToList();

            if (!string.IsNullOrEmpty(Filtro))
            {
                NomeArtigos = db.Artigos.Where(g => g.Nome.Contains(Filtro)).ToList();
            }

            return View(NomeArtigos);
        }
    }
}