using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Model.Retorno;

namespace Ingressos.Domain.Services.EventoServices
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository _eventoRepository;
        public EventoService(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public EventoRetornoModel AlterarEvento(Evento evento)
        {
            try
            {

                return _eventoRepository.AlterarEvento(evento);
            }
            catch (Exception)
            {

                return new EventoRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao alterar evento"
                };
            }
        }

        public EventoRetornoModel CadastrarEvento(Evento evento)
        {
            try
            {

                return _eventoRepository.CadastrarEvento(evento);
            }
            catch (Exception)
            {

                return new EventoRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cadastrar evento"
                };
            }
        }

        public EventoListRetornoModel ConsultarEventos()
        {
            try
            {
                return _eventoRepository.ConsultarEvento();

            }
            catch (Exception)
            {

                return new EventoListRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao consultar eventos"
                };
            }

        }

        public EventoRetornoModel ConsultarPorId(Guid idEvento)
        {
            try
            {
                return _eventoRepository.ConsultarPorId(idEvento);

            }
            catch (Exception)
            {

                return new EventoRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao consultar evento"
                };
            }
        }

        public EventoRetornoModel ExcluirEvento(Guid idEvento)
        {
            try
            {
                return new EventoRetornoModel
                {
                    Mensagem = _eventoRepository.ExcluirEvento(idEvento)
                };
              
            }
            catch (Exception)
            {

                return new EventoRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao realizar venda"
                };
            }
        }
    }
}
