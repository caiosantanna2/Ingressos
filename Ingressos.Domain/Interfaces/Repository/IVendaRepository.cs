using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.Vendas;
using Ingressos.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Repository
{
    public interface IVendaRepository
    {

        Venda RealizaVenda(Venda Venda);
        Venda ConsultarVenda( Guid IdVenda);
        Venda CancelarVenda(Venda venda);
      


    }
}
