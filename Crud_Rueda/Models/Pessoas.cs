using System;
using System.Collections.Generic;

namespace Crud_Rueda.Models
{
    public partial class Pessoas
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public double? Salario { get; set; }
    }
}
