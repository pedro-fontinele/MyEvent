using FluentValidation;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Validator.ErrorMessage;

namespace MyEvents.API.Domain.Entity.Validator
{
    public class SpeakerValidator : AbstractValidator<SpeakerDto>
    {
        public SpeakerValidator()
        {
            RuleFor(e => e.Name).NotNull().WithMessage(SpeakerErrorMessage.FieldCannotBeNull)
                                .NotEmpty().WithMessage(SpeakerErrorMessage.NameMustBeInformed)
                                .MaximumLength(50);

            RuleFor(e => e.Summary).NotNull().WithMessage(SpeakerErrorMessage.FieldCannotBeNull)
                                   .NotEmpty().WithMessage(SpeakerErrorMessage.SummaryMustBeInformed)
                                   .MaximumLength(100);

            RuleFor(e => e.ImageUrl).NotNull().WithMessage(SpeakerErrorMessage.FieldCannotBeNull)
                                    .NotEmpty().WithMessage(SpeakerErrorMessage.ImageUrlMustBeInformed);

            RuleFor(e => e.Telephone).NotNull().WithMessage(SpeakerErrorMessage.FieldCannotBeNull)
                                     .NotEmpty().WithMessage(SpeakerErrorMessage.TelephoneMustBeInformed);

            RuleFor(e => e.Email).NotNull().WithMessage(SpeakerErrorMessage.FieldCannotBeNull)
                                 .NotEmpty().WithMessage(SpeakerErrorMessage.EmailMustBeInformed);

            RuleFor(e => e.SocialNetwork).NotNull().WithMessage(SpeakerErrorMessage.FieldCannotBeNull)
                                         .NotEmpty().WithMessage(SpeakerErrorMessage.SocialNetworkMustBeInformed);

            RuleFor(e => e.SpeakerEvent).NotNull().WithMessage(SpeakerErrorMessage.FieldCannotBeNull)
                                        .NotEmpty().WithMessage(SpeakerErrorMessage.SpeakerEventMustBeInformed);
        }
    }
}
