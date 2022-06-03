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
        public Endereco() { }

        //public Endereco(int numeroCep, string bairro, string logradouro, string numero, string complemento, string estado, string municipio)
        //{
        //    Id = Guid.NewGuid();
        //    NumeroCep = numeroCep;
        //    Bairro = bairro?.Trim();
        //    Logradouro = logradouro?.Trim();
        //    Numero = numero?.Trim();
        //    Complemento = complemento?.Trim();
        //    Estado = estado;
        //    Municipio = municipio;
        //}
    }
}
