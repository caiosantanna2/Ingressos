
using Ingressos.Domain.Entities.Cliente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Data.Context;
using Microsoft.EntityFrameworkCore;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.Vendas;

namespace Ingressos.Data.Repository.VendaRepository
{
    public class VendaRepository : IVendaRepository
    {

        private readonly IngresssosContext _context;

        public VendaRepository(IngresssosContext context)
        {
            _context = context;
        }

        public Venda CancelarVenda(Venda venda)
        {
            _context.Entry(venda).State = EntityState.Modified;
            _context.Update(venda);
            _context.SaveChanges();

            return venda;
        }

        public Venda ConsultarVenda(Guid IdVenda)
        {
            var response = _context.Venda.Include(x => x.Ingressos).ThenInclude(x => x.Pessoa).
                                          Include(x => x.Ingressos).ThenInclude(x => x.Ingresso).ThenInclude(x => x.Evento).FirstOrDefault(x => x.Id == IdVenda);
            return response;
        }

        public Venda RealizaVenda(Venda Venda)
        {
            _context.Add(Venda);
            _context.SaveChanges();
            return Venda;
        }

       
    }
}
