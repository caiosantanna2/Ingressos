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
using Ingressos.Domain.Model.Retorno;

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

        public IngressosEventosRetornoModel AlterarIngresosEvento(IngressosEventos evento)
        {
            return _ingressoRepository.AlterarIngresosEvento(evento);
        }

        public IngressosEventosRetornoModel CadastrarIngressoEvento(IngressosModel ingressso)
        {
            try
            {
                var evento = _eventoRepository.ConsultarPorId(ingressso.IdEvento);
               
                if (evento == null)
                {
                    return new IngressosEventosRetornoModel()
                    {
                        IsSucesso = false,
                        Mensagem = "Não foi possível cadastrar o ingresso, evento não encontrado."
                    };

                }

                IngressosEventos ingressosEventos = ingressso;
                ingressosEventos.Evento = evento;

                return _ingressoRepository.CadastrarIngressoEvento(ingressosEventos);
            }
            catch (Exception)
            {

                return new IngressosEventosRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cadastrar ingresso"
                };
            }
            
        }

        public IngressosEventosListRetornoModel ConsultaIngresosPorEvento(Guid idEvento)
        {
            try
            {
                return _ingressoRepository.ConsultaIngresosPorEvento(idEvento);
            }
            catch (Exception)
            {

                return new IngressosEventosListRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cadastrar ingresso"
                };
            }
        }
        

        public IngressosEventosRetornoModel ConsultaIngresosPorId(Guid idIngresso)
        {
            try
            {
                return _ingressoRepository.ConsultaIngresosPorId(idIngresso);
            }
            catch (Exception)
            {

                return new IngressosEventosRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cadastrar ingresso"
                };
            }
           
        }

        public IngressosPessoasListRetornoModel ConsultarIngressosPessoa(Guid idPessoa)
        {
            try
            {
                return _ingressoRepository.ConsultarIngressosPessoa(idPessoa);
            }
            catch (Exception)
            {


                return new IngressosPessoasListRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cadastrar ingresso"
                };
            }
           
        }

        public IngressosPessoasListRetornoModel ConsultarIngressosPessoaEvento(Guid idPessoa, Guid idEvento)
        {
            try
            {
                return _ingressoRepository.ConsultarIngressosPessoaEvento(idPessoa, idEvento);
            }
            catch (Exception)
            {

                return new IngressosPessoasListRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cadastrar ingresso"
                };
            }
           
        }

        public IngressosEventosRetornoModel ExcluirIngressoEvento(Guid idEvento)
        {
            try
            {
                return new IngressosEventosRetornoModel
                {
                    Mensagem = _ingressoRepository.ExcluirIngressoEvento(idEvento)
                };
            }
            catch (Exception)
            {
                //Capturar log
                return new IngressosEventosRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao excluir pessoa"
                };

            }
           
        }
    }
}
