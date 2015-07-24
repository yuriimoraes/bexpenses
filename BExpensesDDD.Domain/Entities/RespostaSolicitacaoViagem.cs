using System;
using System.Collections.Generic;
using BExpensesDDD.Application.Enum;

namespace BExpensesDDD.Domain.Entities
{
    public class RespostaSolicitacaoViagem
    {
        public int RespostaSolicitacaoViagemID { get; set; }
        public int SolicitacaoViagemID { get; set; }
        public virtual SolicitacaoViagem SolicitacaoViagem { get; set; }
        public int AprovadorID { get; set; }
        public virtual Pessoa Aprovador { get; set; }
        public DateTime DataCadastro { get; set; }
        public Status Status { get; set; }
        public string Observacao { get; set; }
    }
}
