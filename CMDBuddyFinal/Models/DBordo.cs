using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMDBuddyFinal.Models
{
    public class DBordo
    {
        public int IdBordo { get; set; }
        public int NumeroTripulantes { get; set; }
        public string NomeTripulantes { get; set; }
        public string Hora { get; set; }
        public string Marca { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string NS { get; set; }
        public string CatReg { get; set; }
        public int HoraCelAnt { get; set; }
        public int HoraCelPag { get; set; }
        public int TotHoraCel { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string HorPart { get; set; }
        public string HorDecolagem { get; set; }
        public string HorPouso { get; set; }
        public string HorCor { get; set; }
        public string HorDiurno { get; set; }
        public string HorNoturno { get; set; }
        public string HorIFRR { get; set; }
        public string HorIFRC { get; set; }
        public string HorTotal { get; set; }
        public string CombustTotal { get; set; }
        public string Ocorrencias { get; set; }
    }
}