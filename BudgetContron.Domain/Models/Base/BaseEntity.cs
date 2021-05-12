using System;

namespace BudgetControl.Domain.Models.Base
{
    public class BaseEntity
    {
        public int? Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}