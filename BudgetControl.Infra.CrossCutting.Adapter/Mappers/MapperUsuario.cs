using BudgetControl.Domain.Models;
using BudgetControl.Infra.CrossCutting.Adapter.Interfaces;
using BugetControl.Application.DTO.DTOs;
using System.Collections.Generic;

namespace BudgetControl.Infra.CrossCutting.Adapter.Mappers
{
    public class MapperUsuario : IMapperUsuario
    {
        private List<UsuarioDTO> usuariosDTO = new List<UsuarioDTO>();

        public UsuarioDTO MapperToDTO(Usuario obj)
        {
            UsuarioDTO usuarioDto = new UsuarioDTO
            {
                Id = obj.Id,
                DataCadastro = obj.DataCadastro,
                Nome = obj.Nome,
                Login = obj.Login,
                PassWord = obj.PassWord,
                Ativo = obj.Ativo,
                Role = obj.Role
            };
            return usuarioDto;
        }

        public Usuario MapperToEntity(UsuarioDTO objDTO)
        {
            Usuario usuario = new Usuario
            {
                Id = objDTO.Id,
                DataCadastro = objDTO.DataCadastro,
                Login = objDTO.Login,
                PassWord = objDTO.PassWord,
                Nome = objDTO.Nome,
                Ativo = objDTO.Ativo,
                 Role = objDTO.Role
            };
            return usuario;
        }

        public IEnumerable<UsuarioDTO> MapperToList(IEnumerable<Usuario> obj)
        {
            foreach (var item in obj)
            {
                UsuarioDTO usuarioDto = new UsuarioDTO
                {
                    Id = item.Id,
                    DataCadastro = item.DataCadastro,
                    Login = item.Login,
                    Nome = item.Nome,
                    PassWord = item.PassWord,
                    Ativo = item.Ativo,
                    Role = item.Role
                };

                usuariosDTO.Add(usuarioDto);
            }

            return usuariosDTO;
        }
    }
}