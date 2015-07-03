

using System.Collections.Generic;
namespace BExpensesDDD.Domain.Entities
{
    public class Moeda
    {
        public int MoedaID { get; set; }
        public string CodigoMoeda { get; set; }
        public string NomeMoeda { get; set; }
        public string CodigoInternacional { get; set; }
        public string DescricaoInternacional { get; set; }
        public string CodigoMoedaISO { get; set; }

        public virtual IEnumerable<DespesaPrincipal> DespesasPrincipais { get; set; }
        public virtual IEnumerable<TaxaCambio> TaxasCambio { get; set; }

    }
}
