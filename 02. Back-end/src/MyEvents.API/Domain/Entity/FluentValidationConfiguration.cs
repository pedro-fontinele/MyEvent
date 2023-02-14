using FluentValidation;
using FluentValidation.AspNetCore;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Validator;
using Microsoft.Extensions.DependencyInjection;

namespace MyEvents.API.Domain.Entity
{
    public static class FluentValidationConfiguration
    {
        public static void AddFluentValidationConfiguration (this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddScoped<IValidator<EventDto>, EventValidator>();
            services.AddScoped<IValidator<BatchDto>, BatchValidator>();
            services.AddScoped<IValidator<SocialNetworkDto>, SocialNetworkValidator>();
            services.AddScoped<IValidator<SpeakerDto>, SpeakerValidator>();
            services.AddScoped<IValidator<SpeakerEventDto>, SpeakerEventValidator>();
        }
    }
}
