using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Validators;

namespace BudgetControl.DomainCore.Interfaces.Services
{
    public interface IDomainServiceProduto : IDomainServiceBase<Produto,ProdutoValidator>
    {
    }
}