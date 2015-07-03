using System.Collections.Generic;
namespace BExpensesDDD.Domain.Entities
{
    public class TipoDespesaCarro
    {
        public int TipoDespesaCarroID { get; set; }
        public string DescricaoDespesaCarro { get; set; }

        public virtual IEnumerable<DespesaCarro> DespesasCarros { get; set; }
    }
}
