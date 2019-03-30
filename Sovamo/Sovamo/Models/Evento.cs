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
        public string Nome { get; set; }
        public string Atracao { get; set; }
        public EstiloMusical EstiloMusical { get; set; }
        public string Descricao { get; set; }
    }
}
