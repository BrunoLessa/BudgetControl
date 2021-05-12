using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Interfaces.Repositories;
using BudgetControl.DomainCore.Interfaces.Services;
using BudgetControl.DomainCore.Validators;

namespace BudgetControl.DomainCore.Services
{
    public class DomainServiceUsuario : DomainServiceBase<Usuario, UsuarioValidator>, IDomainServiceUsuario
    {
        private readonly IRepositoryUsuario _repository;
        public DomainServiceUsuario(IRepositoryUsuario repository) : base(repository)
        {
            _repository = repository;
        }
    }
}