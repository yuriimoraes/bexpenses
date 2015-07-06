using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class RespostaSolicitacaoViewModel
    {
        [Key]
        public int RespostaSolicitacaoID { get; set; }
        public int AprovadorID { get; set; }
        public virtual PessoaViewModel Aprovador { get; set; }
        
        public DateTime DataResposta { get; set; }
        public string Status { get; set; }
        public string Observacao { get; set; }
        public virtual IEnumerable<SolicitacaoViagemViewModel> SolicitacoesViagens { get; set; }
        public virtual IEnumerable<SolicitacaoReembolsoViewModel> SolicitacoesReembolsos { get; set; }
    }
}