using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrarUsuarios.Models
{
    public class Login
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O 'Usuário' é obrigatório.")]
        public string Usuario {get; set;}

        public string Senha {get; set;}
    }
}