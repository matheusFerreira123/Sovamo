using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sovamo.Models
{
    public class CadCliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}