using Ingressos.Domain.Interfaces.Services;

using Ingressos.Domain.Entities.Instituicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Data.Context;
using Microsoft.EntityFrameworkCore;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Entities.EventoIngresso;

namespace Ingressos.Data.Repository.Instituicao
{
    public class EventoRepository : IEventoRepository
    {
        private readonly IngresssosContext _context;

        public EventoRepository(IngresssosContext context)
        {
            _context = context;
        }
        public Evento AlterarEvento(Evento empresa)
        {
            _context.Entry(empresa).State = EntityState.Modified;
            _context.Update(empresa);
            _context.SaveChanges();

            return empresa;
        }

        public Evento CadastrarEvento(Evento evento)
        {
            _context.Add(evento);
            _context.SaveChanges();
            return evento;
        }

        public List<Evento> ConsultarEvento()
        {
            var response = _context.Evento.Include(x => x.Endereco).
                                           Include(x => x.Instituicao).ThenInclude(x => x.Endereco).ToList();
            return response;

        }

        public Evento ConsultarPorId(Guid IdEvento)
        {
            var response = _context.Evento.Include(x => x.Endereco).
                                           Include(x => x.Instituicao).ThenInclude(x => x.Endereco).FirstOrDefault(x => x.Id == IdEvento);

            return response;

        }

        public string ExcluirEvento(Guid IdEvento)
        {
            var evento = ConsultarPorId(IdEvento);
            if (evento != null)
            {
                _context.Evento.Remove(evento);
                _context.SaveChanges();
                return "Empresa excluída com sucesso!";
            }
            else
            {
                throw new Exception("Id informado não encotrado!");
            }
        }
    }
}
