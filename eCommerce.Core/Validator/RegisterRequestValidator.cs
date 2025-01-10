using eCommerce.Core.DTO;
using FluentValidation;
namespace eCommerce.Core.Validator;
public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        RuleFor(temp => temp.Email).NotEmpty().WithMessage("EmailId is required").EmailAddress().WithMessage("Invalid Email adress Format");

        RuleFor(temp => temp.Password).NotEmpty().WithMessage("Password is required").MinimumLength(1).MaximumLength(10);

        RuleFor(temp => temp.PersonName).NotEmpty().WithMessage("PersonName is required").MinimumLength(3).MaximumLength(20);

        RuleFor(temp => temp.Gender).IsInEnum().WithMessage("Gender Not Specified");
    }
}
