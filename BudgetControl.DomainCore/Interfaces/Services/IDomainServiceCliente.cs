using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Validators;

namespace BudgetControl.DomainCore.Interfaces.Services
{
    public interface IDomainServiceCliente : IDomainServiceBase<Cliente,ClienteValidator>
    {
    }
}