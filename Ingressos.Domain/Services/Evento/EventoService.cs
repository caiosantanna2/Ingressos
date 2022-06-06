using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Entities.EventoIngresso;

namespace Ingressos.Domain.Services.EventoServices
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository _eventoRepository;
        public EventoService(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public Evento AlterarEvento(Evento evento)
        {
            return _eventoRepository.AlterarEvento(evento);
        }

        public Evento CadastrarEvento(Evento evento)
        {
            return _eventoRepository.CadastrarEvento(evento);
        }

        public List<Evento> ConsultarEventos()
        {
            return _eventoRepository.ConsultarEvento();

        }

        public Evento ConsultarPorId(Guid idEvento)
        {
            return _eventoRepository.ConsultarPorId(idEvento);
        }

        public string ExcluirEvento(Guid idEvento)
        {
            return _eventoRepository.ExcluirEvento(idEvento); 
        }
    }
}
