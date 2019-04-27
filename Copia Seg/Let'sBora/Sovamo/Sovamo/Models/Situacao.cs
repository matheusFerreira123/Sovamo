using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sovamo.Models
{
    public enum Situacao
    {
        [Display(Name = "Não Informado")]
        NaoInformado,
        [Display(Name = "Aberto")]
        Aberto,
        [Display(Name = "Fechado")]
        Fechado,
    }
}