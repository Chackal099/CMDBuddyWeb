using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMDBuddyFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre o projeto.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Como entrar em contato conosco.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Entre com seu Usuário e Senha para usar o Commander Buddy.";
            return View();
        }
    }
}