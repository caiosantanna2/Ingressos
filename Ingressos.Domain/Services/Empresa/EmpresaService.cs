using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Interfaces.Repository;

namespace Ingressos.Domain.Services.Instituicao
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        
        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;       
        }

        public Empresa AlterarEmpresa(Empresa empresa)
        {
            return _empresaRepository.AlterarEmpresa(empresa);
        }

        public Empresa CadastrarEmpresa(Empresa empresa)
        { 
            return _empresaRepository.CadastrarEmpresa(empresa);
        }
       
        public List<Empresa> ConsultarEmpresas()
        {
            return _empresaRepository.ConsultarEmpresas();
        }

        public Empresa ConsultarPorId(Guid IdEmpresa)
        {
            return _empresaRepository.ConsultarPorId(IdEmpresa);
        }

        public string ExcluirEmpresa(Guid IdEmpresa)
        {
            return _empresaRepository.ExcluirEmpresa(IdEmpresa);
        }
    }
}
