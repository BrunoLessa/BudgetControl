using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Interfaces.Services;
using BudgetControl.DomainCore.Validators;
using BudgetControl.Infra.CrossCutting.Adapter.Interfaces;
using BugetControl.Application.DTO.DTOs;
using BugetControl.Application.Interfaces;

namespace BugetControl.Application.Services
{
    public class ApplicationServiceProduto : ApplicationServiceBase<Produto, ProdutoDTO,ProdutoValidator>, IApplicationServiceProduto
    {
        private readonly IDomainServiceProduto _domain;
        private readonly IMapperProduto _mapper;

        public ApplicationServiceProduto(IDomainServiceProduto domain, IMapperProduto mapper) : base(domain, mapper)
        {
            _domain = domain;
            _mapper = mapper;
        }
    }
}