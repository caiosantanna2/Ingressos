



using Ingressos.Data.Repository.Cliente;
using Ingressos.Data.Repository.Instituicao;
using Ingressos.Data.Repository.VendaRepository;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Interfaces.Services;
using Ingressos.Domain.Services.Cliente;
using Ingressos.Domain.Services.EventoServices;
using Ingressos.Domain.Services.Instituicao;
using Ingressos.Domain.Services.VendaService;
using Microsoft.Extensions.DependencyInjection;

namespace Ingressos.API.Configuration
{
    public static class DependencyInjectionConfig 
    {
        public static void RegisterInjections(this IServiceCollection services)
        {
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();

            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            
            services.AddScoped<IEventoService, EventoService>();
            services.AddScoped<IEventoRepository, EventoRepository>();

            services.AddScoped<IIngressoService, IngressoService>();
            services.AddScoped<IIngressoRepository, IngressosRepository>();

            services.AddScoped<IVendaService, VendaService>();
            services.AddScoped<IVendaRepository, VendaRepository>();


        }
    }
}
