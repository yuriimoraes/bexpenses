

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class DespesaCarroAluguelViewModel
    {   
        [Key]
        public int DespesaCarroAluguelID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }

        [Required(ErrorMessage = "Preencha o campo de Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [DisplayName("Veiculo Compartilhado")]
        public bool VeiculoCompartilhado { get; set; }
        [DisplayName("Compartilhado com")]
        public string CompartilhadoCom { get; set; }

        [Required(ErrorMessage = "Preencha o campo de Agência")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Agência Aluguel")]
        public string AgenciaAluguel { get; set; }
        [DisplayName("Data Inicial")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInicial { get; set; }
        [DisplayName("Data Final")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFinal { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(int), "0", "9999999999999")]
        [DisplayName("Dias Extras")]
        public int DiasExtras { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        [DisplayName("Valor")]
        public double ValorDespesaCarroAluguel { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
        public string Status { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        
        [NotMapped]
        public HttpPostedFileBase Imagem { get; set; }
        
    }
}