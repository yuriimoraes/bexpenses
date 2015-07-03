
using System.Collections.Generic;
namespace BExpensesDDD.Domain.Entities
{
    public class Pais
    {
        public int PaisID { get; set; }
        public string NomePais { get; set; }

        public virtual IEnumerable<DespesaAcomodacao> DespesasAcomodacoes { get; set; }
        public virtual IEnumerable<SolicitacaoViagem> SolicitacaoViagens { get; set; }
    }
}
