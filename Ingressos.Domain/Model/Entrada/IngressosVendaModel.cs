
using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Model.Entrada
{
    public class IngressosVendaModel
    {
      
        public Guid IngressoId { get; set; }    
        public int Quantidade { get; set; }
        public double ValorVendido { get; set; }
    }
}
