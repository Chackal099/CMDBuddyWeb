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
        public string HorApre { get; set; }
        [Display(Name = "Remetente")]
        public string Remet { get; set; }
        [Display(Name = "Complemento")]
        public string Complem { get; set; }
        [Display(Name = "Prefixo")]
        public string Prefix { get; set; }
        [Display(Name = "Regra de Voo")]
        public string RegraVoo { get; set; }
        [Display(Name = "Tipo de Voo")]
        public string TipoVoo { get; set; }
        [Display(Name = "Número de Aviões")]
        public string NAvioes { get; set; }
        [Display(Name = "Tipo de Avião")]
        public string TipoAviao { get; set; }
        [Display(Name = "Categoria de Esteira de Turbulência")]
        public string CatEstTurb { get; set; }
        [Display(Name = "Equipamento e Capacidades")]
        public string EquipCap { get; set; }
        [Display(Name = "Aeródromo de Partida")]
        public string AerodPart { get; set; }
        [Display(Name = "Hora")]
        public string Hora { get; set; }
        [Display(Name = "Velocidade de Cruzeiro")]
        public string VelCruz { get; set; }
        [Display(Name = "Nivel de Cruzeiro")]
        public string NvlCruz { get; set; }
        [Display(Name = "Rota")]
        public string Rota { get; set; }
        [Display(Name = "Aeródromo de Destino")]
        public string AeroDest { get; set; }
        [Display(Name = "Duração Total do Voo")]
        public string DurTotVoo { get; set; }
        [Display(Name = "Aeródromo Alternativo")]
        public string AeroAlt { get; set; }
        [Display(Name = "Aeródromo Reserva")]
        public string AeroRes { get; set; }
        [Display(Name = "Outros Dados")]
        public string OutrosDados { get; set; }
        [Display(Name = "Autonomia")]
        public string Autonomia { get; set; }
        [Display(Name = "Pessoas a Bordo")]
        public string PessBordo { get; set; }
        [Display(Name = "Rádio de Emergência")]
        public bool RadEmer { get; set; }
        [Display(Name = "Equipamento de Emergência")]
        public bool EquipSobrev { get; set; }
        [Display(Name = "Vestes de Sobrevivência")]
        public bool VestSobrev { get; set; }
        [Display(Name = "Quantidade de Botes de Sobrevivência")]
        public string QuantBotes { get; set; }
        [Display(Name = "Capacidade de Botes de Sobrevivência")]
        public string CapBotes { get; set; }
        [Display(Name = "Cor dos Botes de Sobrevivência")]
        public string CorBotes { get; set; }
        [Display(Name = "Cor do Avião")]
        public string CorAviao { get; set; }
        [Display(Name = "Observações")]
        public string Observ { get; set; }
        [Display(Name = "Piloto")]
        public string Pilot { get; set; }
    }
}