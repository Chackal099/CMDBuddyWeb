using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMDBuddyFinal.Models;
using MySql.Data.MySqlClient;

namespace CMDBuddyFinal.Controllers
{
    public class CFerramentasController : Controller
    {
        // GET: CFerramentas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalHoras()
        {
            ViewBag.Message = "Calculadora de Horas";
            return View();
        }

        public ActionResult RelICAO()
        {
            ViewBag.Message = "Relação de ICAO";
            return View();
        }

        public ActionResult ConMedidas()
        {
            ViewBag.Message = "Conversor de Medidas";
            return View();
        }

        [HttpPost]
        public ActionResult CalculaHoras(HVoo tempo)
        {
            var horasDecimal = (decimal)tempo.Horas + (decimal)tempo.Minutos / 60 + (decimal)tempo.Segundos / 3600;
            ViewBag.Resultado = horasDecimal.ToString("F2");
            return View("CalHoras", tempo);
        }
        [HttpPost]
        public ActionResult Converte(CMedida medida)
        {
            switch (medida.opcaoConversao)
            {
                case "kilo":
                    var kilo = medida.valor * 2.205;
                    ViewBag.Resultado = $"{medida.valor} kg = {kilo:F2} lb";
                    break;
                case "metro":
                    var metro = medida.valor / 1609.344;
                    ViewBag.Resultado = $"{medida.valor} m = {metro:F2} mi";
                    break;
                case "litro":
                    var litro = medida.valor / 3.785;
                    ViewBag.Resultado = $"{medida.valor} L = {litro:F2} gal";
                    break;
                case "centimetro":
                    var centimetro = medida.valor / 2.54;
                    ViewBag.Resultado = $"{medida.valor} cm = {centimetro:F2} in";
                    break;
                default:
                    ViewBag.Resultado = "Opção inválida.";
                    break;
            }

            return View("ConMedidas", medida);
        }
        List<DBordo> lstDiario = new List<DBordo>();

        [HttpPost]
        public ActionResult PesquisaICAO(PICAO picao)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT aerodromo FROM TabICAO WHERE ";
            StrQuery += "icao = '" + picao.ICAO + "';";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    _ = dr.Read();
                    ViewBag.Aerodromo = dr.GetString(0);
                    return View("RelICAO", picao);
                }
                else
                {
                    ViewBag.Aerodromo = "Não Encontrado";
                    return View("RelICAO", picao);
                }
            }
        }
        [HttpPost]
        public ActionResult PesquisaAerodromo(PICAO picao)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT icao FROM TabICAO WHERE ";
            StrQuery += "aerodromo = '" + picao.Aerodromo + "';";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    _ = dr.Read();
                    ViewBag.ICAO = dr.GetString(0);
                    return View("RelICAO", picao);
                }
                else
                {
                    ViewBag.ICAO = "Não Encontrado";
                    return View("RelICAO", picao);
                }
            }
        }
    }
}