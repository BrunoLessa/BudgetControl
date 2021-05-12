namespace BugetControl.Application.DTO.DTOs
{
    public class ProdutoDTO: BaseDTO
    {        
        public string Descricao { get; set; }        
        public int IdUnidadeMedida { get; set; }
        public UnidadeMedidaDTO UnidadeMedidaDTO { get; set; }
        public bool Ativo { get; set; }
    }
}