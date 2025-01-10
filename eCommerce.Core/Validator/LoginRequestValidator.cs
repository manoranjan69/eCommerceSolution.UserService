
using eCommerce.Core.DTO;
using FluentValidation;

namespace eCommerce.Core.Validator;
public class LoginRequestValidators:AbstractValidator<LoginRequest>
    {
    public LoginRequestValidators()
    {
        //Email
        RuleFor(temp => temp.Email).NotEmpty().WithMessage("Email is required").EmailAddress().WithMessage("Invalid Email Address Format");

        //PassWord
        RuleFor(temp => temp.Password).NotEmpty().WithMessage("PassWord is required");
    }
}

