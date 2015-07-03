using System;
using System.Collections.Generic;
namespace BExpensesDDD.Domain.Entities
{
    public class RespostaSolicitacao
    {
        public int RespostaSolicitacaoID { get; set; }
        public int AprovadorID { get; set; }
        public virtual Pessoa Aprovador { get; set; }
        public DateTime DataResposta { get; set; }
        public string Status { get; set; }
        public string Observacao { get; set; }
        public virtual IEnumerable<SolicitacaoViagem> SolicitacoesViagens { get; set; }
        public virtual IEnumerable<SolicitacaoReembolso> SolicitacoesReembolsos { get; set; }
    }
}
