using BugetControl.Application.DTO.DTOs;
using System.Threading.Tasks;

namespace BugetControl.Application.Interfaces
{
    public interface IApplicationServiceUsuario : IApplicationServiceBase<UsuarioDTO>
    {
        Task<UsuarioDTO> ObterParaLogin(UsuarioDTO user);
    }
}