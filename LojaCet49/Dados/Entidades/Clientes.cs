using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCet49.Dados.Entidades
{
    public class Clientes
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Morada")]
        public string Morada { get; set; }

        [Display(Name = "Profissão")]
        public string Profissão { get; set; }
    }
}
