
using Ingressos.Domain.Entities.Cliente;

using Ingressos.Domain.Entities.Enderecos;
using Ingressos.Domain.Entities.Instituicao;
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

       
        
    }
}
