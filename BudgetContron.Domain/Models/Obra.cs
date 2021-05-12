using BudgetControl.Domain.Models.Base;

namespace BudgetControl.Domain.Models
{
    public class Obra : BaseEntity
    {
        public Imovel Imovel { get; set; }
        public int IdImovel { get; set; }
        public decimal ValorTotal { get; set; }
    }
}