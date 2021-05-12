using BudgetControl.Domain.Models.Base;
using System;
using System.Collections.Generic;

namespace BudgetControl.Domain.Models
{
    public class Orcamento : BaseEntity
    {
        public Imovel Imovel { get; set; }
        public int IdImovel { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int IdFornecedor { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataOrcamento { get; set; }
        public List<OrcamentoItem> Itens { get; set; }
    }
}