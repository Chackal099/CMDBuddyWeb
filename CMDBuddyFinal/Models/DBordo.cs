using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace CMDBuddyFinal.Models
{
    public class DBordo
    {
        public int IdBordo { get; set; }
        [Display(Name = "Número de Tripulantes")]
        public int NumeroTripulantes { get; set; }
        [Display(Name = "Nome dos Tripulantes")]
        public string NomeTripulantes { get; set; }
        [Display(Name = "Hora")]
        public string Hora { get; set; }
        [Display(Name = "Marca do Avião")]
        public string Marca { get; set; }
        [Display(Name = "Fabricante do Avião")]
        public string Fabricante { get; set; }
        [Display(Name = "Modelo do Avião")]
        public string Modelo { get; set; }
        [Display(Name = "Número de Série")]
        public string NS { get; set; }
        [Display(Name = "Categoria Registrada")]
        public string CatReg { get; set; }
        [Display(Name = "Horas da Célula Anterior")]
        public int HoraCelAnt { get; set; }
        [Display(Name = "Horas Totais da Página na Célula")]
        public int HoraCelPag { get; set; }
        [Display(Name = "Total Horas pela Célula")]
        public int TotHoraCel { get; set; }
        [Display(Name = "Aeródromo de Origem")]
        public string Origem { get; set; }
        [Display(Name = "Aeródromo de Destino")]
        public string Destino { get; set; }
        [Display(Name = "Horário de Partida")]
        public string HorPart { get; set; }
        [Display(Name = "Horário de Decolagem")]
        public string HorDecolagem { get; set; }
        [Display(Name = "Horário de Pouso")]
        public string HorPouso { get; set; }
        [Display(Name = "Horas Corrigidas")]
        public string HorCor { get; set; }
        [Display(Name = "Horas Diurnas")]
        public string HorDiurno { get; set; }
        [Display(Name = "Horas Noturnas")]
        public string HorNoturno { get; set; }
        [Display(Name = "Horas com IFRR")]
        public string HorIFRR { get; set; }
        [Display(Name = "Horas com IFRC")]
        public string HorIFRC { get; set; }
        [Display(Name = "Horas Totais")]
        public string HorTotal { get; set; }
        [Display(Name = "Combustíveis Totais")]
        public string CombustTotal { get; set; }
        [Display(Name = "Ocorrências")]
        public string Ocorrencias { get; set; }
    }
}