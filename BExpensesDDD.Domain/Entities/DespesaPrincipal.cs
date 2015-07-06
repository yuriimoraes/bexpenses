using System;
using System.Collections.Generic;
namespace BExpensesDDD.Domain.Entities
{
    public class DespesaPrincipal
    {
        public int DespesaPrincipalID { get; set; }
        public int SolicitacaoViagemID { get; set; }
        public virtual SolicitacaoViagem SolicitacaoViagem { get; set; }
        public int MoedaPadraoID { get; set; }
        public virtual Moeda MoedaPadrao { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string Observacao { get; set; }

        public virtual IEnumerable<DespesaAcomodacao> DespesasAcomodacoes { get; set; }
        public virtual IEnumerable<DespesaCarro> DespesasCarros { get; set; }
        public virtual IEnumerable<DespesaCarroAluguel> DespesasCarrosAluguel { get; set; }
        public virtual IEnumerable<DespesaOutro> DespesasOutros { get; set; }
        public virtual IEnumerable<DespesaPerDiem> DespesasPerDiem { get; set; }
        public virtual IEnumerable<DespesaTransporte> DespesasTransportes { get; set; }
        public virtual IEnumerable<DespesaViagem> DespesasViagens { get; set; }
        public virtual IEnumerable<TaxaCambio> TaxasCambio { get; set; }
        public virtual IEnumerable<SolicitacaoReembolso> SolicitacoesReembolsos { get; set; }



    }
}
