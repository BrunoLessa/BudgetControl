using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Interfaces.Repositories;
using BudgetControl.DomainCore.Interfaces.Services;
using BudgetControl.DomainCore.Validators;

namespace BudgetControl.DomainCore.Services
{
    public class DomainServiceCliente : DomainServiceBase<Cliente, ClienteValidator>, IDomainServiceCliente
    {
        private readonly IRepositoryCliente _repositorio;

        public DomainServiceCliente(IRepositoryCliente repository) : base(repository)
        {
            _repositorio = repository;
        }
    }
}