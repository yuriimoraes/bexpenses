
using System;
namespace BExpensesDDD.Domain.Entities
{
    public class DespesaViagem
    {
        public int DespesaViagemID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipal DespesaPrincipal { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public int ClasseViagemID { get; set; }
        public virtual ClasseViagem ClasseViagem { get; set; }
        public string NumeroBilhete { get; set; }
        public double ValorBilhete { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
