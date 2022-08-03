using FluentValidation;
using TestTask.Contracts.DTO;

namespace TestTask.Application.Common.Validation
{
    public class ReviewDetailDtoValidator : AbstractValidator<ReviewDetailDto>
    {
        public ReviewDetailDtoValidator()
        {
            RuleFor(e => e.Message).NotEmpty();
            RuleFor(e => e.Reviewer).NotEmpty();
        }

    }
}