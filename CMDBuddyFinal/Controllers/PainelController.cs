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

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM users WHERE ";
            StrQuery += "login = '" + usuario.Username + "' and ";
            StrQuery += "senha = '" + usuario.Userpass + "';";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    _ = dr.Read();
                    return View();
                }
                else
                {
                    return RedirectToRoute(new { controller = "Login", action = "Index" });
                }
            }
        }
    }
}