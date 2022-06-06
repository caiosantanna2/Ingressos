using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.Vendas;
using System;
using System.Collections.Generic;

namespace Ingressos.Domain.Entities.Vendas

{
    public class Venda
    {
        public Guid Id { get; set; }
        public double ValorVenda { get; set; }
        public DateTime? DataVenda { get; set; }
        public bool IsAtiva { get; set; } = true;
        public string TransacaoPagamento { get; set; }
        public List<IngressosPessoas> Ingressos { get; set; }
  
    }
}
