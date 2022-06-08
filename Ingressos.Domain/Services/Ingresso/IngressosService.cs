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
        private readonly IEventoService _eventoService;

        public IngressoService(IIngressoRepository ingressoRepository, IEventoService eventoService)
        {
            _ingressoRepository = ingressoRepository;
            _eventoService = eventoService;
        }

        public IngressosEventosRetornoModel AlterarIngresosEvento(IngressosEventos evento)
        {
            return _ingressoRepository.AlterarIngresosEvento(evento);
        }

        public IngressosEventosRetornoModel CadastrarIngressoEvento(IngressosModel ingresssoModel)
        {
            try
            {
                var evento = _eventoService.ConsultarPorId(ingresssoModel.IdEvento);

                if (evento.Evento == null)
                {
                    return new IngressosEventosRetornoModel()
                    {
                        IsSucesso = false,
                        Mensagem = "Não foi possível cadastrar o ingresso, evento não encontrado."
                    };

                }

                var ingressosEventos = (IngressosEventos)ingresssoModel;
                ingressosEventos.Evento = evento.Evento;

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

        public IngressosPessoasRetornoModel CancelarIngressoPessoa(Guid idIngressoPessoa)
        {
            try
            {
                var ingressosPessoa = _ingressoRepository.ConsultarIngressoPessoa(idIngressoPessoa);
                if (ingressosPessoa == null)
                {
                    return new IngressosPessoasRetornoModel()
                    {
                        IsSucesso = false,
                        Mensagem = "Ingresso nâo encontrado."
                    };
                }else if (ingressosPessoa.isAtivo)
                {
                    if (ingressosPessoa.isUtilizado)
                    {
                        return new IngressosPessoasRetornoModel()
                        {
                            IsSucesso = false,
                            Mensagem = "Ingresso já utilizado."
                        };
                    }
                    ingressosPessoa.Ingresso.QuantidadeDisponivel++;
                    ingressosPessoa.isAtivo = false;
                    return _ingressoRepository.EditarIngressoPessoa(ingressosPessoa);
                }
                else
                {
                    return new IngressosPessoasRetornoModel()
                    {
                        IsSucesso = false,
                        Mensagem = "Ingresso já cancelado."
                    };
                }
                


            }
            catch (Exception)
            {

                return new IngressosPessoasRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cancelar ingresso"
                };
            }
          
        }

        public IngressosEventosListRetornoModel ConsultaIngresosPorEvento(Guid idEvento)
        {
            try
            {
                var ingresso = (IngressosEventosListRetornoModel)_ingressoRepository.ConsultaIngresosPorEvento(idEvento);
                if (ingresso.IngressosEventos == null)
                {
                    ingresso.Mensagem = "Ingressos não encontrados.";
                }
                return ingresso;
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
                var ingresso = (IngressosEventosRetornoModel)_ingressoRepository.ConsultaIngresosPorId(idIngresso);
                if (ingresso.IngressosEventos == null)
                {
                    ingresso.Mensagem = "Ingresso não encontrado.";
                }

                return ingresso;


            }
            catch (Exception)
            {

                return new IngressosEventosRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cadastrar ingresso."
                };
            }

        }

        public IngressosPessoasRetornoModel ConsultarIngressoPessoa(Guid idIngressoPessoa)
        {
            try
            {
                var ingresso = (IngressosPessoasRetornoModel)_ingressoRepository.ConsultarIngressoPessoa(idIngressoPessoa);
                if (ingresso.IngressosPessoas == null)
                {
                    ingresso.Mensagem = "Ingresso não encontrado.";
                }
                return ingresso;

            }
            catch (Exception)
            {

                return new IngressosPessoasRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao consultar ingresso."
                };
            }

        }

        public IngressosPessoasListRetornoModel ConsultarIngressosPessoa(Guid idPessoa)
        {
            try
            {
                var ingresso = (IngressosPessoasListRetornoModel)_ingressoRepository.ConsultarIngressosPessoa(idPessoa);

                if (ingresso.IngressosPessoas.Count == 0)
                {
                    ingresso.Mensagem = "Pessoa sem ingressos cadastrados.";
                }
                return ingresso;

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
                var ingresso = (IngressosPessoasListRetornoModel)_ingressoRepository.ConsultarIngressosPessoaEvento(idPessoa, idEvento);
                if (ingresso.IngressosPessoas.Count == 0)
                {
                    ingresso.Mensagem = "Pessoa não posssui ingresso para o evento informado.";
                }
                return ingresso;
                 
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

        public IngressosPessoasRetornoModel UtilizarIngressoPessoa(Guid idIngressoPessoa)
        {
            try
            {
                var ingressosPessoa = _ingressoRepository.ConsultarIngressoPessoa(idIngressoPessoa);
                if (ingressosPessoa == null)
                {
                    return new IngressosPessoasRetornoModel()
                    {
                        IsSucesso = false,
                        Mensagem = "Ingresso nâo encontrado."
                    };
                }else if (ingressosPessoa.isAtivo)
                {
                    if (ingressosPessoa.isUtilizado)
                    {
                        return new IngressosPessoasRetornoModel()
                        {
                            IsSucesso = false,
                            Mensagem = "Ingresso já utilizado."
                        };
                    }

                    ingressosPessoa.isUtilizado = true;
                    return _ingressoRepository.EditarIngressoPessoa(ingressosPessoa);
                }
                else
                {
                    return new IngressosPessoasRetornoModel()
                    {
                        IsSucesso = false,
                        Mensagem = "Ingresso cancelado."
                    };
                }
                
            }
            catch (Exception)
            {

                return new IngressosPessoasRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao utilizar ingresso."
                };
            }
        }
    }
}
