using eCommerce.Core.DTO;
using FluentValidation;
namespace eCommerce.Core.Validator;
public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        RuleFor(temp => temp.Email).NotEmpty().WithMessage("EmailId is required").EmailAddress().WithMessage("Invalid Email adress Format");

        RuleFor(temp => temp.Password).NotEmpty().WithMessage("Password is required").Length(1, 15).WithMessage("Password Should be 1  to 15 charcter long");

        RuleFor(temp => temp.PersonName).NotEmpty().WithMessage("PersonName is required").Length(1, 50).WithMessage("PersonName Should be 1 to 50 Character long");

        RuleFor(temp => temp.Gender).IsInEnum().WithMessage("Gender Not Specified");
    }
}
