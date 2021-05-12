using BudgetControl.Domain.Models.Base;
using FluentValidation;

namespace BudgetControl.DomainCore.Validators
{
    public abstract class BaseValidator<TEntity> : AbstractValidator<TEntity> 
        where TEntity : class
    {
        public BaseValidator()
        {
        }
    }
}