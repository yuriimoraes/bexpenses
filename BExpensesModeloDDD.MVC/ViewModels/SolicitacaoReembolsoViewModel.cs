using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class SolicitacaoReembolsoViewModel
    {
        [Key]
        public int SolicitacaoReembolsoID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }
        public int RespostaSolicitacaoID { get; set; }
        public virtual RespostaSolicitacaoViewModel RespostaSolicitacao { get; set; }
        public DateTime DataReembolso { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string Status { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        public double Valor { get; set; }
        public string Observacao { get; set; }
    }
}