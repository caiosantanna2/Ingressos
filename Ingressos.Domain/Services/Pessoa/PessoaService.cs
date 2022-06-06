using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Model.Retorno;

namespace Ingressos.Domain.Services.Cliente
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public PessoasRetornoModel AlterarPessoa(Pessoa pessoa)
        {
            try
            {
                return _pessoaRepository.AlterarPessoa(pessoa);

            }
            catch (Exception e)
            {
                return new PessoasRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao alterar pessoa"
                };

            }
        }

        public PessoasRetornoModel CadastrarPessoa(Pessoa pessoa)
        {
            try
            {
                return _pessoaRepository.CadastrarPessoa(pessoa);

            }
            catch (Exception e)
            {

                return new PessoasRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao cadastrar pessoa"
                };

            }
        }

        public PessoasListRetornoModel ConsultarPessoas()
        {
            try
            {
                return _pessoaRepository.ConsultarPessoas();

            }
            catch (Exception e)
            {
                return new PessoasListRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao consultar pessoa"
                };

            }
        }

        public PessoasRetornoModel ConsultarPorId(Guid pessoa)
        {
            try
            {
                return _pessoaRepository.ConsultarPorId(pessoa);

            }
            catch (Exception e)
            {
                return new PessoasRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao consultar pessoa"
                };

            }

        }

        public PessoasRetornoModel ExcluirPessoa(Guid IdPessoa)
        {
            try
            {
                return new PessoasRetornoModel
                {
                    Mensagem = _pessoaRepository.ExcluirPessoa(IdPessoa)
                };
            }
            catch (Exception e)
            {
                //Capturar log
                return new PessoasRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao excluir pessoa"
                };

            }

        }
    }
}
