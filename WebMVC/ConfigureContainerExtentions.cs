using Infraestructure;
using Infraestructure.Data;
using Infraestructure.Data;
using Infraestructure.RepositoryPattern;
using Infraestructure.RepositoryPattern;
using Infraestructure.RepositoryPattern.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Interfaces;

namespace WebMVC
{
    public static class ConfigureContainerExtentions
    {
        public static void AddDbContext(this IServiceCollection serviceCollection, string dataConnectionString = null,
            string authConnectionString = null)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(dataConnectionString ?? GetDataConnectionStringFromConfig()));
        }

        private static string GetDataConnectionStringFromConfig()
        {
            return new DatabaseConfiguration().GetDataConnectionString();
        }

        public static void AddRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }

        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICargoService, CargoService>();

        }
    }
}
