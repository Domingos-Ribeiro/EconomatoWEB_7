using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EconomatoWEB.DAL;

namespace EconomatoWEB.Controllers
{
    public class ArtigosNomesController : Controller
    {

        EconomatoWEBContext pointer = new EconomatoWEBContext();

        // GET: ArtigosNomes
        public ActionResult Index()
        {
            //Transporte pelo modelo ou Mdel usando o LINQ
            //A Variavel "TodosOsArtigos" é que vai ficar com o nome de todos os artigos
            var TodosOsArtigos = pointer.Artigos.ToList();

            return View(TodosOsArtigos);
        }
    }
}