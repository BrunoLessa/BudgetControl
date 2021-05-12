using BudgetControl.DomainCore.Interfaces.Services;
using BudgetControl.DomainCore.Validators;
using BudgetControl.Infra.CrossCutting.Adapter.Interfaces;
using BugetControl.Application.DTO.DTOs;
using BugetControl.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugetControl.Application.Services
{
    public abstract class ApplicationServiceBase<TEntity, TEntityDTO,TValidator> : IApplicationServiceBase<TEntityDTO>
        where TEntity : class
        where TEntityDTO : BaseDTO
        where TValidator : BaseValidator<TEntity>
    {
        private readonly IDomainServiceBase<TEntity,TValidator> _domain;
        private readonly IMapperBase<TEntity, TEntityDTO> _mapper;

        public ApplicationServiceBase(IDomainServiceBase<TEntity,TValidator> domain, IMapperBase<TEntity, TEntityDTO> mapper)
        {
            _domain = domain;
            _mapper = mapper;
        }

        public async Task Add(TEntityDTO obj)
        {
            var objeto = _mapper.MapperToEntity(obj);
            await _domain.Add(objeto);
        }

        public void Dispose()
        {
            _domain.Dispose();
        }

        public async Task<IEnumerable<TEntityDTO>> GetAll()
        {
            var objetos = await _domain.GetAll();
            return _mapper.MapperToList(objetos);
        }

        public async Task<TEntityDTO> GetById(int id)
        {
            var objeto = await _domain.GetById(id);
            return _mapper.MapperToDTO(objeto);
        }

        public async Task Remove(TEntityDTO obj)
        {
            var objeto = _mapper.MapperToEntity(obj);
            await _domain.Remove(objeto);
        }

        public async Task Update(TEntityDTO obj)
        {
            var objeto = _mapper.MapperToEntity(obj);
            await _domain.Update(objeto);
        }
    }
}