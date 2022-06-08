using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Model.Entrada;
using Ingressos.Domain.Entities.Vendas;
using Ingressos.Domain.Model.Retorno;

namespace Ingressos.Domain.Services.VendaService
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IPessoaService _pessoService;
        private readonly IIngressoService _ingressosService;

        public VendaService(IVendaRepository vendaRepository, IPessoaService pessoaService, IIngressoService ingressoService)
        {
            _pessoService = pessoaService;
            _ingressosService = ingressoService;
            _vendaRepository = vendaRepository;
        }

        public VendaRetornoModel CancelarVenda(Guid idVenda)
        {
            VendaRetornoModel empresaRetornoModel = new VendaRetornoModel();
            try
            {
                var venda = _vendaRepository.ConsultarVenda(idVenda);
                if (venda != null)
                {
                    foreach (var ingressos in venda.Ingressos)
                    {
                        ingressos.isAtivo = false;
                        ingressos.Ingresso.QuantidadeDisponivel++;
                    }
                    venda.IsAtiva = false;
                    return _vendaRepository.CancelarVenda(venda);
                }
                else
                {
                    return new VendaRetornoModel()
                    {
                        IsSucesso = false,
                        Mensagem = "Não foi possível cancelar a venda, venda não encontrada."
                    };

                }
            }

            catch (Exception)
            {
                return new VendaRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cancelar venda"
                };

            }

        }

        public VendaRetornoModel ConsultarVenda(Guid idVenda)
        {
            try
            {
                var venda = (VendaRetornoModel)_vendaRepository.ConsultarVenda(idVenda);
                if (venda == null)
                {
                    venda.Mensagem = "Pessoa nao encontrada.";
                }
                return venda;
            }
            catch (Exception)
            {
                return new VendaRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao consultar venda"
                };
            }

        }
        private VendaRetornoModel ValidaIngresso(IngressosEventos ingressos)
        {

            if (!ingressos.Evento.IsAtivo)
            {
                return new VendaRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Não foi possível realizar a venda, evento inativo."
                };
            }
            if (ingressos.QuantidadeDisponivel < ingressos.Quantidade)
            {
                return new VendaRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Não foi possível realizar a venda, quantidade de ingressos tipo " + ingressos.Descricao +" do evento "+ingressos.Evento.Name+" não disponível para venda."
                };
            }
            return new VendaRetornoModel();
        }
        public VendaRetornoModel RealizaVenda(VendaModel vendaModel)
        {
            try
            {
                var ingressosPessoa = new List<IngressosPessoas>();
                Venda venda = vendaModel;
                var responsePessoa = _pessoService.ConsultarPorId(vendaModel.PessoaId);
                if (responsePessoa.Pessoa == null)
                {
                    return new VendaRetornoModel()
                    {
                        IsSucesso = false,
                        Mensagem = "Não foi possível realizar a venda, pessoa não encontrada.",
                    };
                }

                foreach (var ingressos in vendaModel.Ingressos)
                {
                    var responseIngresso = _ingressosService.ConsultaIngresosPorId(ingressos.IngressoId);
                    if (responseIngresso.IngressosEventos == null)
                    {
                        return new VendaRetornoModel()
                        {
                            IsSucesso = false,
                            Mensagem = "Não foi possível realizar a venda, ingresso não encontrada."
                        };
                    }

                    var valid = ValidaIngresso(responseIngresso.IngressosEventos);

                    if (!valid.IsSucesso)
                    {
                        return valid;
                    }
                    for (int qtd = 0; qtd < ingressos.Quantidade; qtd++)
                    {
                        ingressosPessoa.Add(new IngressosPessoas()
                        {
                            Ingresso = responseIngresso.IngressosEventos,
                            Pessoa = responsePessoa.Pessoa,
                            ValorVendido = ingressos.ValorVendido

                        });
                        venda.ValorVenda += ingressos.ValorVendido;
                    }

                    responseIngresso.IngressosEventos.QuantidadeDisponivel -= ingressos.Quantidade;

                }

                venda.Ingressos = ingressosPessoa;

                return _vendaRepository.RealizaVenda(venda);
            }
            catch (Exception)
            {

                return new VendaRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao realizar venda"
                };
            }

        }
    }
}
