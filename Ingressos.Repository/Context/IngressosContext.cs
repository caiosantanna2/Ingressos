
using Ingressos.Domain.Entities.Cliente;

using Ingressos.Domain.Entities.Enderecos;
using Ingressos.Domain.Entities.EventoEntites;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Entities.Vendas;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ingressos.Data.Context
{
    public class IngresssosContext : DbContext
    {
        public IngresssosContext(DbContextOptions<IngresssosContext> options)
          : base(options)
        { }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<IngressosEventos> Ingressos { get; set; }
        public DbSet<IngressosPessoas> IngressosPessoas { get; set; }
        public DbSet<Venda> Venda { get; set; }
    }
}
