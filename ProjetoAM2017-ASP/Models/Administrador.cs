using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAM2017_ASP.Models
{
    public class Administrador
    {
        [Display(Name = "Usuário: ")]
        public string Usuario { get; set; }
        [Display(Name = "Senha: ")]
        public string Senha { get; set; }
    }
}