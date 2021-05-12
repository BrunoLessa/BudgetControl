using BudgetControl.Domain.Models;
using BudgetControl.Infra.CrossCutting.Adapter.Interfaces;
using BugetControl.Application.DTO.DTOs;
using System.Collections.Generic;

namespace BudgetControl.Infra.CrossCutting.Adapter.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        #region properties

        private List<ClienteDTO> clienteDTOs = new List<ClienteDTO>();

        #endregion properties

        #region methods

        public Cliente MapperToEntity(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente
            {
                Id = clienteDTO.Id,
                Nome = clienteDTO.Nome,
                Sobrenome = clienteDTO.Sobrenome,
                Email = clienteDTO.Email
            };

            return cliente;
        }

        public IEnumerable<ClienteDTO> MapperToList(IEnumerable<Cliente> clientes)
        {
            foreach (var item in clientes)
            {
                ClienteDTO clienteDTO = new ClienteDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Sobrenome = item.Sobrenome,
                    Email = item.Email
                };

                clienteDTOs.Add(clienteDTO);
            }

            return clienteDTOs;
        }

        public ClienteDTO MapperToDTO(Cliente Cliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO
            {
                Id = Cliente.Id,
                Nome = Cliente.Nome,
                Sobrenome = Cliente.Sobrenome,
                Email = Cliente.Email
            };

            return clienteDTO;
        }

        #endregion methods
    }
}