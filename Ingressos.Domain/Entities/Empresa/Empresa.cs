using Ingressos.Domain.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Entities.Empresa
{
    public class Empresa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public Endereco Endereco { get; set; }  

    }
}
