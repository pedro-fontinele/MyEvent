using FluentValidation;
using MyEvents.API.Domain.Entity.Dto;
using MyEvents.API.Domain.Entity.Validator.ErrorMessage;

namespace MyEvents.API.Domain.Entity.Validator
{
    public class BatchValidator : AbstractValidator<BatchDto>
    {
        public BatchValidator()
        {
            RuleFor(e => e.Name).NotNull().WithMessage(BatchErrorMessage.FieldCannotBeNull)
                                .NotEmpty().WithMessage(BatchErrorMessage.NameMustBeInformed)
                                .MaximumLength(50).WithMessage(BatchErrorMessage.ExceededNumberOfCharacters);

            RuleFor(e => e.Price).NotNull().WithMessage(BatchErrorMessage.FieldCannotBeNull)
                                 .NotEmpty().WithMessage(BatchErrorMessage.PriceMustBeInformed);

            RuleFor(e => e.StartDate).NotNull().WithMessage(BatchErrorMessage.FieldCannotBeNull)
                                     .NotEmpty().WithMessage(BatchErrorMessage.StartDateMustBeInformed)
                                     .MaximumLength(13).WithMessage(BatchErrorMessage.ExceededNumberOfCharacters);

            RuleFor(e => e.EndDate).NotNull().WithMessage(BatchErrorMessage.FieldCannotBeNull)
                                   .NotEmpty().WithMessage(BatchErrorMessage.EndDateMustBeInformed)
                                   .MaximumLength(13).WithMessage(BatchErrorMessage.ExceededNumberOfCharacters);

            RuleFor(e => e.TheAmount).NotNull().WithMessage(BatchErrorMessage.FieldCannotBeNull)
                                     .NotEmpty().WithMessage(BatchErrorMessage.TheAmountMustBeInformed);

            RuleFor(e => e.IdEvent).NotNull().WithMessage(BatchErrorMessage.FieldCannotBeNull)
                                   .NotEmpty().WithMessage(BatchErrorMessage.IdEventMustBeInformed);

            RuleFor(e => e.EventDto).NotNull().WithMessage(BatchErrorMessage.FieldCannotBeNull)
                                    .NotEmpty().WithMessage(BatchErrorMessage.EventMustBeInformed);
        }
    }
}
