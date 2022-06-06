using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Model.Entrada;

namespace Ingressos.Domain.Services.Instituicao
{
    public class IngressoService : IIngressoService
    {
        private readonly IIngressoRepository _ingressoRepository;
        private readonly IEventoRepository _eventoRepository;



        public IngressoService(IIngressoRepository ingressoRepository, IEventoRepository eventoRepository)
        {
            _ingressoRepository = ingressoRepository;
            _eventoRepository = eventoRepository;
        }

        public IngressosEventos AlterarIngresosEvento(IngressosEventos evento)
        {
            return _ingressoRepository.AlterarIngresosEvento(evento);
        }

        public IngressosEventos CadastrarIngressoEvento(IngressosModel ingressso)
        {
            var evento = _eventoRepository.ConsultarPorId(ingressso.IdEvento);
            if (evento == null)
            {
                throw new Exception("Evento nao encotrado");

            }
            IngressosEventos ingressosEventos = ingressso;
            ingressosEventos.Evento = evento;

            return _ingressoRepository.CadastrarIngressoEvento(ingressosEventos);
        }

        public List<IngressosEventos> ConsultaIngresosPorEvento(Guid idEvento)
        {
            return _ingressoRepository.ConsultaIngresosPorEvento(idEvento);
        }

        public IngressosEventos ConsultaIngresosPorId(Guid idIngresso)
        {
            return _ingressoRepository.ConsultaIngresosPorId(idIngresso);
        }

        public List<IngressosPessoas> ConsultarIngressosPessoa(Guid idPessoa)
        {
            return _ingressoRepository.ConsultarIngressosPessoa(idPessoa);
        }

        public List<IngressosPessoas> ConsultarIngressosPessoaEvento(Guid idPessoa, Guid idEvento)
        {
            return _ingressoRepository.ConsultarIngressosPessoaEvento(idPessoa, idEvento);
        }

        public string ExcluirIngressoEvento(Guid idEvento)
        {
            return _ingressoRepository.ExcluirIngressoEvento(idEvento);
        }
    }
}
