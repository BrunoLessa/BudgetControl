namespace BudgetControl.Domain.Models.Base
{
    public abstract class ItemBase : BaseEntity
    {
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotalItem { get; set; }
    }
}