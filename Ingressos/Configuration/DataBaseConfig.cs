using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ingressos.API.Configuration
{
    public static class DataBaseConfig
    {
        public static void RegisterDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<banco>(options =>
            //   options.UseSqlServer(configuration.GetConnectionString("conection")));
            //services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase(databaseName: "Ingressos"));

        }
    }
}
