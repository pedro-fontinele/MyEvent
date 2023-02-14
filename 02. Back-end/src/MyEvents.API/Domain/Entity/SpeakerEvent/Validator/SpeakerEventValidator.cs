using FluentValidation;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Validator.ErrorMessage;

namespace MyEvents.API.Domain.Entity.Validator
{
    public class SpeakerEventValidator : AbstractValidator<SpeakerEventDto>
    {
        public SpeakerEventValidator()
        {
            RuleFor(e => e.IdSpeaker).NotNull().WithMessage(SpeakerEventErrorMessage.FieldCannotBeNull)
                                     .NotEmpty().WithMessage(SpeakerEventErrorMessage.IdSpeakerMustBeInformed);

            RuleFor(e => e.Speaker).NotNull().WithMessage(SpeakerEventErrorMessage.FieldCannotBeNull)
                                   .NotEmpty().WithMessage(SpeakerEventErrorMessage.SpeakerMustBeInformed);

            RuleFor(e => e.IdEvent).NotNull().WithMessage(SpeakerEventErrorMessage.FieldCannotBeNull)
                                   .NotEmpty().WithMessage(SpeakerEventErrorMessage.IdEventMustBeInformed);

            RuleFor(e => e.Event).NotNull().WithMessage(SpeakerEventErrorMessage.FieldCannotBeNull)
                                 .NotEmpty().WithMessage(SpeakerEventErrorMessage.EventMustBeInformed);
        }
    }
}
