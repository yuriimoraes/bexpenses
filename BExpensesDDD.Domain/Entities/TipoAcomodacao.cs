
using System.Collections.Generic;
namespace BExpensesDDD.Domain.Entities
{
    public class TipoAcomodacao
    {
        public int TipoAcomodacaoID { get; set; }
        public string DescricaoTipoAcomodacao { get; set; }
        public virtual IEnumerable<DespesaAcomodacao> DespesasAcomodacoes { get; set; }
    }
}
