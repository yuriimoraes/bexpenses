using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class TipoViagemViewModel
    {
        [Key]
        public int TipoViagemID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}