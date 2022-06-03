using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Domain.Entities.Cliente;

namespace Ingressos.Domain.Services.Cliente
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
       
        public PessoaService(IPessoaRepository  pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;       
        }

        public Pessoa AlterarPessoa(Pessoa pessoa)
        {
            return _pessoaRepository.AlterarPessoa(pessoa);
        }

        public Pessoa CadastrarPessoa(Pessoa pessoa)
        {
            return _pessoaRepository.CadastrarPessoa(pessoa);
        }

        public List<Pessoa> ConsultarPessoas()
        {
            return _pessoaRepository.ConsultarPessoas();
        }

        public Pessoa ConsultarPorId(Guid pessoa)
        {
            return _pessoaRepository.ConsultarPorId(pessoa);

        }

        public string ExcluirPessoa(Guid IdPessoa)
        {
            return _pessoaRepository.ExcluirPessoa(IdPessoa);
        }
    }
}
