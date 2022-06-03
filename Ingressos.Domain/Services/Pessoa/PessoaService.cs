using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Domain.Entities.Cliente;

namespace Ingressos.Domain.Services.Pessoa
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository  pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;       
        }
        public Task<Entities.Cliente.Pessoa> AlterarPessoa(Entities.Cliente.Pessoa pessoa)
        {
            return _pessoaRepository.AlterarPessoa(pessoa);
        }

        public Task<Entities.Cliente.Pessoa> CadastrarPessoa(Entities.Cliente.Pessoa pessoa)
        {
            return _pessoaRepository.CadastrarPessoa(pessoa);
        }

        public Task<Entities.Cliente.Pessoa> ConsltarPessoa(Entities.Cliente.Pessoa pessoa)
        {
            return _pessoaRepository.ConsltarPessoa(pessoa);
        }

        public Task<Guid> ExcluirPessoa(Guid IdPessoa)
        {
            return _pessoaRepository.ExcluirPessoa(IdPessoa);
        }
    }
}
