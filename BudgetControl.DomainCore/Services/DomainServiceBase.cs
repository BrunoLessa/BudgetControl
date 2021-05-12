using BudgetControl.DomainCore.Interfaces.Repositories;
using BudgetControl.DomainCore.Interfaces.Services;
using BudgetControl.DomainCore.Validators;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BudgetControl.DomainCore.Services
{
    public abstract class DomainServiceBase<TEntity,TValidator> : IDisposable, IDomainServiceBase<TEntity, TValidator> 
        where TEntity : class
        where TValidator : BaseValidator<TEntity>
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public DomainServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task Add(TEntity obj)
        {
            Validate(obj, Activator.CreateInstance<TValidator>());
            await _repository.Add(obj);
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public virtual async Task Update(TEntity obj)
        {
            Validate(obj, Activator.CreateInstance<TValidator>());
            await _repository.Update(obj);
        }

        public virtual async Task Remove(TEntity obj)
        {
            await _repository.Remove(obj);
        }

        public virtual void Dispose()
        {
            _repository.Dispose();
        }

        public void Validate(TEntity obj, TValidator validador)
        {
            string Mensagem = "Registro invalido! \n";

            if (obj == null)
                throw new Exception("Registros não detectados!");

           var resultado = validador.Validate(obj);

            if (!resultado.IsValid)
            {
                foreach (var item in resultado.Errors)
                {
                    Mensagem += " - " + item.ErrorMessage + "\n";
                }
                throw new Exception(Mensagem);
            }
                
        }

        public async Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repository.FirstOrDefault(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repository.GetWhere(predicate);
        }

        public async Task<int> CountAll()
        {
            return await _repository.CountAll();
        }

        public async Task<int> CountWhere(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repository.CountWhere(predicate);
        }
    }
}