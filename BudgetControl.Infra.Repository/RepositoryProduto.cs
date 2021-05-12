using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Interfaces.Repositories;
using BudgetControl.Infra.Data;

namespace BudgetControl.Infra.Repository
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly DataContext _context;

        public RepositoryProduto(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}