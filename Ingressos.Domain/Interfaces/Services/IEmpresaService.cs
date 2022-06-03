
using Ingressos.Domain.Entities.Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IEmpresaService
    {
        Task<List<Empresa>> ConsultarEmpresa(Empresa empresa);
        Task<Empresa> CadastrarEmpresa(Empresa empresa);
        Task<Empresa> AlterarEmpresa(Empresa empresa);
        Task<Guid> ExcluirEmpresa(Guid IdEmpresa);
    }
}
