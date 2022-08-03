using FluentValidation;
using TestTask.Contracts.DTO;

namespace TestTask.Application.Common.Validation
{
    public class BookSavingDtoValidator : AbstractValidator<BookSavingDto>
    {
        public BookSavingDtoValidator()
        {
            RuleFor(e => e.Title).NotEmpty();
            RuleFor(e => e.Cover).NotEmpty();
            RuleFor(e => e.Content).NotEmpty();
            RuleFor(e => e.Genre).NotEmpty();
            RuleFor(e => e.Author).NotEmpty();
        }
    }
}