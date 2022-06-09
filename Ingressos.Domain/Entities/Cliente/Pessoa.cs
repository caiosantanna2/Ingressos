using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Ingressos.Domain.Entities.Enderecos;

namespace Ingressos.Domain.Entities.Cliente
{
    public class Pessoa
    {
        
        public Guid Id { get; set; }
        public string Nome { get; set; }
     
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
    }
}
