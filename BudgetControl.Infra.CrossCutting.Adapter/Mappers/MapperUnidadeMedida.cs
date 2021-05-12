using BudgetControl.Domain.Models;
using BudgetControl.Infra.CrossCutting.Adapter.Interfaces;
using BugetControl.Application.DTO.DTOs;
using System.Collections.Generic;

namespace BudgetControl.Infra.CrossCutting.Adapter.Mappers
{
    public class MapperUnidadeMedida : IMapperUnidadeMedida
    {
        #region Properties

        private List<UnidadeMedidaDTO> unidadeMedidaDTOs = new List<UnidadeMedidaDTO>();

        #endregion Properties

        #region Methods

        public UnidadeMedidaDTO MapperToDTO(UnidadeMedida obj)
        {
            UnidadeMedidaDTO unidadeMedidaDTO = new UnidadeMedidaDTO
            {
                Id = obj.Id,
                Abreviatura = obj.Abreviatura,
                Descricao = obj.Descricao,
                DataCadastro = obj.DataCadastro
            };
            return unidadeMedidaDTO;
        }

        public UnidadeMedida MapperToEntity(UnidadeMedidaDTO objDTO)
        {
            UnidadeMedida unidadeMedida = new UnidadeMedida
            {
                Id = objDTO.Id,
                Abreviatura = objDTO.Abreviatura,
                Descricao = objDTO.Descricao,
                DataCadastro = objDTO.DataCadastro
            };
            return unidadeMedida;
        }

        public IEnumerable<UnidadeMedidaDTO> MapperToList(IEnumerable<UnidadeMedida> obj)
        {
            foreach (var item in obj)
            {
                UnidadeMedidaDTO unidadeMedidaDTO = new UnidadeMedidaDTO
                {
                    Id = item.Id,
                    Abreviatura = item.Abreviatura,
                    Descricao = item.Descricao,
                    DataCadastro = item.DataCadastro
                };

                unidadeMedidaDTOs.Add(unidadeMedidaDTO);
            }

            return unidadeMedidaDTOs;
        }
    }

    #endregion Methods
}