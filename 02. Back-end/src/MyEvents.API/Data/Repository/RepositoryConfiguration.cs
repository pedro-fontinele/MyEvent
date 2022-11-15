using Microsoft.Extensions.DependencyInjection;

namespace MyEvents.API.Data.Repository
{
    public static class RepositoryConfiguration
    {
        public static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IEventRepository, EventRepository>();
        }
    }
}
