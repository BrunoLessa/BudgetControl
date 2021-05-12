using BudgetControl.Domain.Models.Base;

namespace BudgetControl.Domain.Models
{
    public class UnidadeMedida : BaseEntity
    {
        public string Abreviatura { get; set; }
        public string Descricao { get; set; }
    }
}