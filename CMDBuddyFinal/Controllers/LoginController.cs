using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMDBuddyFinal.Models;

namespace CMDBuddy.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Acessar(Usuario usuario)
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
                    return RedirectToAction("Index");
                }
            }
        }
    }
}