using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMDBuddyFinal.Controllers
{
    public class PainelController : Controller
    {
        // GET: Painel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DBordo()
        {
            ViewBag.Message = "Diários de Bordo";
            return View();
        }

        public ActionResult PVoo()
        {
            ViewBag.Message = "Planos de Voo";
            return View();
        }

        public ActionResult CFerramentas()
        {
            ViewBag.Message = "Caixa de Ferramentas";
            return View();
        }
    }
}