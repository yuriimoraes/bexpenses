using System.Collections.Generic;
namespace BExpensesDDD.Domain.Entities
{
    public class ClasseViagem
    {
        public int ClasseViagemID { get; set; }
        public string DescricaoViagem { get; set; }
        public virtual IEnumerable<DespesaViagem> DespesasViagens { get; set; }
    }
}
