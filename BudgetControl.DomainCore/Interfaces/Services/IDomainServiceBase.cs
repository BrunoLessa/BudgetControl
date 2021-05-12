using BudgetControl.DomainCore.Validators;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BudgetControl.DomainCore.Interfaces.Services
{
    public interface IDomainServiceBase<TEntity, TValidator>
        where TEntity : class
        where TValidator : BaseValidator<TEntity>
    {
        Task Add(TEntity obj);

        Task<TEntity> GetById(int id);

        Task<IEnumerable<TEntity>> GetAll();

        Task Update(TEntity obj);

        Task Remove(TEntity obj);

        void Dispose();

        void Validate(TEntity obj, TValidator validador);
        Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicate);

        Task<int> CountAll();

        Task<int> CountWhere(Expression<Func<TEntity, bool>> predicate);
    }
}