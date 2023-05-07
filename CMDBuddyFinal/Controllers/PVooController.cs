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
                        RadEmer_U = Convert.ToBoolean(dr["RadEmer_U"]),
                        RadEmer_V = Convert.ToBoolean(dr["RadEmer_V"]),
                        RadEmer_E = Convert.ToBoolean(dr["RadEmer_E"]),
                        EquipSobrev_P = Convert.ToBoolean(dr["EquipSobrev_P"]),
                        EquipSobrev_D = Convert.ToBoolean(dr["EquipSobrev_D"]),
                        EquipSobrev_M = Convert.ToBoolean(dr["EquipSobrev_M"]),
                        EquipSobrev_J = Convert.ToBoolean(dr["EquipSobrev_J"]),
                        VestSobrev_L = Convert.ToBoolean(dr["VestSobrev_L"]),
                        VestSobrev_F = Convert.ToBoolean(dr["VestSobrev_F"]),
                        VestSobrev_U = Convert.ToBoolean(dr["VestSobrev_U"]),
                        VestSobrev_V = Convert.ToBoolean(dr["VestSobrev_V"]),
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
                string StrQuery = "insert into pvoo(Destinat, HorApre, Remet, Complem, Prefix, RegraVoo, TipoVoo, NAvioes, TipoAviao, CatEstTurb, EquipCap, AerodPart, Hora, VelCruz, NvlCruz, Rota, AeroDest, DurTotVoo, AeroAlt, AeroRes, OutrosDados, Autonomia, PessBordo, RadEmer_U, RadEmer_V, RadEmer_E, EquipSobrev_P, EquipSobrev_D, EquipSobrev_M, EquipSobrev_J, VestSobrev_L, VestSobrev_F, VestSobrev_U, VestSobrev_V, QuantBotes, CapBotes, CorBotes, CorAviao, Observ, Pilot) values(";
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
                StrQuery += "'" + pvoo.RadEmer_U + "',";
                StrQuery += "'" + pvoo.RadEmer_V + "',";
                StrQuery += "'" + pvoo.RadEmer_E + "',";
                StrQuery += "'" + pvoo.EquipSobrev_P + "',";
                StrQuery += "'" + pvoo.EquipSobrev_D + "',";
                StrQuery += "'" + pvoo.EquipSobrev_M + "',";
                StrQuery += "'" + pvoo.EquipSobrev_J + "',";
                StrQuery += "'" + pvoo.VestSobrev_L + "',";
                StrQuery += "'" + pvoo.VestSobrev_F + "',";
                StrQuery += "'" + pvoo.VestSobrev_U + "',";
                StrQuery += "'" + pvoo.VestSobrev_V + "',";
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
            StrQuery += "idPVoo = " + Id + ";";

            using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
            {
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    PVoo pvoo = new PVoo();
                    pvoo.idPVoo = Convert.ToInt32(dr["idPVoo"]);
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
                    pvoo.RadEmer_U = Convert.ToBoolean(dr["RadEmer_U"]);
                    pvoo.RadEmer_V = Convert.ToBoolean(dr["RadEmer_V"]);
                    pvoo.RadEmer_E = Convert.ToBoolean(dr["RadEmer_E"]);
                    pvoo.EquipSobrev_P = Convert.ToBoolean(dr["EquipSobrev_P"]);
                    pvoo.EquipSobrev_D = Convert.ToBoolean(dr["EquipSobrev_D"]);
                    pvoo.EquipSobrev_M = Convert.ToBoolean(dr["EquipSobrev_M"]);
                    pvoo.EquipSobrev_J = Convert.ToBoolean(dr["EquipSobrev_J"]);
                    pvoo.VestSobrev_L = Convert.ToBoolean(dr["VestSobrev_L"]);
                    pvoo.VestSobrev_F = Convert.ToBoolean(dr["VestSobrev_F"]);
                    pvoo.VestSobrev_U = Convert.ToBoolean(dr["VestSobrev_U"]);
                    pvoo.VestSobrev_V = Convert.ToBoolean(dr["VestSobrev_V"]);
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
        public ActionResult Editar(PVoo pvoo)
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
                StrQuery += "RadEmer_U = '" + pvoo.RadEmer_U + "', ";
                StrQuery += "RadEmer_V = '" + pvoo.RadEmer_V + "', ";
                StrQuery += "RadEmer_E = '" + pvoo.RadEmer_E + "', ";
                StrQuery += "EquipSobrev_P = '" + pvoo.EquipSobrev_P + "', ";
                StrQuery += "EquipSobrev_D = '" + pvoo.EquipSobrev_D + "', ";
                StrQuery += "EquipSobrev_M = '" + pvoo.EquipSobrev_M + "', ";
                StrQuery += "EquipSobrev_J = '" + pvoo.EquipSobrev_J + "', ";
                StrQuery += "VestSobrev_L = '" + pvoo.VestSobrev_L + "', ";
                StrQuery += "VestSobrev_F = '" + pvoo.VestSobrev_F + "', ";
                StrQuery += "VestSobrev_U = '" + pvoo.VestSobrev_U + "', ";
                StrQuery += "VestSobrev_V = '" + pvoo.VestSobrev_V + "', ";
                StrQuery += "QuantBotes = '" + pvoo.QuantBotes + "', ";
                StrQuery += "CapBotes = '" + pvoo.CapBotes + "', ";
                StrQuery += "CorBotes = '" + pvoo.CorBotes + "', ";
                StrQuery += "CorAviao = '" + pvoo.CorAviao + "', ";
                StrQuery += "Observ = '" + pvoo.Observ + "', ";
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
                    pvoo.idPVoo = Convert.ToInt32(dt["idPVoo"]);
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
                    pvoo.RadEmer_U = Convert.ToBoolean(dt["RadEmer_U"]);
                    pvoo.RadEmer_V = Convert.ToBoolean(dt["RadEmer_V"]);
                    pvoo.RadEmer_E = Convert.ToBoolean(dt["RadEmer_E"]);
                    pvoo.EquipSobrev_P = Convert.ToBoolean(dt["EquipSobrev_P"]);
                    pvoo.EquipSobrev_D = Convert.ToBoolean(dt["EquipSobrev_D"]);
                    pvoo.EquipSobrev_M = Convert.ToBoolean(dt["EquipSobrev_M"]);
                    pvoo.EquipSobrev_J = Convert.ToBoolean(dt["EquipSobrev_J"]);
                    pvoo.VestSobrev_L = Convert.ToBoolean(dt["VestSobrev_L"]);
                    pvoo.VestSobrev_F = Convert.ToBoolean(dt["VestSobrev_F"]);
                    pvoo.VestSobrev_U = Convert.ToBoolean(dt["VestSobrev_U"]);
                    pvoo.VestSobrev_V = Convert.ToBoolean(dt["VestSobrev_V"]);
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
                StrQuery += " where idPVoo = " + pvoo.idPVoo + ";";
                using (MySqlCommand comando = new MySqlCommand(StrQuery, conexao.conn))
                {
                    comando.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }
        }
    }
}