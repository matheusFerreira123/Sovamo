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
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string Senha { get; set; }
    }
}