

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class MoedaViewModel
    {
        [Key]
        public int MoedaID { get; set; }
        [DisplayName("Código Moeda")]
        public string CodigoMoeda { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Moeda")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Nome Moeda")]
        public string NomeMoeda { get; set; }
        [DisplayName("Código Internacional")]
        public string CodigoInternacional { get; set; }
        [DisplayName("Descrição Internacional")]
        public string DescricaoInternacional { get; set; }
        [DisplayName("Código Moeda ISO")]
        public string CodigoMoedaISO { get; set; }

        public virtual IEnumerable<DespesaPrincipalViewModel> DespesasPrincipais { get; set; }
        public virtual IEnumerable<TaxaCambioViewModel> TaxasCambio { get; set; }

    }
}