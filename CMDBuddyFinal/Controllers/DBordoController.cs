using CMDBuddyFinal.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMDBuddyFinal.Controllers
{
    public class DBordoController : Controller
    {
        // GET: DBordo
        List<DBordo> lstDiario = new List<DBordo>();
        
        public ActionResult Index()
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM Bordo ORDER BY idBordo";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    DBordo diario = new DBordo()
                    {
                        IdBordo = Convert.ToInt32(dr["idBordo"]),
                        NumeroTripulantes = Convert.ToInt32(dr["NumeroTripulantes"]),
                        NomeTripulantes = Convert.ToString(dr["NomeTripulantes"]),
                        Hora = Convert.ToDateTime(dr["Hora"]).ToString("hh:mm"),
                        Marca = Convert.ToString(dr["Marca"]),
                        Fabricante = Convert.ToString(dr["Fabricante"]),
                        Modelo = Convert.ToString(dr["Modelo"]),
                        NS = Convert.ToString(dr["NS"]),
                        CatReg = Convert.ToString(dr["CatReg"]),
                        HoraCelAnt = Convert.ToInt32(dr["HoraCelAnt"]),
                        HoraCelPag = Convert.ToInt32(dr["HorCelDia"]),
                        TotHoraCel = Convert.ToInt32(dr["ValHorCel"]),
                        Origem = Convert.ToString(dr["Origem"]),
                        Destino = Convert.ToString(dr["Destino"]),
                        HorPart = Convert.ToString(dr["HorPart"]),
                        HorDecolagem = Convert.ToString(dr["HorDec"]),
                        HorPouso = Convert.ToString(dr["HorPou"]),
                        HorCor = Convert.ToString(dr["HorCor"]),
                        HorDiurno = Convert.ToString(dr["HorDiu"]),
                        HorNoturno = Convert.ToString(dr["HorNotu"]),
                        HorIFRR = Convert.ToString(dr["HorIFRR"]),
                        HorIFRC = Convert.ToString(dr["HorIFRC"]),
                        HorTotal = Convert.ToString(dr["HorTotal"]),
                        CombustTotal = Convert.ToString(dr["CombTotal"]),
                        Ocorrencias = Convert.ToString(dr["Ocorr"])

                    };
                    lstDiario.Add(diario);
                }
            }
            return View(lstDiario);
        }
        
        public ActionResult Novo()
        {
            return View();
        }
        
        public ActionResult Editar(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM Bordo WHERE ";
            StrQuery += "idBordo = " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    DBordo dbordo = new DBordo();
                    dbordo.NumeroTripulantes = Convert.ToInt32(dr["NumeroTripulantes"]);
                    dbordo.NomeTripulantes = Convert.ToString(dr["NomeTripulantes"]);
                    dbordo.Hora = Convert.ToDateTime(dr["Hora"]).ToString("hh:mm");
                    dbordo.Marca = Convert.ToString(dr["Marca"]);
                    dbordo.Fabricante = Convert.ToString(dr["Fabricante"]);
                    dbordo.Modelo = Convert.ToString(dr["Modelo"]);
                    dbordo.NS = Convert.ToString(dr["NS"]);
                    dbordo.CatReg = Convert.ToString(dr["CatReg"]);
                    dbordo.HoraCelAnt = Convert.ToInt32(dr["HoraCelAnt"]);
                    dbordo.HoraCelPag = Convert.ToInt32(dr["HorCelDia"]);
                    dbordo.TotHoraCel = Convert.ToInt32(dr["ValHorCel"]);
                    dbordo.Origem = Convert.ToString(dr["Origem"]);
                    dbordo.Destino = Convert.ToString(dr["Destino"]);
                    dbordo.HorPart = Convert.ToString(dr["HorPart"]);
                    dbordo.HorDecolagem = Convert.ToString(dr["HorDec"]);
                    dbordo.HorPouso = Convert.ToString(dr["HorPou"]);
                    dbordo.HorCor = Convert.ToString(dr["HorCor"]);
                    dbordo.HorDiurno = Convert.ToString(dr["HorDiu"]);
                    dbordo.HorNoturno = Convert.ToString(dr["HorNotu"]);
                    dbordo.HorIFRR = Convert.ToString(dr["HorIFRR"]);
                    dbordo.HorIFRC = Convert.ToString(dr["HorIFRC"]);
                    dbordo.HorTotal = Convert.ToString(dr["HorTotal"]);
                    dbordo.CombustTotal = Convert.ToString(dr["CombTotal"]);
                    dbordo.Ocorrencias = Convert.ToString(dr["Ocorr"]);

                    return View(dbordo);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
        [HttpPost]
        public ActionResult Salvar(DBordo dbordo)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "INSERT INTO Bordo(NumeroTripulantes,NomeTripulantes,Hora,Marca,Fabricante,Modelo,NS,CatReg,HorCelAnt,HorCelDia,ValHorCel,Origem,Destino,HorPart,HorDec,HorPou,HorCor,HorDiu,HorNotu,HorIFRR,HorIFRC,HorTotal,CombTotal,Ocorr) values (";
                StrQuery += "'" + dbordo.NumeroTripulantes + "', ";
                StrQuery += "'" + dbordo.NomeTripulantes + "', ";
                StrQuery += "'" + Convert.ToDateTime(dbordo.Hora).ToString("hh:mm") + "', ";
                StrQuery += "'" + dbordo.Marca + "', ";
                StrQuery += "'" + dbordo.Fabricante + "', ";
                StrQuery += "'" + dbordo.Modelo + "', ";
                StrQuery += "'" + dbordo.NS + "', ";
                StrQuery += "'" + dbordo.CatReg + "', ";
                StrQuery += "'" + dbordo.HoraCelAnt + "', ";
                StrQuery += "'" + dbordo.HoraCelPag + "', ";
                StrQuery += "'" + dbordo.TotHoraCel + "', ";
                StrQuery += "'" + dbordo.Origem + "', ";
                StrQuery += "'" + dbordo.Destino + "', ";
                StrQuery += "'" + dbordo.HorPart + "', ";
                StrQuery += "'" + dbordo.HorDecolagem + "', ";
                StrQuery += "'" + dbordo.HorPouso + "', ";
                StrQuery += "'" + dbordo.HorCor + "', ";
                StrQuery += "'" + dbordo.HorDiurno + "', ";
                StrQuery += "'" + dbordo.HorNoturno + "', ";
                StrQuery += "'" + dbordo.HorIFRR + "', ";
                StrQuery += "'" + dbordo.HorIFRC + "', ";
                StrQuery += "'" + dbordo.HorTotal + "', ";
                StrQuery += "'" + dbordo.CombustTotal + "', ";
                StrQuery += "'" + dbordo.Ocorrencias + "');";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
            }
            return RedirectToAction("Index");
        }
    }
}