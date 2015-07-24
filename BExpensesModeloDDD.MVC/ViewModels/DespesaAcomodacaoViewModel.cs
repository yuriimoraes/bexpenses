using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class DespesaAcomodacaoViewModel
    {
        [Key]
        public int DespesaAcomodacaoID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }
        [DisplayName("Tipo Acomodação")]
        public int TipoAcomodacaoID { get; set; }
        public virtual TipoAcomodacaoViewModel TipoAcomodacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição de Acomodacação")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Descrição")]
        public string DescricaoAcomodacao { get; set; }

        [DisplayName("Data Inicial")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInicial { get; set; }

        [DisplayName("Data Final")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFinal { get; set; }

        [DisplayName("País Acomodação")]
        public int PaisID { get; set; }
        public virtual PaisViewModel PaisAcomodacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo de Cidade")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Cidade Acomodação")]
        public string CidadeAcomodacao { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        [DisplayName("Valor")]
        public double ValorDespesaAcomodacao { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
        public string Status { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [NotMapped]
        public HttpPostedFileBase Imagem { get; set; }
        [ScaffoldColumn(false)]
        public string ImagemMimmeType { get; set; }
    }
}