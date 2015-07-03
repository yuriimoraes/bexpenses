

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class SolicitacaoViagemViewModel
    {

        public int SolicitacaoViagemID { get; set; }
        public int PessoaRecebeID { get; set; }
        //public virtual Pessoa PessoaRecebe { get; set; }
        public int PessoaSolicitanteID { get; set; }
        //public virtual Pessoa PessoaSolicitante { get; set; }
        public int RespostaSolicitacaoID { get; set; }
        //public virtual RespostaSolicitacao RespostaSolicitacao { get; set; }
        public string DescricaoViagem { get; set; }
        public bool Adiantamento { get; set; }
        public double ValorAdiantamento { get; set; }
        public int PaisOrigemID { get; set; }
        //public virtual Pais PaisOrigem { get; set; }
        public string CidadeOrigem { get; set; }
        public int PaisDestinoID { get; set; }
        //public virtual Pais PaisDestino { get; set; }
        public string CidadeDestino { get; set; }
        //public DateTime DataViagemIncial { get; set; }
        //public DateTime DataViagemFinal { get; set; }
        public string Status { get; set; }

        //public virtual IEnumerable<DespesaPrincipal> DespesasPrincipais { get; set; }
        //public virtual IEnumerable<DespesaPerDiem> DespesasPerDiem { get; set; }
    }
}