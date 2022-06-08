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
            catch (Exception)
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
            catch (Exception)
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
                var pessoa = (PessoasListRetornoModel)_pessoaRepository.ConsultarPessoas();
                if (pessoa.Pessoas == null)
                {
                    pessoa.Mensagem = "Pessoa nao encontrada.";
                }
                return pessoa;
                
            }
            catch (Exception)
            {
                return new PessoasListRetornoModel()
                {
                    IsSucesso = false,
                    Mensagem = "Falha ao consultar pessoa"
                };

            }
        }

        public PessoasRetornoModel ConsultarPorId(Guid pessoaId)
        {
            try
            {
                var pessoa = (PessoasRetornoModel)_pessoaRepository.ConsultarPorId(pessoaId);
                if(pessoa.Pessoa == null)
                {
                    pessoa.Mensagem = "Pessoa nao encontrada.";
                }
                return pessoa;
                
            }
            catch (Exception)
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
            catch (Exception)
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
