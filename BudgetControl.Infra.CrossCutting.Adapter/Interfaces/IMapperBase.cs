using System.Collections.Generic;

namespace BudgetControl.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IMapperBase<TEntity, TEntityDTO>
    {
        TEntity MapperToEntity(TEntityDTO objDTO);

        IEnumerable<TEntityDTO> MapperToList(IEnumerable<TEntity> obj);

        TEntityDTO MapperToDTO(TEntity obj);
    }
}