
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _context.Funcionarios.Add(funcionario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }
        public IActionResult Informacoes(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);

            if (funcionario == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }
        public IActionResult Editar(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(funcionario);
        }
        [HttpPost]
        public IActionResult Editar(Funcionario funcionario)
        {
            var funcionarioBanco = _context.Funcionarios.Find(funcionario.Id);

            funcionarioBanco.Nome = funcionario.Nome;
            funcionarioBanco.Email= funcionario.Email;
            funcionarioBanco.Departamento = funcionario.Departamento;
            funcionarioBanco.UsuarioDeRede = funcionario.UsuarioDeRede;
            funcionarioBanco.Cargo = funcionario.Cargo;

            _context.Funcionarios.Update(funcionarioBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public  IActionResult Deletar(int id)
        {
            var funcionario =_context.Funcionarios.Find(id);

            if ( funcionario == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        [HttpPost]
        public IActionResult DeletarConfirmado(int id)
        {
            var funcionario =_context.Funcionarios.Find(id);

            if(funcionario == null)
            {
                return RedirectToAction(nameof(Index));
            }
            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }

}