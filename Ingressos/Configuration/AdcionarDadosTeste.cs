using Ingressos.Data.Context;
using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.Enderecos;
using Ingressos.Domain.Entities.Instituicao;
using System;

namespace Ingressos.API.Configuration
{
    public static class AdcionarDados
    {
        public static void AdicionarDadosTeste(IngresssosContext context)
        {
            var testePessoa = new Pessoa
            {
                Id = new Guid(),
                Nome = "Caio",
                Email = "caio@yahoo.com",
                Cpf = "01274485520",
                DataNascimento = new DateTime(1988, 01, 01),
                Endereco = new Endereco
                {
                    Id = new Guid(),
                    Bairro = "Aguas Claras",
                    Complemento = "Apto 01",
                    Estado = "DF",
                    Logradouro = "Rua 31",
                    Municipio = "Brasilia",
                    Numero = "09",
                    NumeroCep = 71936500
                }
            };

            context.Pessoas.Add(testePessoa);
           
            var testeEmpres = new Empresa
            {
                Id = new Guid(),
                
                Nome = "Empresa Eventos S.A",
                CNPJ = "11.010.100/0001-01",
                Endereco =  new Endereco
                {
                    Id = new Guid(),
                    Bairro = "Asa Sul",
                    Complemento = "Loja 01",
                    Estado = "DF",
                    Logradouro = "Q 712",
                    Municipio = "Brasilia",
                    Numero = "712",
                    NumeroCep = 72660700
                }
            };

            context.Empresa.Add(testeEmpres);
            context.SaveChanges();
        }
    }
}
