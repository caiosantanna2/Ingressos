using Ingressos.Data.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Ingressos.API.Configuration
{
    public static class DataBaseConfig
    {
        public static void RegisterDataBase(this IServiceCollection services)
        {
            //services.AddDbContext<banco>(options =>
            //   options.UseSqlServer(configuration.GetConnectionString("conection")));
            services.AddDbContext<IngresssosContext>(options => options.UseInMemoryDatabase(databaseName: "Ingressos"));

        }
    }
}
