using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GerenciamentoDeFuncionarios.Models;

namespace GerenciamentoDeFuncionarios.Models
{
    public class FuncionariosContext : DbContext
    {
        public FuncionariosContext (DbContextOptions<FuncionariosContext> options)
            : base(options)
        {
        }

        public DbSet<GerenciamentoDeFuncionarios.Models.Departamento> Departamento { get; set; }

        public DbSet<GerenciamentoDeFuncionarios.Models.Funcionario> Funcionario { get; set; }
    }
}
