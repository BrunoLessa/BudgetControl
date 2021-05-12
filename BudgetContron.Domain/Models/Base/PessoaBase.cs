using BudgetControl.Domain.Enums;

namespace BudgetControl.Domain.Models.Base
{
    public abstract class PessoaBase : BaseEntity
    {
        public string Nome { get; set; }
        public string CPFCNPJ { get; set; }
        public EnumTipoPessoa Tipo { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}