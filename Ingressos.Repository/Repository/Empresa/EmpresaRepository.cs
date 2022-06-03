using Ingressos.Domain.Interfaces.Services;
using Ingressos.Domain.Entities.Cliente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Data.Repository.Empresa
{
    public class EmpresaRepository : IEmpresaRepository
    {
        public Task<Domain.Entities.Empresa.Empresa> AlterarEmpresa(Domain.Entities.Empresa.Empresa pessoa)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Empresa.Empresa> CadastrarEmpresa(Domain.Entities.Empresa.Empresa pessoa)
        {
            throw new NotImplementedException();
        }

        public Task<List<Domain.Entities.Empresa.Empresa>> ConsultarEmpresa(Domain.Entities.Empresa.Empresa pessoa)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> ExcluirEmpresa(Guid IdPessoa)
        {
            throw new NotImplementedException();
        }
    }
}
