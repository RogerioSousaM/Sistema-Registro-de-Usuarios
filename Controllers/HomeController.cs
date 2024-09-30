using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using RegistrarUsuarios.Context;
using RegistrarUsuarios.Models;

namespace RegistrarUsuarios.Controllers;

public class HomeController : Controller
{
    private readonly NovoFuncionario _context;

    public HomeController(NovoFuncionario context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Login login)
    {
    if (ModelState.IsValid)
    {
       var senhaHash = HashPassword(login.Senha);
       var usuario = _context.Logins
       .FirstOrDefault(u => u.Usuario == login.Usuario && u.Senha == senhaHash);

        if (usuario != null)
           {
             TempData["SuccessMessage"] = "Login realizado com sucesso!";
             return RedirectToAction("Index", "Funcionario");
           }
            else
             {
                ModelState.AddModelError(string.Empty, "Tentativa de login inválida.");
             }
        }
                return View(login);
    }


    private string HashPassword(string senha)
    {
        using (var sha256 = SHA256.Create())
        {
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
