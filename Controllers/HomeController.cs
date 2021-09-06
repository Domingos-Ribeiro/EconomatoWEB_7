using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EconomatoWEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Message = "Economato WEB";

            return View();
        }

        public ActionResult Contactos()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}