

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class DespesaPerDiemViewModel
    {
        [Key]
        public int DespesaPerID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }
        [DisplayName("Solicitação Viagem ID")]
        public int SolicitacaoViagemID { get; set; }
        public virtual SolicitacaoViagemViewModel SolicitacaoViagem { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [DisplayName("Valor")]
        public double ValorTotal { get; set; }

    }
}