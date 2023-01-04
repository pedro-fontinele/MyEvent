using Microsoft.Extensions.DependencyInjection;

namespace MyEvents.API.Services
{
    public static class ServiceConfiguration
    {
        public static void AddServiceConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IBatchService, BatchService>();
        }
    }
}
