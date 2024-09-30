using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using RegistrarUsuarios.Models;


namespace RegistrarUsuarios.Models
{
    public class FuncionarioList
    {
        public Funcionario Funcionario { get; set; }
        public List<SelectListItem> TipoAcesso { get; set; }
    }
}
