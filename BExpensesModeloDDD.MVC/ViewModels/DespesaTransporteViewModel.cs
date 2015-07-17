

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class DespesaTransporteViewModel
    {
        [Key]
        public int DespesaTransporteID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }

        [Required(ErrorMessage = "Preencha o campo Origem")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Origem { get; set; }

        [Required(ErrorMessage = "Preencha o campo Destino")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Destino { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        [DisplayName("Valor")]
        public double ValorTransporte { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
        public string Status { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}