using BudgetControl.Domain.Models;
using BudgetControl.DomainCore.Interfaces.Services;
using BudgetControl.DomainCore.Validators;
using BudgetControl.Infra.CrossCutting.Adapter.Interfaces;
using BugetControl.Application.DTO.DTOs;
using BugetControl.Application.Interfaces;
using System.Threading.Tasks;

namespace BugetControl.Application.Services
{
    public class ApplicationServiceUsuario : ApplicationServiceBase<Usuario, UsuarioDTO, UsuarioValidator>, IApplicationServiceUsuario
    {
        private readonly IDomainServiceUsuario _domain;
        private readonly IMapperUsuario _mapper;
        public ApplicationServiceUsuario(IDomainServiceUsuario domain, IMapperUsuario mapper) : base(domain, mapper)
        {
            _domain = domain;
            _mapper = mapper;
        }

        public async Task<UsuarioDTO> ObterParaLogin(UsuarioDTO user)
        {
            var objeto = _mapper.MapperToEntity(user);
            var retorno = await _domain.FirstOrDefault(x => x.Login == objeto.Login && x.PassWord == objeto.PassWord);
            return _mapper.MapperToDTO(retorno);
        }
    }
}