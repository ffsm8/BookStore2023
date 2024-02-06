using BookStore.Models.Models;
using FluentValidation;

namespace BookStore2023.Validators
{
    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(test => test.Id)
                .NotNull()
                .GreaterThan(0)
                .LessThan(10);
            RuleFor(test => test.Title)
                .NotNull()
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(50);
            RuleFor(test => test.AuthorId)
                .NotNull()
                .NotEmpty();
            RuleFor(test => test.ReleaseDate)
             .NotNull()
             .NotEmpty()
            .LessThan(new DateTime(2024, 02, 10));
        }
    }
}
