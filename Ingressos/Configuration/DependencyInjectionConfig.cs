


using Ingressos.Data.Repository.Pessoa;
using Ingressos.Domain.Interfaces.Services;
using Ingressos.Domain.Services.Pessoa;
using Microsoft.Extensions.DependencyInjection;

namespace Ingressos.API.Configuration
{
    public static class DependencyInjectionConfig 
    {
        public static void RegisterInjections(this IServiceCollection services)
        {
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();

        }
    }
}
