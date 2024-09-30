using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RegistrarUsuarios.Context;
using RegistrarUsuarios.Models;


namespace RegistrarUsuarios.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly NovoFuncionario _context;

        public FuncionarioController(NovoFuncionario context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var funcionarios = _context.Funcionarios.ToList();
            return View(funcionarios);
        }

        public IActionResult Criar()
        {
            var model = new FuncionarioList
            {
                TipoAcesso = GetTipos(),
                Funcionario = new Funcionario()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Criar(FuncionarioList funcionarioList)
        {
            if (ModelState.IsValid)
            {
                _context.Funcionarios.Add(funcionarioList.Funcionario);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Usuário criado com sucesso!";
                return RedirectToAction(nameof(Index));
            }

            funcionarioList.TipoAcesso = GetTipos();
            return View(funcionarioList);
        }

        public IActionResult Informacoes(int id)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(f => f.Id == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            var model = new FuncionarioList
            {
                Funcionario = funcionario,
                TipoAcesso = GetTipos(),
            };

            return View(model);

        }

        public IActionResult Editar(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var model = new FuncionarioList
            {
                Funcionario = funcionario,
                TipoAcesso = GetTipos(),

            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Editar(FuncionarioList funcionarioList)
        {
            if (ModelState.IsValid)
            {
                var funcionarioBanco = _context.Funcionarios.Find(funcionarioList.Funcionario.Id);

                if (funcionarioBanco != null)
                {
                    funcionarioBanco.Nome = funcionarioList.Funcionario.Nome;
                    funcionarioBanco.Email = funcionarioList.Funcionario.Email;
                    funcionarioBanco.SenhaEmail = funcionarioList.Funcionario.SenhaEmail;
                    funcionarioBanco.Tipo = funcionarioList.Funcionario.Tipo;
                    funcionarioBanco.Senha = funcionarioList.Funcionario.Senha;
                    funcionarioBanco.Departamento = funcionarioList.Funcionario.Departamento;
                    funcionarioBanco.Cargo = funcionarioList.Funcionario.Cargo;

                    _context.Funcionarios.Update(funcionarioBanco);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
            }

            funcionarioList.TipoAcesso = GetTipos();
            return View(funcionarioList);
        }

        public IActionResult Deletar(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        [HttpPost]
        public IActionResult DeletarConfirmado(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return RedirectToAction(nameof(Index));
            }

            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        private List<SelectListItem> GetTipos()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "", Text = "Selecione o tipo de acesso" },
                new SelectListItem { Value = "Usuário de rede", Text = "Usuário de rede" },
                new SelectListItem { Value = "Sistema - 1", Text = "Sistema - 1" },
                new SelectListItem { Value = "Sistema - 1 e Sistema 2", Text = "Sistema - 2 e Sistema - 2" },
                new SelectListItem { Value = "VPN", Text = "VPN" }
            };
        }
    }
}
