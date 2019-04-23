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
        [Display(Name = "Blues")]
        Blues,
        [Display(Name = "Sertanejo")]
        Sertanejo,
        [Display(Name = "Funk")]
        Funk,
        [Display(Name = "Reggae")]
        Reggae,
        [Display(Name = "Jazz")]
        Jazz,
        [Display(Name = "Raiz")]
        Raiz,
        [Display(Name = "MPB")]
        MPB,
        [Display(Name = "Eletronica")]
        Eletronica,
        [Display(Name = "Acustico")]
        Acustico,

    }

}