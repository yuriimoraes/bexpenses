

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class MoedaViewModel
    {
        [Key]
        public int MoedaID { get; set; }
        public string CodigoMoeda { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Moeda")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string NomeMoeda { get; set; }
        public string CodigoInternacional { get; set; }
        public string DescricaoInternacional { get; set; }
        public string CodigoMoedaISO { get; set; }

        public virtual IEnumerable<DespesaPrincipalViewModel> DespesasPrincipais { get; set; }
        public virtual IEnumerable<TaxaCambioViewModel> TaxasCambio { get; set; }

    }
}