using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EconomatoWEB.DAL;
using EconomatoWEB.Models;

namespace EconomatoWEB.Controllers
{
    public class DropDown1Controller : Controller
    {
        // GET: DropDown1
        public ActionResult Index()
        {
            EconomatoWEBContext db = new EconomatoWEBContext();

            ViewBag.ArtigosId = new SelectList(db.Artigos, "IdArtigo", "Nome");

            return View();
        }
    }

}