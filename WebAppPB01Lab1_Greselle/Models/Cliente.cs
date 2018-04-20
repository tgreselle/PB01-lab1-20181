using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPB01Lab1_Greselle.Models
{
    public class Cliente


   
    {
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "Nome é obrigatorio") ]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF é obrigatorio")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Email é obrigatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data é obrigatorio")]
        public DateTime DataCadastro { get; set; }

    }
}
