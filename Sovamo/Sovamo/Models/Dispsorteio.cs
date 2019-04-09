using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sovamo.Models
{
    public enum Dispsorteio
    {
        
        [Display(Name =  "Sim")]
        Sim,
        [Display(Description = "Não")]
        Nao,
    }
}