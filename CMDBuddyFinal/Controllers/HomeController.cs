using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMDBuddyFinal.Models;
using Microsoft.Ajax.Utilities;


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

        [HttpPost]
        public ActionResult Salvar(Support ticket)
        {

            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "insert into users (nome, email, telefone, mensagem) values ( ";
                StrQuery += "'" + ticket.Nome + "',";
                StrQuery += "'" + ticket.Email + "',";
                StrQuery += "'" + ticket.Telefone + "',";
                StrQuery += "'" + ticket.Mensagem + "');";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }
        }
    }
}