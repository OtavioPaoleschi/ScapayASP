using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAM2017_ASP.Models
{
    public class Cliente
    {
        
        public int Codigo { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Nome")]
        public string Nome  { get; set; }
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        [Display(Name = "Telefone")]
        public int Tel { get; set; }
    }
}