using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sovamo.Models
{
    public class CadUsuario
    {
        [Key]
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "Preencha o nome completo.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter até {1} caracteres.")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Preencha o email.")]
        [Display(Name = "Email")]
        public String Email { get; set; }


        public String Telefone { get; set; }


        [Required(ErrorMessage = "Senha deve conter mais de 7 caracteres.")]
        [MinLength(7, ErrorMessage = "O senha deve conter  {1} caracteres.")]
        public String Senha { get; set; }


        [Required(ErrorMessage = "Escolha seu estilo. ")]
        [Display(Name = "Estilo Musical")]
        public EstiloMusical EstiloMusical { get; set; }

    }
}