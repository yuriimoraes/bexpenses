
using System;
using System.Collections.Generic;
using BExpensesDDD.Application.Enum;

namespace BExpensesDDD.Domain.Entities
{
    public class SolicitacaoReembolso
    {
        public int SolicitacaoReembolsoID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipal DespesaPrincipal { get; set; }
        public DateTime DataReembolso { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public Status Status { get; set; }
        public double Valor { get; set; }
        public string Observacao { get; set; }

        public virtual IEnumerable<RespostaSolicitacaoReembolso> RespostasSolicitacoesReembolsos { get; set; }
        
    }
}
