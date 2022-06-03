
using Ingressos.Domain.Entities.Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IEmpresaRepository
    {
        Task<List<Empresa>> ConsultarEmpresa(Empresa pessoa);
        Task<Empresa> CadastrarEmpresa(Empresa pessoa);
        Task<Empresa> AlterarEmpresa(Empresa pessoa);
        Task<Guid> ExcluirEmpresa(Guid IdPessoa);
    }
}
