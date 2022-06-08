using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Model.Retorno;

namespace Ingressos.Domain.Services.Instituicao
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public EmpresaRetornoModel AlterarEmpresa(Empresa empresa)
        {
            try
            {
                return _empresaRepository.AlterarEmpresa(empresa);
            }
            catch (Exception)
            {
                return new EmpresaRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao alterar empresa"
                };

            }

        }

        public EmpresaRetornoModel CadastrarEmpresa(Empresa empresa)
        {
            try
            {
                return _empresaRepository.CadastrarEmpresa(empresa);
            }

            catch (Exception)
            {
                return new EmpresaRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cadastrar empresa"
                };

            }

        }

        public EmpresaListRetornoModel ConsultarEmpresas()
        {
            try
            {
                var empresa = (EmpresaListRetornoModel)_empresaRepository.ConsultarEmpresas();
                if (empresa.Empresa == null)
                {
                    empresa.Mensagem = "Empresas nao cadastradas.";
                }

                return empresa;


            }
            catch (Exception)
            {

                return new EmpresaListRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao consultar empresas"
                };

            }

        }

        public EmpresaRetornoModel ConsultarPorId(Guid IdEmpresa)
        {
            try
            {
                var empresa = (EmpresaRetornoModel)_empresaRepository.ConsultarPorId(IdEmpresa);
                if (empresa.Empresa == null)
                {
                    empresa.Mensagem = "Empresa nao encontrada.";
                }

                return empresa;
              
            }
            catch (Exception)
            {
                return new EmpresaRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao consultar empresa"
                };
                //Capturar log

            }

        }

        public EmpresaRetornoModel ExcluirEmpresa(Guid IdEmpresa)
        {
            try
            {
                EmpresaRetornoModel empresaRetornoModel = new EmpresaRetornoModel();
                empresaRetornoModel.Mensagem = _empresaRepository.ExcluirEmpresa(IdEmpresa);

                return empresaRetornoModel;
            }
            catch (Exception)
            {
                return new EmpresaRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao consultar empresa"
                };
                //Capturar log

            }

        }
    }
}
