using Ingressos.Data.Context;
using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.Enderecos;
using Ingressos.Domain.Entities.EventoEntites;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Entities.Vendas;
using System;
using System.Collections.Generic;

namespace Ingressos.API.Configuration
{
    public static class AdcionarDados
    {
        public static void AdicionarDadosTeste(IngresssosContext context)
        {
            var testePessoa = new Pessoa
            {
                 Id = new Guid("1dc3192d-28bb-8565-9a20-bd8ea45c5f69"),
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

            var testeEmpresa = new Empresa
            {
                 Id = new Guid("46777593-89ce-cb35-355c-1ed1413f1d63"),

                Nome = "Empresa Eventos S.A",
                CNPJ = "11.010.100/0001-01",
                Endereco = new Endereco
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

            context.Empresa.Add(testeEmpresa);

            var testeEvento = new Evento
            {
                 Id = new Guid("21f8de0d-6fb4-0214-cc14-99ad91a82f45"),
                Name = "Festa de Aniversario",
                DataEvento = new DateTime(2022, 07, 01, 15, 00, 00),
                Instituicao = testeEmpresa,
                IsAtivo = true,
                Endereco = new Endereco
                {
                    Id = new Guid(),
                    Bairro = "Asa Norte",
                    Complemento = "Parque Asa Norte",
                    Estado = "DF",
                    Logradouro = "Parque",
                    Municipio = "Brasilia",
                    Numero = "S/N",
                    NumeroCep = 72660710
                }
            };

            context.Evento.Add(testeEvento);

            var testeIngresso1 = new IngressosEventos
            {
                Id = new Guid("8dadf884-99b1-b2ad-fb03-3fc764572781"),
                Descricao = "Pista",
                Quantidade = 1500,
                QuantidadeDisponivel = 1500,
                Valor = 50.00,
                Evento = testeEvento

            };

            context.Ingressos.Add(testeIngresso1);


            var testeIngresso2 = new IngressosEventos
            {
                Id = new Guid("20fd11f0-aecc-d28a-4057-177678bf9b6d"),
                Descricao = "Camarote",
                Quantidade = 500,
                QuantidadeDisponivel = 430,
                Valor = 150.00,
                Evento = testeEvento

            };
            context.Ingressos.Add(testeIngresso2);

            var ingressos = new List<IngressosPessoas>();

            var ingresso1 = new IngressosPessoas
            {
                Ingresso = testeIngresso1,
                Pessoa = testePessoa,


            };

            var ingresso2 = new IngressosPessoas
            {
                Ingresso = testeIngresso2,
                Pessoa = testePessoa,


            };

            ingressos.Add(ingresso1);
            ingressos.Add(ingresso2);

            var testeVenda = new Venda
            {
                // Id = new Guid(),
                DataVenda = new DateTime(2022, 06, 01),
                TransacaoPagamento = "fd9sfsd98fs8f",
                ValorVenda = 1500,
                Ingressos = ingressos

            };

            context.Add(testeVenda);




            context.SaveChanges();
        }
    }
}
