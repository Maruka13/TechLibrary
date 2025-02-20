using TechLibrary.Communication.Requests;
using FluentValidation;

namespace TechLibrary.api.UseCases.Users.Register
{
    public class RegisterUserValidator : AbstractValidator<RequestUserJson>
    {
        public RegisterUserValidator()
        {
            RuleFor(request => request.Name).NotEmpty().WithMessage("Nome obrigatório.");
            RuleFor(request => request.Email).EmailAddress().WithMessage("Email inválido.");
            RuleFor(request => request.Password).NotEmpty().WithMessage("Senha obrigatória.");
            RuleFor(request => request.Password.Length).GreaterThanOrEqualTo(6).WithMessage("Senha deve ter 6 ou mais caracteres.");
        }
    }
}
