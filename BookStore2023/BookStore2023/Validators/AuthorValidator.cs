using BookStore.Models.Models.Users;
using FluentValidation;

namespace BookStore.Validators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(test => test.Id)
                .NotNull()
                .GreaterThan(0)
                .LessThan(10);
            RuleFor(test => test.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(50);
            RuleFor(test => test.BirthDay)
                .NotNull()
                .NotEmpty()
                .LessThan(new DateTime(2020, 02, 10));
        }
    }
}