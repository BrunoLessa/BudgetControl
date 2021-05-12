using BudgetControl.Domain.Models;
using BugetControl.Application.DTO.DTOs;

namespace BudgetControl.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCliente : IMapperBase<Cliente, ClienteDTO>
    {
    }
}