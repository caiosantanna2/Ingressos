using Ingressos.Domain.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IPessoaRepository
    {
        Task<List<Pessoa>> ConsultarPessoa(Pessoa pessoa);
        Task<Pessoa> CadastrarPessoa(Pessoa pessoa);
        Task<Pessoa> AlterarPessoa(Pessoa pessoa);
        Task<Guid> ExcluirPessoa(Guid IdPessoa);
    }
}
