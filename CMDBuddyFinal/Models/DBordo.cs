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
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public int NumeroTripulantes { get; set; }
        [Display(Name = "Nome dos Tripulantes")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string NomeTripulantes { get; set; }
        [Display(Name = "Horário")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Hora { get; set; }
        [Display(Name = "Marca do Avião")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Marca { get; set; }
        [Display(Name = "Fabricante do Avião")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Fabricante { get; set; }
        [Display(Name = "Modelo do Avião")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Modelo { get; set; }
        [Display(Name = "Número de Série")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string NS { get; set; }
        [Display(Name = "Categoria Registrada")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string CatReg { get; set; }
        [Display(Name = "Horas da Célula Anterior")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public float HoraCelAnt { get; set; }
        [Display(Name = "Horas Totais da Página na Célula")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public float HoraCelPag { get; set; }
        [Display(Name = "Total Horas pela Célula")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public float TotHoraCel { get; set; }
        [Display(Name = "Aeródromo de Origem")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Origem { get; set; }
        [Display(Name = "Aeródromo de Destino")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Destino { get; set; }
        [Display(Name = "Horário de Partida")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string HorPart { get; set; }
        [Display(Name = "Horário de Decolagem")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string HorDecolagem { get; set; }
        [Display(Name = "Horário de Pouso")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string HorPouso { get; set; }
        [Display(Name = "Horas Corrigidas")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string HorCor { get; set; }
        [Display(Name = "Horas Diurnas")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string HorDiurno { get; set; }
        [Display(Name = "Horas Noturnas")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string HorNoturno { get; set; }
        [Display(Name = "Horas com IFRR")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string HorIFRR { get; set; }
        [Display(Name = "Horas com IFRC")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string HorIFRC { get; set; }
        [Display(Name = "Horas Totais")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string HorTotal { get; set; }
        [Display(Name = "Combustíveis Totais")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string CombustTotal { get; set; }
        [Display(Name = "Ocorrências")]
        public string Ocorrencias { get; set; }
    }
}