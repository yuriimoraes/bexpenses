
namespace BExpensesDDD.Domain.Entities
{
    public class DespesaPerDiem
    {
        public int DespesaPerID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipal DespesaPrincipal { get; set; }
        public int SolicitacaoViagemID { get; set; }
        public virtual SolicitacaoViagem SolicitacaoViagem { get; set; }
        public double ValorTotal { get; set; }

    }
}
