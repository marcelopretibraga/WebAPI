using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}
