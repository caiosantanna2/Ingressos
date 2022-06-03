using Ingressos.Domain.Interfaces.Services;
using Ingressos.Domain.Entities.Cliente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Data.Repository.Pessoa
{
    public class PessoaRepository : IPessoaRepository
    {
        public Task<Domain.Entities.Cliente.Pessoa> AlterarPessoa(Domain.Entities.Cliente.Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Cliente.Pessoa> CadastrarPessoa(Domain.Entities.Cliente.Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Cliente.Pessoa> ConsltarPessoa(Domain.Entities.Cliente.Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> ExcluirPessoa(Guid IdPessoa)
        {
            throw new NotImplementedException();
        }
    }
}
