

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class DespesaCarroViewModel
    {
        [Key]
        public int DespesaCarroID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }
        public int TipoDespesaCarroID { get; set; }
        public virtual TipoDespesaCarroViewModel TipoDespesaCarro { get; set; }


        [Required(ErrorMessage = "Preencha o campo de Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Descrição")]
        public string DescricaoDespesa { get; set; }


        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        [DisplayName("Valor")]
        public double ValorDespesaCarro { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
        [DisplayName("Km Rodada")]
        public double KmRodado { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [NotMapped]
        public HttpPostedFileBase Imagem { get; set; }
    }
}