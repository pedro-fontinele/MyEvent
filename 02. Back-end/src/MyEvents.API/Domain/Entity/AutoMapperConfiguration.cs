using AutoMapper;
using MyEvents.API.Domain.Entity.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MyEvents.API.Domain.Entity
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            var config = new MapperConfiguration(add =>
            {
                add.AddProfile<EventMapper>();
                add.AddProfile<BatchMapper>();
                add.AddProfile<SocialNetworkMapper>();
                add.AddProfile<SpeakerMapper>();
                add.AddProfile<SpeakerEventMapper>();
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
