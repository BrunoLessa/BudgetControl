using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Interfaces.Repositories;
using BudgetControl.Infra.Data;

namespace BudgetControl.Infra.Repository
{
    public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
    {
        public RepositoryUsuario(DataContext context) : base(context)
        {
        }
    }
}