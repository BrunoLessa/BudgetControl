using BudgetControl.Domain.Models;
using BudgetControl.Infra.CrossCutting.Adapter.Interfaces;
using BugetControl.Application.DTO.DTOs;
using System.Collections.Generic;

namespace BudgetControl.Infra.CrossCutting.Adapter.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        #region Properties

        private List<ProdutoDTO> produtoDTOs = new List<ProdutoDTO>();

        #endregion Properties

        #region Methods

        public ProdutoDTO MapperToDTO(Produto obj)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO
            {
                Id = obj.Id,
                Descricao = obj.Descricao,
                Ativo = obj.Ativo,
                DataCadastro = obj.DataCadastro,
                IdUnidadeMedida = obj.IdUnidadeMedida,
                UnidadeMedidaDTO = new UnidadeMedidaDTO
                {
                    Id = obj.UnidadeMedida.Id,
                    Descricao = obj.UnidadeMedida.Descricao,
                    Abreviatura = obj.UnidadeMedida.Abreviatura,
                    DataCadastro = obj.UnidadeMedida.DataCadastro
                }
            };
            return produtoDTO;
        }

        public Produto MapperToEntity(ProdutoDTO objDTO)
        {
            Produto produto = new Produto
            {
                Id = objDTO.Id,
                Descricao = objDTO.Descricao,
                DataCadastro = objDTO.DataCadastro,
                Ativo = objDTO.Ativo,
                IdUnidadeMedida = objDTO.IdUnidadeMedida,
                UnidadeMedida = new UnidadeMedida
                {
                    Id = objDTO.UnidadeMedidaDTO.Id,
                    Descricao = objDTO.UnidadeMedidaDTO.Descricao,
                    Abreviatura = objDTO.UnidadeMedidaDTO.Abreviatura,
                    DataCadastro = objDTO.UnidadeMedidaDTO.DataCadastro
                }
            };
            return produto;
        }

        public IEnumerable<ProdutoDTO> MapperToList(IEnumerable<Produto> obj)
        {
            foreach (var item in obj)
            {
                ProdutoDTO produtoDTO = new ProdutoDTO
                {
                    Id = item.Id,
                    Descricao = item.Descricao,
                    Ativo = item.Ativo,
                    DataCadastro = item.DataCadastro,
                    IdUnidadeMedida = item.IdUnidadeMedida,
                    UnidadeMedidaDTO = new UnidadeMedidaDTO
                    {
                        Id = item.UnidadeMedida.Id,
                        Descricao = item.UnidadeMedida.Descricao,
                        Abreviatura = item.UnidadeMedida.Abreviatura,
                        DataCadastro = item.UnidadeMedida.DataCadastro
                    }
                };
                produtoDTOs.Add(produtoDTO);
            }
            return produtoDTOs;
        }

        #endregion Methods
    }
}