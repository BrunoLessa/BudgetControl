using BudgetControl.Domain.Models.Base;

namespace BudgetControl.Domain.Models
{
    public class Produto : BaseEntity
    {
        public string Descricao { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public int IdUnidadeMedida { get; set; }
        public bool Ativo { get; set; }
    }
}