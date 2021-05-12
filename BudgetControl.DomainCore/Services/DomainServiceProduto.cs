using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Interfaces.Repositories;
using BudgetControl.DomainCore.Interfaces.Services;
using BudgetControl.DomainCore.Validators;

namespace BudgetControl.DomainCore.Services
{
    public class DomainServiceProduto : DomainServiceBase<Produto,ProdutoValidator>, IDomainServiceProduto
    {
        private readonly IRepositoryProduto _repositorio;

        public DomainServiceProduto(IRepositoryProduto repository) : base(repository)
        {
            _repositorio = repository;
        }
    }
}