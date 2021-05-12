using BudgetControl.Domain.Enums;
using BudgetControl.Domain.Models.Base;
using System;

namespace BudgetControl.Domain.Models
{
    public class Imovel : BaseEntity
    {
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public EnumTipoImovel Tipo { get; set; }
        public decimal ValorVenal { get; set; }
        public DateTime UltimaReforma { get; set; }
        public Propietario Propietario { get; set; }
        public int IdPropietario { get; set; }
        public bool Ativo { get; set; }
    }
}