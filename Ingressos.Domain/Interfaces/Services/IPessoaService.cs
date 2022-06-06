using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Model.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IPessoaService
    {
        PessoasListRetornoModel ConsultarPessoas();
        PessoasRetornoModel ConsultarPorId(Guid pessoa);
        PessoasRetornoModel CadastrarPessoa(Pessoa pessoa);
        PessoasRetornoModel AlterarPessoa(Pessoa pessoa);
        PessoasRetornoModel ExcluirPessoa(Guid IdPessoa);
    }
}
