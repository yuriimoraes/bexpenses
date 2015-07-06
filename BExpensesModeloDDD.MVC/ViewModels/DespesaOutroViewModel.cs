

using System;
using System.ComponentModel.DataAnnotations;
namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class DespesaOutroViewModel
    {
        [Key]
        public int DespesaOutroID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }

        [Required(ErrorMessage = "Preencha o campo de Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string DescricaoGeral { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        public double ValorDespesaOutro { get; set; }
        public string Observacao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}