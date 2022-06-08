using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Model.Retorno;
using Ingressos.Domain.Entities.EventoEntites;
using Ingressos.Domain.Model.Entrada;

namespace Ingressos.Domain.Services.EventoServices
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly IEmpresaService _empresaService;
        public EventoService(IEventoRepository eventoRepository, IEmpresaService empresaService)
        {
            _eventoRepository = eventoRepository;
            _empresaService = empresaService;
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

        public EventoRetornoModel CadastrarEvento(EventoModel eventoModel)
        {
            try
            {
                var empresa = _empresaService.ConsultarPorId(eventoModel.IdEmpresa);
                if (empresa.Empresa == null)
                {
                    return new EventoRetornoModel()
                    {
                        IsSucesso = false,
                        Mensagem = "Não foi possível cadastrar o evento, empresa não encontrada."
                    };

                }
                var evento = (Evento)eventoModel;
                evento.Instituicao = empresa.Empresa;

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
                var evento = (EventoListRetornoModel)_eventoRepository.ConsultarEvento();
                if (evento.Evento == null)
                {
                    evento.Mensagem = "Evento nao encontrado.";
                }

                return evento;


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
                var evento = (EventoRetornoModel)_eventoRepository.ConsultarPorId(idEvento);
                if (evento.Evento == null)
                {
                    evento.Mensagem = "Evento nao encontrado.";
                }

                return evento;

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
