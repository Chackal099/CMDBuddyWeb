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
            string StrQuery = "SELECT * FROM bordo ORDER BY idBordo";
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
                        HoraCelAnt = Convert.ToSingle(dr["HorCelAnt"]),
                        HoraCelPag = Convert.ToSingle(dr["HorCelDia"]),
                        TotHoraCel = Convert.ToSingle(dr["ValHorCel"]),
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

        [HttpPost]
        public ActionResult Salvar(DBordo dbordo)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "insert into bordo(NumeroTripulantes, NomeTripulantes, Hora, Marca, Fabricante, Modelo, NS, CatReg, HorCelAnt, HorCelDia, ValHorCel, Origem, Destino, HorPart, HorDec, HorPou, HorCor, HorDiu, HorNotu, HorIFRR, HorIFRC, HorTotal, CombTotal, Ocorr) values(";
                StrQuery += "'" + dbordo.NumeroTripulantes + "',";
                StrQuery += "'" + dbordo.NomeTripulantes + "',";
                StrQuery += "'" + dbordo.Hora + "',";
                StrQuery += "'" + dbordo.Marca + "',";
                StrQuery += "'" + dbordo.Fabricante + "',";
                StrQuery += "'" + dbordo.Modelo + "',";
                StrQuery += "'" + dbordo.NS + "',";
                StrQuery += "'" + dbordo.CatReg + "',";
                StrQuery += "'" + dbordo.HoraCelAnt + "',";
                StrQuery += "'" + dbordo.HoraCelPag + "',";
                StrQuery += "'" + dbordo.TotHoraCel + "',";
                StrQuery += "'" + dbordo.Origem + "',";
                StrQuery += "'" + dbordo.Destino + "',";
                StrQuery += "'" + dbordo.HorPart + "',";
                StrQuery += "'" + dbordo.HorDecolagem + "',";
                StrQuery += "'" + dbordo.HorPouso + "',";
                StrQuery += "'" + dbordo.HorCor + "',";
                StrQuery += "'" + dbordo.HorDiurno + "',";
                StrQuery += "'" + dbordo.HorNoturno + "',";
                StrQuery += "'" + dbordo.HorIFRR + "',";
                StrQuery += "'" + dbordo.HorIFRC + "',";
                StrQuery += "'" + dbordo.HorTotal + "',";
                StrQuery += "'" + dbordo.CombustTotal + "',";
                StrQuery += "'" + dbordo.Ocorrencias + "');";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }
        }
        
        public ActionResult Editar(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM bordo WHERE ";
            StrQuery += "idBordo = " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    DBordo dbordo = new DBordo();
                    dbordo.IdBordo = Convert.ToInt32(dr["idBordo"]);
                    dbordo.NumeroTripulantes = Convert.ToInt32(dr["NumeroTripulantes"]);
                    dbordo.NomeTripulantes = Convert.ToString(dr["NomeTripulantes"]);
                    dbordo.Hora = Convert.ToDateTime(dr["Hora"]).ToString("hh:mm");
                    dbordo.Marca = Convert.ToString(dr["Marca"]);
                    dbordo.Fabricante = Convert.ToString(dr["Fabricante"]);
                    dbordo.Modelo = Convert.ToString(dr["Modelo"]);
                    dbordo.NS = Convert.ToString(dr["NS"]);
                    dbordo.CatReg = Convert.ToString(dr["CatReg"]);
                    dbordo.HoraCelAnt = Convert.ToSingle(dr["HorCelAnt"]);
                    dbordo.HoraCelPag = Convert.ToSingle(dr["HorCelDia"]);
                    dbordo.TotHoraCel = Convert.ToSingle(dr["ValHorCel"]);
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
        public ActionResult Editar(DBordo dbordo)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "update bordo set ";
                StrQuery += "NumeroTripulantes = " + dbordo.NumeroTripulantes + ", ";
                StrQuery += "NomeTripulantes = '" + dbordo.NomeTripulantes + "', ";
                StrQuery += "Marca = '" + dbordo.Marca + "', ";
                StrQuery += "Fabricante = '" + dbordo.Fabricante + "', ";
                StrQuery += "Modelo = '" + dbordo.Modelo + "', ";
                StrQuery += "NS = '" + dbordo.NS + "', ";
                StrQuery += "CatReg = '" + dbordo.CatReg + "', ";
                StrQuery += "HorCelAnt = " + dbordo.HoraCelAnt + ", ";
                StrQuery += "HorCelDia = " + dbordo.HoraCelPag + ", ";
                StrQuery += "ValHorCel = " + dbordo.TotHoraCel + ", ";
                StrQuery += "Origem = '" + dbordo.Origem + "', ";
                StrQuery += "Destino = '" + dbordo.Destino + "', ";
                StrQuery += "HorPart = '" + dbordo.HorPart + "', ";
                StrQuery += "HorDec = '" + dbordo.HorDecolagem + "', ";
                StrQuery += "HorPou = '" + dbordo.HorPouso + "', ";
                StrQuery += "HorCor = '" + dbordo.HorCor + "', ";
                StrQuery += "HorDiu = '" + dbordo.HorDiurno + "', ";
                StrQuery += "HorNotu = '" + dbordo.HorNoturno + "', ";
                StrQuery += "HorIFRR = '" + dbordo.HorIFRR + "', ";
                StrQuery += "HorIFRC = '" + dbordo.HorIFRC + "', ";
                StrQuery += "HorTotal = '" + dbordo.HorTotal + "', ";
                StrQuery += "CombTotal = '" + dbordo.CombustTotal + "', ";
                StrQuery += "Ocorr = '" + dbordo.Ocorrencias + "', ";
                StrQuery += "Hora = '" + Convert.ToDateTime(dbordo.Hora).ToString("hh:mm") + "' ";
                StrQuery += "where idBordo = " + dbordo.IdBordo + ";";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            Conexao conexao = new Conexao();
            string StrQuery = "Select * from bordo where";
            StrQuery += " idBordo =" + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    DBordo dbordo = new DBordo();
                    dbordo.IdBordo = Convert.ToInt32(dt["idBordo"]);
                    dbordo.NumeroTripulantes = Convert.ToInt32(dt["NumeroTripulantes"]);
                    dbordo.NomeTripulantes = Convert.ToString(dt["NomeTripulantes"]);
                    dbordo.Hora = Convert.ToDateTime(dt["Hora"]).ToString("hh:mm");
                    dbordo.Marca = Convert.ToString(dt["Marca"]);
                    dbordo.Fabricante = Convert.ToString(dt["Fabricante"]);
                    dbordo.Modelo = Convert.ToString(dt["Modelo"]);
                    dbordo.NS = Convert.ToString(dt["NS"]);
                    dbordo.CatReg = Convert.ToString(dt["CatReg"]);
                    dbordo.HoraCelAnt = Convert.ToSingle(dt["HorCelAnt"]);
                    dbordo.HoraCelPag = Convert.ToSingle(dt["HorCelDia"]);
                    dbordo.TotHoraCel = Convert.ToSingle(dt["ValHorCel"]);
                    dbordo.Origem = Convert.ToString(dt["Origem"]);
                    dbordo.Destino = Convert.ToString(dt["Destino"]);
                    dbordo.HorPart = Convert.ToString(dt["HorPart"]);
                    dbordo.HorDecolagem = Convert.ToString(dt["HorDec"]);
                    dbordo.HorPouso = Convert.ToString(dt["HorPou"]);
                    dbordo.HorCor = Convert.ToString(dt["HorCor"]);
                    dbordo.HorDiurno = Convert.ToString(dt["HorDiu"]);
                    dbordo.HorNoturno = Convert.ToString(dt["HorNotu"]);
                    dbordo.HorIFRR = Convert.ToString(dt["HorIFRR"]);
                    dbordo.HorIFRC = Convert.ToString(dt["HorIFRC"]);
                    dbordo.HorTotal = Convert.ToString(dt["HorTotal"]);
                    dbordo.CombustTotal = Convert.ToString(dt["CombTotal"]);
                    dbordo.Ocorrencias = Convert.ToString(dt["Ocorr"]);
                    return View(dbordo);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public ActionResult Deletar(DBordo dbordo)
        {
         using (Conexao conexao = new Conexao())
         {
           string StrQuery = "Delete from bordo";
           StrQuery += " where idBordo = " + dbordo.IdBordo + ";";
             using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
             {
               comando.ExecuteNonQuery();
             }
           return RedirectToAction("Index");
         }
        }
    }
}