using BudgetControl.Domain.Enums;
using BudgetControl.Domain.Models.Base;

namespace BudgetControl.Domain.Models
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string PassWord { get; set; }        
        public bool Ativo { get; set; }
        public EnumRoles Role { get; set; }
    }
}