

using System;
using System.ComponentModel.DataAnnotations;
namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class DespesaCarroAlguelViewModel
    {   
        [Key]
        public int DespesaCarroAluguelID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }

        [Required(ErrorMessage = "Preencha o campo de Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Descricao { get; set; }
        public bool VeiculoCompartilhado { get; set; }
        public string CompartilhadoCom { get; set; }

        [Required(ErrorMessage = "Preencha o campo de Agência")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string AgenciaAluguel { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(int), "0", "9999999999999")]
        public int DiasExtras { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        public double ValorDespesaCarroAluguel { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}