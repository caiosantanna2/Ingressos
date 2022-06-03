using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Domain.Entities.Empresa;


namespace Ingressos.Domain.Services.Empresa
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;       
        }

        public Task<Domain.Entities.Empresa.Empresa> AlterarEmpresa(Domain.Entities.Empresa.Empresa empresa)
        {
            return _empresaRepository.AlterarEmpresa(empresa);
        }

        public Task<Domain.Entities.Empresa.Empresa> CadastrarEmpresa(Domain.Entities.Empresa.Empresa empresa)
        { 
            return _empresaRepository.CadastrarEmpresa(empresa);
        }

       
        public Task<List<Domain.Entities.Empresa.Empresa>> ConsultarEmpresa(Domain.Entities.Empresa.Empresa empresa)
        {
            return _empresaRepository.ConsultarEmpresa(empresa);
        }

        public Task<Guid> ExcluirEmpresa(Guid IdEmpresa)
        {
            return _empresaRepository.ExcluirEmpresa(IdEmpresa);
        }
    }
}
