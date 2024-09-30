using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistrarUsuarios.Controllers;
using Microsoft.EntityFrameworkCore;
using RegistrarUsuarios.Models;

namespace RegistrarUsuarios.Context
{
    public class NovoFuncionario : DbContext
    {
        public NovoFuncionario(DbContextOptions<NovoFuncionario> options) : base(options)
        {

        }
        public DbSet<Funcionario> Funcionarios{get; set;}
        public DbSet<Login> Logins{get; set;}


         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
         }
    }
}