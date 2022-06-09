using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Entities.Enderecos
{
    public class Endereco
    {
        public Guid Id { get; set; }
        public int NumeroCep { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        
    }
}
