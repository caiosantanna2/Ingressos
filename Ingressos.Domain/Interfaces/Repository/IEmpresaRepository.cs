

using Ingressos.Domain.Entities.Instituicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IEmpresaRepository
    {
        List<Empresa> ConsultarEmpresas();
        Empresa ConsultarPorId(Guid IdEmpresa);
        Empresa CadastrarEmpresa(Empresa empresa);
        Empresa AlterarEmpresa(Empresa empresa);
        string ExcluirEmpresa(Guid IdEmpresa);
    }
}
