using FluentValidation;
using MyEcommerce.Communication.Requests.Auth;

namespace MyEcommerce.Application.Auth
{
    public class RegisterValidation : AbstractValidator<RegisterJson>
    {
        public RegisterValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Nome é obrigatório.");
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("E-mail é obrigatório");
            RuleFor(x => x.Cpf)
                .NotEmpty()
                .WithMessage("CPF é obrigatório");
            RuleFor(x => x.Senha)
                .MinimumLength(8)
                .WithMessage("A senha deve ter no minimo 8 caracteres");
        }
    }
}
