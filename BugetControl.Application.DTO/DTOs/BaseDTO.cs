using System;

namespace BugetControl.Application.DTO.DTOs
{
    public abstract class BaseDTO
    {
        public int? Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}