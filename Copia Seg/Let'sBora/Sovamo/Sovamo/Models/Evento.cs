using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sovamo.Models
{
    public class Evento
    {
        [Key]

        public int EventoId { get; set; }
        [Display(Name = "Nome do Evento")]
        public string Nome { get; set; }
        [Display(Name = "Atração")]
        public string Atracao { get; set; }
        [Display(Name = "Estilo Musical:")]
        public EstiloMusical EstiloMusical { get; set; }
        [Display(Name = "Descriçao do evento")]
        public string Descricao { get; set; }
        [Display(Name = "Data do evento")]
        public DateTime Dia { get; set; }
        [Display(Name = "Sorteio de ingressos")]
        public Dispsorteio Dispsorteio{ get; set; }
    }
}
