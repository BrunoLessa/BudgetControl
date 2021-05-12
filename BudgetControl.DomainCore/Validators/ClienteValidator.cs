using BudgetControl.Domain.Models;
using FluentValidation;

namespace BudgetControl.DomainCore.Validators
{
    public class ClienteValidator : BaseValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .NotNull().WithMessage("O nome é obrigatório.");
            RuleFor(c => c.Sobrenome)
                .Cascade(CascadeMode.Stop)                
                .NotNull().WithMessage("O Sobrenome é obrigatório.")
                .NotEmpty().WithMessage("O Sobrenome é obrigatório.");
            RuleFor(c => c.Email)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("O e-mail é obrigatório.")
                .NotEmpty().WithMessage("O e-mail é obrigatório.")
                .EmailAddress().WithMessage("e-mail inválido.");
        }
    }
}