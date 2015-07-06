

using System.ComponentModel.DataAnnotations;
namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class DespesaPerDiemViewModel
    {
        [Key]
        public int DespesaPerID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }
        public int SolicitacaoViagemID { get; set; }
        public virtual SolicitacaoViagemViewModel SolicitacaoViagem { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        public double ValorTotal { get; set; }

    }
}