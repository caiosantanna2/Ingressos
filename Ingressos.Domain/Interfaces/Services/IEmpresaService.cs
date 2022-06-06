

using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Model.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IEmpresaService
    {
        EmpresaListRetornoModel ConsultarEmpresas();
        EmpresaRetornoModel ConsultarPorId(Guid IdEmpresa);
        EmpresaRetornoModel CadastrarEmpresa(Empresa empresa);
        EmpresaRetornoModel AlterarEmpresa(Empresa empresa);
        EmpresaRetornoModel ExcluirEmpresa(Guid IdEmpresa);
    }
}
