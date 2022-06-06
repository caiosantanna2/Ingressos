using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.Vendas;
using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Model.Entrada
{
    public class VendaModel
    {
        private readonly IEventoService _eventoService;


        public Guid Id { get; set; }
        public double ValorVenda { get; set; }
        public DateTime? DataVenda { get; set; }
 
        public List<IngressosVendaModel> Ingressos { get; set; }
        public Guid PessoaId { get; set; }


        public static implicit operator Venda(VendaModel vendaModel)
        {
            Venda venda = new Venda();
            venda.DataVenda = vendaModel.DataVenda;
            venda.ValorVenda = vendaModel.ValorVenda;

            return venda;
        }
    }
   
}
