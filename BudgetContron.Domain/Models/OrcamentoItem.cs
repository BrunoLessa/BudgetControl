using BudgetControl.Domain.Models.Base;

namespace BudgetControl.Domain.Models
{
    public class OrcamentoItem : ItemBase
    {
        public int IdOrcamento { get; set; }
        public Orcamento Orcamento { get; set; }
    }
}