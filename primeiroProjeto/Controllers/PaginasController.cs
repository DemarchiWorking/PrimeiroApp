using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace primeiroProjeto.Controllers
{
    public class PaginasController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Paginas = new Paginas().Lista();
            return View();
        }


        public ActionResult Novo()
        {
            return View();
        }

    }
}