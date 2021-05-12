using BudgetControl.Domain.Models.Base;

namespace BudgetControl.Domain.Models
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}