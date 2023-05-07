using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace CMDBuddyFinal.Models
{
    public class PVoo
    {
        public int idPVoo { get; set; }
        [Display(Name = "Destinatário")]
        public string Destinat { get; set; }
        [Display(Name = "Hora de Apresentação")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string HorApre { get; set; }
        [Display(Name = "Remetente")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Remet { get; set; }
        [Display(Name = "Complemento")]
        public string Complem { get; set; }
        [Display(Name = "Prefixo")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Prefix { get; set; }
        [Display(Name = "Regra de Voo")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string RegraVoo { get; set; }
        [Display(Name = "Tipo de Voo")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string TipoVoo { get; set; }
        [Display(Name = "Número de Aviões")]
        public string NAvioes { get; set; }
        [Display(Name = "Tipo de Avião")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string TipoAviao { get; set; }
        [Display(Name = "Categoria de Esteira de Turbulência")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string CatEstTurb { get; set; }
        [Display(Name = "Equipamento e Capacidades")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string EquipCap { get; set; }
        [Display(Name = "Aeródromo de Partida")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string AerodPart { get; set; }
        [Display(Name = "Hora")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Hora { get; set; }
        [Display(Name = "Velocidade de Cruzeiro")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string VelCruz { get; set; }
        [Display(Name = "Nivel de Cruzeiro")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string NvlCruz { get; set; }
        [Display(Name = "Rota")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Rota { get; set; }
        [Display(Name = "Aeródromo de Destino")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string AeroDest { get; set; }
        [Display(Name = "Duração Total do Voo")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string DurTotVoo { get; set; }
        [Display(Name = "Aeródromo Alternativo")]
        public string AeroAlt { get; set; }
        [Display(Name = "Aeródromo Reserva")]
        public string AeroRes { get; set; }
        [Display(Name = "Outros Dados")]
        public string OutrosDados { get; set; }
        [Display(Name = "Autonomia")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Autonomia { get; set; }
        [Display(Name = "Pessoas a Bordo")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string PessBordo { get; set; }
        [Display(Name = "Rádio de Emergência")]
        public bool RadEmer { get; set; }
        public bool RadEmer_U { get; set; }
        public bool RadEmer_V { get; set; }
        public bool RadEmer_E { get; set; }
        [Display(Name = "Equipamento de Emergência")]
        public bool EquipSobrev { get; set; }
        public bool EquipSobrev_P { get; set; }
        public bool EquipSobrev_D { get; set; }
        public bool EquipSobrev_M { get; set; }
        public bool EquipSobrev_J { get; set; }
        [Display(Name = "Vestes de Sobrevivência")]
        public bool VestSobrev { get; set; }
        public bool VestSobrev_L { get; set; }
        public bool VestSobrev_F { get; set; }
        public bool VestSobrev_U { get; set; }
        public bool VestSobrev_V { get; set; }
        [Display(Name = "Quantidade de Botes de Sobrevivência")]
        public string QuantBotes { get; set; }
        [Display(Name = "Capacidade de Botes de Sobrevivência")]
        public string CapBotes { get; set; }
        [Display(Name = "Cor dos Botes de Sobrevivência")]
        public string CorBotes { get; set; }
        [Display(Name = "Cor do Avião")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string CorAviao { get; set; }
        [Display(Name = "Observações")]
        public string Observ { get; set; }
        [Display(Name = "Piloto")]
        [Required(ErrorMessage = "Por favor, preencha este campo")]
        public string Pilot { get; set; }
    }
}