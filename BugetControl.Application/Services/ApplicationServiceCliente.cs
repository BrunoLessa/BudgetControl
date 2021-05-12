using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Interfaces.Services;
using BudgetControl.DomainCore.Validators;
using BudgetControl.Infra.CrossCutting.Adapter.Interfaces;
using BugetControl.Application.DTO.DTOs;
using BugetControl.Application.Interfaces;

namespace BugetControl.Application.Services
{
    public class ApplicationServiceCliente : ApplicationServiceBase<Cliente, ClienteDTO,ClienteValidator>, IApplicationServiceCliente
    {
        private readonly IDomainServiceCliente _domain;
        private readonly IMapperCliente _mapper;

        public ApplicationServiceCliente(IDomainServiceCliente domain, IMapperCliente mapper) : base(domain, mapper)
        {
            _domain = domain;
            _mapper = mapper;
        }
    }
}