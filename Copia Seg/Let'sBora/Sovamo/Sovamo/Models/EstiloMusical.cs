using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sovamo.Models
{

    public enum EstiloMusical
    {
        [Display(Name = "")]
        Aleatorio,
        [Display(Name = "Rock")]
        Rock,
        [Display(Name = "Sertanejo")]
        Sertanejo,
        [Display(Name = "Funk")]
        Funk,
        [Display(Name = "Reggae")]
        Reggae,
        [Display(Name = "Retro")]
        Retro,
        [Display(Name = "MPB")]
        MPB,
        [Display(Name = "Eletronica")]
        Eletronica,
        

    }

}