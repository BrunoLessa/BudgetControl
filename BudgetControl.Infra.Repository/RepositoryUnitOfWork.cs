using BudgetControl.DomainCore.Interfaces.Repositories;
using BudgetControl.Infra.Data;
using System.Threading.Tasks;

namespace BudgetControl.Infra.Repository
{
    public class RepositoryUnitOfWork : IRepositoryUnitOfWork
    {
        private readonly DataContext _context;

        public RepositoryUnitOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}