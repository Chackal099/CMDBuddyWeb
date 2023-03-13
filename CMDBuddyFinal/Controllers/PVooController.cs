using CMDBuddyFinal.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace CMDBuddyFinal.Controllers
{
    public class PVooController : Controller
    {
        // GET: PVoo
        List<PVoo> lstPVoo = new List<PVoo>();

        public ActionResult Index()
        {
            Conexao conexao = new Conexao();
            string StrQuery = "SELECT * FROM pvoo ORDER BY idPVoo";
            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    PVoo pvoo = new PVoo()
                    {
                        idPVoo = Convert.ToInt32(dr["idPVoo"]),
                        Destinat = Convert.ToString(dr["Destinat"]),
                        HorApre = Convert.ToString(dr["HorApre"]),
                        Remet = Convert.ToString(dr["Remet"]),
                        Complem = Convert.ToString(dr["Complem"]),
                        Prefix = Convert.ToString(dr["Prefix"]),
                        RegraVoo = Convert.ToString(dr["RegraVoo"]),
                        TipoVoo = Convert.ToString(dr["TipoVoo"]),
                        NAvioes = Convert.ToString(dr["NAvioes"]),
                        TipoAviao = Convert.ToString(dr["TipoAviao"]),
                        CatEstTurb = Convert.ToString(dr["CatEstTurb"]),
                        EquipCap = Convert.ToString(dr["EquipCap"]),
                        AerodPart = Convert.ToString(dr["AerodPart"]),
                        Hora = Convert.ToString(dr["Hora"]),
                        VelCruz = Convert.ToString(dr["VelCruz"]),
                        NvlCruz = Convert.ToString(dr["NvlCruz"]),
                        Rota = Convert.ToString(dr["Rota"]),
                        AeroDest = Convert.ToString(dr["AeroDest"]),
                        DurTotVoo = Convert.ToString(dr["DurTotVoo"]),
                        AeroAlt = Convert.ToString(dr["AeroAlt"]),
                        AeroRes = Convert.ToString(dr["AeroRes"]),
                        OutrosDados = Convert.ToString(dr["OutrosDados"]),
                        Autonomia = Convert.ToString(dr["Autonomia"]),
                        PessBordo = Convert.ToString(dr["PessBordo"]),
                        RadEmer = Convert.ToString(dr["RadEmer"]),
                        EquipSobrev = Convert.ToBoolean(dr["EquipSobrev"]),
                        VestSobrev = Convert.ToBoolean(dr["VestSobrev"]),
                        QuantBotes = Convert.ToString(dr["QuantBotes"]),
                        CapBotes = Convert.ToString(dr["CapBotes"]),
                        CorBotes = Convert.ToString(dr["CorBotes"]),
                        CorAviao = Convert.ToString(dr["CorAviao"]),
                        Observ = Convert.ToString(dr["Observ"]),
                        Pilot = Convert.ToString(dr["Pilot"])
                    };
                    lstPVoo.Add(pvoo);
                }
            }
            return View(lstPVoo);
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Salvar(PVoo pvoo)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "insert into pvoo(Destinat, HorApre, Remet, Complem, Prefix, RegraVoo, TipoVoo, NAvioes, TipoAviao, CatEstTurb, EquipCap, AerodPart, Hora, VelCruz, NvlCruz, Rota, AeroDest, DurTotVoo, AeroAlt, AeroRes, OutrosDados, Autonomia, PessBordo, RadEmer, EquipSobrev, VestSobrev, QuantBotes, CapBotes, CorBotes, CorAviao, Observ, Pilot) values(";
                StrQuery += "'" + pvoo.Destinat + "',";
                StrQuery += "'" + pvoo.HorApre + "',";
                StrQuery += "'" + pvoo.Remet + "',";
                StrQuery += "'" + pvoo.Complem + "',";
                StrQuery += "'" + pvoo.Prefix + "',";
                StrQuery += "'" + pvoo.RegraVoo + "',";
                StrQuery += "'" + pvoo.TipoVoo + "',";
                StrQuery += "'" + pvoo.NAvioes + "',";
                StrQuery += "'" + pvoo.TipoAviao + "',";
                StrQuery += "'" + pvoo.CatEstTurb + "',";
                StrQuery += "'" + pvoo.EquipCap + "',";
                StrQuery += "'" + pvoo.AerodPart + "',";
                StrQuery += "'" + pvoo.Hora + "',";
                StrQuery += "'" + pvoo.VelCruz + "',";
                StrQuery += "'" + pvoo.NvlCruz + "',";
                StrQuery += "'" + pvoo.Rota + "',";
                StrQuery += "'" + pvoo.AeroDest + "',";
                StrQuery += "'" + pvoo.DurTotVoo + "',";
                StrQuery += "'" + pvoo.AeroAlt + "',";
                StrQuery += "'" + pvoo.AeroRes + "',";
                StrQuery += "'" + pvoo.OutrosDados + "',";
                StrQuery += "'" + pvoo.Autonomia + "',";
                StrQuery += "'" + pvoo.PessBordo + "',";
                StrQuery += "'" + pvoo.RadEmer + "',";
                StrQuery += "'" + pvoo.EquipSobrev + "',";
                StrQuery += "'" + pvoo.VestSobrev + "',";
                StrQuery += "'" + pvoo.QuantBotes + "',";
                StrQuery += "'" + pvoo.CapBotes + "',";
                StrQuery += "'" + pvoo.CorBotes + "',";
                StrQuery += "'" + pvoo.CorAviao + "',";
                StrQuery += "'" + pvoo.Observ + "',";
                StrQuery += "'" + pvoo.Pilot + "');";
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
            string StrQuery = "SELECT * FROM pvoo WHERE ";
            StrQuery += "idPVoo = " + Id + 1 + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    PVoo pvoo = new PVoo();
                    pvoo.Destinat = Convert.ToString(dr["Destinat"]);
                    pvoo.HorApre = Convert.ToString(dr["HorApre"]);
                    pvoo.Remet = Convert.ToString(dr["Remet"]);
                    pvoo.Complem = Convert.ToString(dr["Complem"]);
                    pvoo.Prefix = Convert.ToString(dr["Prefix"]);
                    pvoo.RegraVoo = Convert.ToString(dr["RegraVoo"]);
                    pvoo.TipoVoo = Convert.ToString(dr["TipoVoo"]);
                    pvoo.NAvioes = Convert.ToString(dr["NAvioes"]);
                    pvoo.TipoAviao = Convert.ToString(dr["TipoAviao"]);
                    pvoo.CatEstTurb = Convert.ToString(dr["CatEstTurb"]);
                    pvoo.EquipCap = Convert.ToString(dr["EquipCap"]);
                    pvoo.AerodPart = Convert.ToString(dr["AerodPart"]);
                    pvoo.Hora = Convert.ToString(dr["Hora"]);
                    pvoo.VelCruz = Convert.ToString(dr["VelCruz"]);
                    pvoo.NvlCruz = Convert.ToString(dr["NvlCruz"]);
                    pvoo.Rota = Convert.ToString(dr["Rota"]);
                    pvoo.AeroDest = Convert.ToString(dr["AeroDest"]);
                    pvoo.DurTotVoo = Convert.ToString(dr["DurTotVoo"]);
                    pvoo.AeroAlt = Convert.ToString(dr["AeroAlt"]);
                    pvoo.AeroRes = Convert.ToString(dr["AeroRes"]);
                    pvoo.OutrosDados = Convert.ToString(dr["OutrosDados"]);
                    pvoo.Autonomia = Convert.ToString(dr["Autonomia"]);
                    pvoo.PessBordo = Convert.ToString(dr["PessBordo"]);
                    pvoo.RadEmer = Convert.ToString(dr["RadEmer"]);
                    pvoo.EquipSobrev = Convert.ToBoolean(dr["EquipSobrev"]);
                    pvoo.VestSobrev = Convert.ToBoolean(dr["VestSobrev"]);
                    pvoo.QuantBotes = Convert.ToString(dr["QuantBotes"]);
                    pvoo.CapBotes = Convert.ToString(dr["CapBotes"]);
                    pvoo.CorBotes = Convert.ToString(dr["CorBotes"]);
                    pvoo.CorAviao = Convert.ToString(dr["CorAviao"]);
                    pvoo.Observ = Convert.ToString(dr["Observ"]);
                    pvoo.Pilot = Convert.ToString(dr["Pilot"]);

                    return View(pvoo);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
        [HttpPost]
        public ActionResult Edita(PVoo pvoo)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "update pvoo set ";
                StrQuery += "Destinat = '" + pvoo.Destinat + "', ";
                StrQuery += "HorApre = '" + pvoo.HorApre + "', ";
                StrQuery += "Remet = '" + pvoo.Remet + "', ";
                StrQuery += "Complem = '" + pvoo.Complem + "', ";
                StrQuery += "Prefix = '" + pvoo.Prefix + "', ";
                StrQuery += "RegraVoo = '" + pvoo.RegraVoo + "', ";
                StrQuery += "TipoVoo = '" + pvoo.TipoVoo + "', ";
                StrQuery += "NAvioes = '" + pvoo.NAvioes + "', ";
                StrQuery += "TipoAviao = '" + pvoo.TipoAviao + "', ";
                StrQuery += "CatEstTurb = '" + pvoo.CatEstTurb + "', ";
                StrQuery += "EquipCap = '" + pvoo.EquipCap + "', ";
                StrQuery += "AerodPart = '" + pvoo.AerodPart + "', ";
                StrQuery += "Hora = '" + pvoo.Hora + "', ";
                StrQuery += "VelCruz = '" + pvoo.VelCruz + "', ";
                StrQuery += "NvlCruz = '" + pvoo.NvlCruz + "', ";
                StrQuery += "Rota = '" + pvoo.Rota + "', ";
                StrQuery += "AeroDest = '" + pvoo.AeroDest + "', ";
                StrQuery += "DurTotVoo = '" + pvoo.DurTotVoo + "', ";
                StrQuery += "AeroAlt = '" + pvoo.AeroAlt + "', ";
                StrQuery += "AeroRes = '" + pvoo.AeroRes + "', ";
                StrQuery += "OutrosDados = '" + pvoo.OutrosDados + "', ";
                StrQuery += "Autonomia = '" + pvoo.Autonomia + "', ";
                StrQuery += "PessBordo = '" + pvoo.PessBordo + "', ";
                StrQuery += "RadEmer = '" + pvoo.RadEmer + "' ";
                StrQuery += "EquipSobrev = '" + pvoo.EquipSobrev + "' ";
                StrQuery += "VestSobrev = '" + pvoo.VestSobrev + "' ";
                StrQuery += "QuantBotes = '" + pvoo.QuantBotes + "' ";
                StrQuery += "CapBotes = '" + pvoo.CapBotes + "' ";
                StrQuery += "CorBotes = '" + pvoo.CorBotes + "' ";
                StrQuery += "CorAviao = '" + pvoo.CorAviao + "' ";
                StrQuery += "Observ = '" + pvoo.Observ + "' ";
                StrQuery += "Pilot = '" + pvoo.Pilot + "' ";
                StrQuery += "where idPVoo = " + pvoo.idPVoo + ";";
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
            string StrQuery = "Select * from pvoo where";
            StrQuery += " idPVoo =" + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dt = comando.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    PVoo pvoo = new PVoo();
                    pvoo.Destinat = Convert.ToString(dt["Destinat"]);
                    pvoo.HorApre = Convert.ToString(dt["HorApre"]);
                    pvoo.Remet = Convert.ToString(dt["Remet"]);
                    pvoo.Complem = Convert.ToString(dt["Complem"]);
                    pvoo.Prefix = Convert.ToString(dt["Prefix"]);
                    pvoo.RegraVoo = Convert.ToString(dt["RegraVoo"]);
                    pvoo.TipoVoo = Convert.ToString(dt["TipoVoo"]);
                    pvoo.NAvioes = Convert.ToString(dt["NAvioes"]);
                    pvoo.TipoAviao = Convert.ToString(dt["TipoAviao"]);
                    pvoo.CatEstTurb = Convert.ToString(dt["CatEstTurb"]);
                    pvoo.EquipCap = Convert.ToString(dt["EquipCap"]);
                    pvoo.AerodPart = Convert.ToString(dt["AerodPart"]);
                    pvoo.Hora = Convert.ToString(dt["Hora"]);
                    pvoo.VelCruz = Convert.ToString(dt["VelCruz"]);
                    pvoo.NvlCruz = Convert.ToString(dt["NvlCruz"]);
                    pvoo.Rota = Convert.ToString(dt["Rota"]);
                    pvoo.AeroDest = Convert.ToString(dt["AeroDest"]);
                    pvoo.DurTotVoo = Convert.ToString(dt["DurTotVoo"]);
                    pvoo.AeroAlt = Convert.ToString(dt["AeroAlt"]);
                    pvoo.AeroRes = Convert.ToString(dt["AeroRes"]);
                    pvoo.OutrosDados = Convert.ToString(dt["OutrosDados"]);
                    pvoo.Autonomia = Convert.ToString(dt["Autonomia"]);
                    pvoo.PessBordo = Convert.ToString(dt["PessBordo"]);
                    pvoo.RadEmer = Convert.ToString(dt["RadEmer"]);
                    pvoo.EquipSobrev = Convert.ToBoolean(dt["EquipSobrev"]);
                    pvoo.VestSobrev = Convert.ToBoolean(dt["VestSobrev"]);
                    pvoo.QuantBotes = Convert.ToString(dt["QuantBotes"]);
                    pvoo.CapBotes = Convert.ToString(dt["CapBotes"]);
                    pvoo.CorBotes = Convert.ToString(dt["CorBotes"]);
                    pvoo.CorAviao = Convert.ToString(dt["CorAviao"]);
                    pvoo.Observ = Convert.ToString(dt["Observ"]);
                    pvoo.Pilot = Convert.ToString(dt["Pilot"]);
                    return View(pvoo);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public ActionResult Deletar(PVoo pvoo)
        {
            using (Conexao conexao = new Conexao())
            {
                string StrQuery = "Delete from pvoo";
                StrQuery += " where idPVoo = " + pvoo.idPVoo + 1 + ";";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }
        }
    }
}