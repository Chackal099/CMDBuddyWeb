using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMDBuddyFinal.Models;
using Microsoft.Ajax.Utilities;

namespace CMDBuddy.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }



        
        public ActionResult Cadastra()
        {
            return View();
        }

        public ActionResult Lembra()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SalvarUsuario(Usuario usuario)
        {

            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "insert into users (login, senha, nome, email) values ( ";
                StrQuery += "'" + usuario.Username + "',";
                StrQuery += "'" + usuario.Userpass + "',";
                StrQuery += "'" + usuario.Nome + "',";
                StrQuery += "'" + usuario.Email + "');";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Lembrar(Usuario usuario, Lembrar lembrar)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM users WHERE ";
            StrQuery += "email = '" + usuario.Email + "';";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    _ = dr.Read();
                    StrQuery = "insert into lembrar (nome, email) values ( ";
                    StrQuery += "'" + lembrar.Nome + "',";
                    StrQuery += "'" + dr.GetString(4) + "');";
                    //StrQuery += "'" + lembrar.Email + "');";
                    MySqlCommand comando1 = new MySqlCommand(StrQuery, conexao.conn);
                    dr.Close();
                    comando1.ExecuteNonQuery();
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Lembra");
                }
            }
        }


    }
}