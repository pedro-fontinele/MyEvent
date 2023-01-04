using FluentValidation;
using MyEvents.API.Domain.Entity.Dto;

namespace MyEvents.API.Domain.Entity.Validator
{
    public class SocialNetworkValidator : AbstractValidator<SocialNetworkDto>
    {
        public SocialNetworkValidator()
        {
            
        }
    }
}
