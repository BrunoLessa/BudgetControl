using BudgetControl.Domain.Enums;

namespace BugetControl.Application.DTO.DTOs
{
    public class UsuarioDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string PassWord { get; set; }
        public bool Ativo { get; set; }
        public EnumRoles Role { get; set; }
    }
}