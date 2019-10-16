using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeFuncionarios.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Nome { get; set; }

        public virtual IList<Funcionario> Funcionarios { get; set; }
        
    }
}
