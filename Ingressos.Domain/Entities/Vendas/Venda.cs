using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.Vendas;
using System;

namespace Ingressos.Domain.Entities.Vendas

{
    public class Venda
    {
        public Guid Id { get; set; }
        public Pessoa pessoa { get; set; }
        public VendaIngressos vendaIngresso { get; set; }

    }
}
