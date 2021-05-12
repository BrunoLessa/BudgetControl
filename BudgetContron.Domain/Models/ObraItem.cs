using BudgetControl.Domain.Models.Base;

namespace BudgetControl.Domain.Models
{
    public class ObraItem : ItemBase
    {
        public int IdObra { get; set; }
        public int? IdOrcamentoItem { get; set; }
        public OrcamentoItem OrcamentoItem { get; set; }
    }
}