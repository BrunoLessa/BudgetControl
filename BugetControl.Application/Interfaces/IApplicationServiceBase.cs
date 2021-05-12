using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BugetControl.Application.Interfaces
{
    public interface IApplicationServiceBase<TEntityDTO>
    {
        Task Add(TEntityDTO obj);

        Task<TEntityDTO> GetById(int id);

        Task<IEnumerable<TEntityDTO>> GetAll();

        Task Update(TEntityDTO obj);

        Task Remove(TEntityDTO obj);

        void Dispose(); 
    }
}