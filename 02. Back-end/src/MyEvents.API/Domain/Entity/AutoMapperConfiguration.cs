using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MyEvents.API.Domain.Entity
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile<EventoMapper>();
            });
        }
    }
}
