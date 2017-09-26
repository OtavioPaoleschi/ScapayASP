using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAM2017_ASP.Models
{
    public class Noticia
    {
        [Display(Name = "Código")]
        public int Codigo { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Texto")]
        public string Texto { get; set; }
    }
}