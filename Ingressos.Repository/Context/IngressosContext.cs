using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.Empresa;
using Microsoft.EntityFrameworkCore;

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
