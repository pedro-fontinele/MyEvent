using FluentValidation;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Validator.ErrorMessage;

namespace MyEvents.API.Domain.Entity.Validator
{
    public class SocialNetworkValidator : AbstractValidator<SocialNetworkDto>
    {
        public SocialNetworkValidator()
        {
            RuleFor(e => e.Name).NotNull().WithMessage(SocialNetworkErrorMessage.FieldCannotBeNull)
                                .NotEmpty().WithMessage(SocialNetworkErrorMessage.NameMustBeInformed)
                                .MaximumLength(50);

            RuleFor(e => e.Url).NotNull().WithMessage(SocialNetworkErrorMessage.FieldCannotBeNull)
                               .NotEmpty().WithMessage(SocialNetworkErrorMessage.UrlMustBeInformed);

            RuleFor(e => e.IdEvent).NotNull().WithMessage(SocialNetworkErrorMessage.FieldCannotBeNull)
                                   .NotEmpty().WithMessage(SocialNetworkErrorMessage.IdEventMustBeInformed);

            RuleFor(e => e.EventDto).NotNull().WithMessage(SocialNetworkErrorMessage.FieldCannotBeNull)
                                    .NotEmpty().WithMessage(SocialNetworkErrorMessage.EventDtoMustBeInformed);

            RuleFor(e => e.IdSpeaker).NotNull().WithMessage(SocialNetworkErrorMessage.FieldCannotBeNull)
                                     .NotEmpty().WithMessage(SocialNetworkErrorMessage.IdEventMustBeInformed);

            RuleFor(e => e.SpeakerDto).NotNull().WithMessage(SocialNetworkErrorMessage.FieldCannotBeNull)
                                      .NotEmpty().WithMessage(SocialNetworkErrorMessage.SpeakerDtoMustBeInformed);
        }
    }
}
