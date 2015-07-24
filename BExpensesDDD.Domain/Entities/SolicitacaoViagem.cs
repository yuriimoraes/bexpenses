using System;
using System.Collections.Generic;
using BExpensesDDD.Application.Enum;

namespace BExpensesDDD.Domain.Entities
{
    public class SolicitacaoViagem
    {
        public int SolicitacaoViagemID { get; set; }
        public int PessoaRecebeID { get; set; }
        public virtual Pessoa PessoaRecebe { get; set; }
        public int PessoaSolicitanteID { get; set; }
        public virtual Pessoa PessoaSolicitante { get; set; }
        public string DescricaoViagem { get; set; }
        public bool Adiantamento { get; set; }
        public double ValorAdiantamento  { get; set; }
        public int PaisOrigemID { get; set; }
        public virtual Pais PaisOrigem { get; set; }
        public string CidadeOrigem { get; set; }
        public int PaisDestinoID { get; set; }
        public virtual Pais PaisDestino { get; set; }
        public string CidadeDestino { get; set; }
        public DateTime DataViagemIncial { get; set; }
        public DateTime DataViagemFinal { get; set; }
        public Status Status { get; set; }

        public virtual IEnumerable<DespesaPrincipal> DespesasPrincipais { get; set; }
        public virtual IEnumerable<DespesaPerDiem> DespesasPerDiem { get; set; }
        public virtual IEnumerable<RespostaSolicitacaoViagem> RespostasSolicitacoesViagens { get; set; }

    }
}
