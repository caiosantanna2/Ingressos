
using Ingressos.Domain.Entities.Enderecos;
using Ingressos.Domain.Entities.Instituicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Entities.EventoIngresso
{
    public class Evento
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataEvento { get; set; }
        public Empresa Instituicao { get; set; }
        public bool IsAtivo { get; set; }
       
    }
}
