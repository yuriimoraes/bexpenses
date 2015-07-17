using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class RespostaSolicitacaoViewModel
    {
        [Key]
        public int RespostaSolicitacaoID { get; set; }
        [DisplayName("Aprovador")]
        public int AprovadorID { get; set; }
        public virtual PessoaViewModel Aprovador { get; set; }
        [DisplayName("Data Resposta")]
        public DateTime DataResposta { get; set; }
        public string Status { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
        public virtual IEnumerable<SolicitacaoViagemViewModel> SolicitacoesViagens { get; set; }
        public virtual IEnumerable<SolicitacaoReembolsoViewModel> SolicitacoesReembolsos { get; set; }
    }
}