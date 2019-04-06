using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sovamo.Models
{
    public class CadEstabelecimento
    {
        [Key]
        public int EstabelecimentoId { get; set; }
        public string Nome { get; set; }
        public string Razao { get; set; }
        public string CpfCliente { get; set; }
        public string Cnpj { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }
        public string Descricão { get; set; }
        public string horario { get; set; }
        [Display(Name = "Situação")]
        public Situacao Situacao { get; set; }


    }
}