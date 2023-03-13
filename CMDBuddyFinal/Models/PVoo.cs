using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMDBuddyFinal.Models
{
    public class PVoo
    {
        public int idPVoo { get; set; }
        public string Destinat { get; set; }
        public string HorApre { get; set; }
        public string Remet { get; set; }
        public string Complem { get; set; }
        public string Prefix { get; set; }
        public string RegraVoo { get; set; }
        public string TipoVoo { get; set; }
        public string NAvioes { get; set; }
        public string TipoAviao { get; set; }
        public string CatEstTurb { get; set; }
        public string EquipCap { get; set; }
        public string AerodPart { get; set; }
        public string Hora { get; set; }
        public string VelCruz { get; set; }
        public string NvlCruz { get; set; }
        public string Rota { get; set; }
        public string AeroDest { get; set; }
        public string DurTotVoo { get; set; }
        public string AeroAlt { get; set; }
        public string AeroRes { get; set; }
        public string OutrosDados { get; set; }
        public string Autonomia { get; set; }
        public string PessBordo { get; set; }
        public string RadEmer { get; set; }
        public bool EquipSobrev { get; set; }
        public bool VestSobrev { get; set; }
        public string QuantBotes { get; set; }
        public string CapBotes { get; set; }
        public string CorBotes { get; set; }
        public string CorAviao { get; set; }
        public string Observ { get; set; }
        public string Pilot { get; set; }
    }
}