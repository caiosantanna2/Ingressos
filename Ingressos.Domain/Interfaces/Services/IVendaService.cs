using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.Vendas;
using Ingressos.Domain.Model.Entrada;
using Ingressos.Domain.Model.Retorno;
using System;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IVendaService
    {
        VendaRetornoModel RealizaVenda(VendaModel venda);
        VendaRetornoModel ConsultarVenda( Guid idVenda);
        VendaRetornoModel CancelarVenda(Guid idVenda);

    }
}
