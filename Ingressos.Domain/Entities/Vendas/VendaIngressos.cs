using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;

namespace Ingressos.Domain.Entities.Vendas

{
    public class VendaIngressos
    {
        public Guid Id { get; set; }
        public IngressosEventos Ingressos { get; set; }
        public Venda venda { get; set; }
    }
}
