using FluentValidation;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Validator.ErrorMessage;

namespace MyEvents.API.Domain.Entity.Validator
{
    public class EventValidator : AbstractValidator<EventDto>
    {
        public EventValidator()
        {
            RuleFor(e => e.Local).NotNull().WithMessage(EventErrorMessage.FieldCannotBeNull)
                                 .NotEmpty().WithMessage(EventErrorMessage.LocalMustBeInformed)
                                 .MaximumLength(50).WithMessage(EventErrorMessage.ExceededNumberOfCharacters);

            RuleFor(e => e.EventDate).NotNull().WithMessage(EventErrorMessage.FieldCannotBeNull)
                                     .NotEmpty().WithMessage(EventErrorMessage.EventDateMustBeInformed);

            RuleFor(e => e.Theme).NotNull().WithMessage(EventErrorMessage.FieldCannotBeNull)
                                 .NotEmpty().WithMessage(EventErrorMessage.ThemeMustBeInformed)
                                 .MaximumLength(30).WithMessage(EventErrorMessage.ExceededNumberOfCharacters);

            RuleFor(e => e.NumberOfParticipants).NotNull().WithMessage(EventErrorMessage.FieldCannotBeNull)
                                                .NotEmpty().WithMessage(EventErrorMessage.NumberOfParticipantsMustBeInformed);

            RuleFor(e => e.ImageUrl).NotNull().WithMessage(EventErrorMessage.FieldCannotBeNull)
                                    .NotEmpty().WithMessage(EventErrorMessage.ImageUrlMustBeInformed)
                                    .MaximumLength(100).WithMessage(EventErrorMessage.ExceededNumberOfCharacters);

            RuleFor(e => e.Telephone).NotNull().WithMessage(EventErrorMessage.FieldCannotBeNull)
                                     .NotEmpty().WithMessage(EventErrorMessage.TelephoneMustBeInformed);

            RuleFor(e => e.Email).EmailAddress().WithMessage(EventErrorMessage.EmailMustBeValid)
                                 .NotNull().WithMessage(EventErrorMessage.FieldCannotBeNull)
                                 .NotEmpty().WithMessage(EventErrorMessage.EmailMustBeInformed)
                                 .MaximumLength(50).WithMessage(EventErrorMessage.ExceededNumberOfCharacters);

            RuleFor(e => e.Batch).NotNull().WithMessage(EventErrorMessage.FieldCannotBeNull)
                                 .NotEmpty().WithMessage(EventErrorMessage.BatchMustBeInformed);

            RuleFor(e => e.SocialNetwork).NotEmpty().WithMessage(EventErrorMessage.SocialNetworkMustBeInformed);

            RuleFor(e => e.SpeakerEvent).NotNull().WithMessage(EventErrorMessage.FieldCannotBeNull)
                                        .NotEmpty().WithMessage(EventErrorMessage.SpeakerEventkMustBeInformed);
        }
    }
}
