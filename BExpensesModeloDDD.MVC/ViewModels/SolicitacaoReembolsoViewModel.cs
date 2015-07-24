using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Data Reembolso")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataReembolso { get; set; }
        [DisplayName("Data Solicitação")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataSolicitacao { get; set; }
        public string Status { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        public double Valor { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }

        public virtual IEnumerable<RespostaSolicitacaoReembolsoViewModel> RespostasSolicitacoesReembolsos { get; set; }
    }
}