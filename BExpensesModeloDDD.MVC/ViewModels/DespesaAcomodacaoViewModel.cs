using System;
using System.ComponentModel.DataAnnotations;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class DespesaAcomodacaoViewModel
    {
        [Key]
        public int DespesaAcomodacaoID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }
        public int TipoAcomodacaoID { get; set; }
        public virtual TipoAcomodacaoViewModel TipoAcomodacao { get; set; }
        [Required(ErrorMessage = "Preencha o campo Descrição de Acomodacação")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string DescricaoAcomodacao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int PaisAcomodacaoID { get; set; }
        public virtual PaisViewModel PaisAcomodacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo de Cidade")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string CidadeAcomodacao { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        public double ValorDespesaAcomodacao { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}