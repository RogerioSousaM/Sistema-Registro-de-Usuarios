using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistrarUsuarios.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Nome não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "O E-mail fornecido não é válido.")]
        [StringLength(255, ErrorMessage = "O E-mail não pode exceder 255 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Departamento é obrigatório.")]
        [StringLength(50, ErrorMessage = "O Departamento não pode exceder 50 caracteres.")]
        public string Departamento { get; set; }

        [Required(ErrorMessage = "O Usuário de Rede é obrigatório.")]
        [StringLength(50, ErrorMessage = "O Usuário de Rede não pode exceder 50 caracteres.")]
        public string UsuarioDeRede { get; set; }

        [Required(ErrorMessage = "O Cargo é obrigatório.")]
        [StringLength(50, ErrorMessage = "O Cargo não pode exceder 50 caracteres.")]
        public string Cargo { get; set; }
    }
}
