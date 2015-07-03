
using System;
using System.Collections.Generic;
namespace BExpensesDDD.Domain.Entities
{
    public class SolicitacaoReembolso
    {
        public int SolicitacaoReembolsoID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipal DespesaPrincipal { get; set; }
        public int RespostaSolicitacaoID { get; set; }
        public virtual RespostaSolicitacao RespostaSolicitacao { get; set; }
        public DateTime DataReembolso { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string Status { get; set; }
        public double Valor { get; set; }
        public string Observacao { get; set; }

        
    }
}
