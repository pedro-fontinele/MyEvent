using Microsoft.Extensions.DependencyInjection;

namespace MyEvents.API.Data.Repositores
{
    public static class RepositoriesConfiguration
    {
        public static void AddRepositoriesConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IEventoRepositore, EventoRepositore>();
        }
    }
}
