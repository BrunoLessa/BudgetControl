using System.Threading.Tasks;

namespace BudgetControl.DomainCore.Interfaces.Repositories
{
    public interface IRepositoryUnitOfWork
    {
        Task Commit();
    }
}