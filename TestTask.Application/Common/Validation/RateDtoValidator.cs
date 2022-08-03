using FluentValidation;
using TestTask.Contracts.DTO;

namespace TestTask.Application.Common.Validation
{
    public class RateDtoValidator : AbstractValidator<RateDto>
    {
        public RateDtoValidator()
        {
            RuleFor(e => e.Score).InclusiveBetween(1, 5);
        }
    }
}
