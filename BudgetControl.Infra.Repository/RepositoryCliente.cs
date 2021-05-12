using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Interfaces.Repositories;
using BudgetControl.Infra.Data;

namespace BudgetControl.Infra.Repository
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly DataContext _context;

        public RepositoryCliente(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}