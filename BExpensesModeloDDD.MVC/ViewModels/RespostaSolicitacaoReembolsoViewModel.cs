using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BExpensesDDD.Application.Enum;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class RespostaSolicitacaoReembolsoViewModel
    {
        [Key]
        public int RespostaSolicitacaoID { get; set; }
        [DisplayName("Solicitação Reembolso")]
        public int SolicitacaoReembolsoID { get; set; }
        public virtual SolicitacaoReembolsoViewModel SolicitacaoReembolso { get; set; }
        [DisplayName("Aprovador")]
        public int AprovadorID { get; set; }
        public virtual PessoaViewModel Aprovador { get; set; }
        [ScaffoldColumn(false)]
        [DisplayName("Data Resposta")]
        public DateTime DataCadastro { get; set; }
        public Status Status { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
    }
}