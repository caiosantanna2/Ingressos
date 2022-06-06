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
                return _vendaRepository.ConsultarVenda(idVenda);
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

        public VendaRetornoModel RealizaVenda(VendaModel vendaModel)
        {
            try
            {
                var ingressosPessoa = new List<IngressosPessoas>();
                Venda venda = vendaModel;
                var responsePessoa = _pessoService.ConsultarPorId(vendaModel.PessoaId);
                if (responsePessoa == null)
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
                    if (responseIngresso == null)
                    {
                        return new VendaRetornoModel()
                        {
                            IsSucesso = false,
                            Mensagem = "Não foi possível realizar a venda, ingresso não encontrada."
                        };
                    }
                    for (int qtd = 0; qtd < ingressos.Quantidade; qtd++)
                    {
                        ingressosPessoa.Add(new IngressosPessoas()
                        {
                            Ingresso = responseIngresso,
                            Pessoa = responsePessoa.Pessoa
                        });

                    }

                }

                venda.Ingressos = ingressosPessoa;

                return _vendaRepository.RealizaVenda(venda);
            }
            catch (Exception e)
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
