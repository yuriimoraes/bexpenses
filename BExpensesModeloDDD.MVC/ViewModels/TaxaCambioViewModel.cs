using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class TaxaCambioViewModel
    {
        [Key]
        public int TaxaCambioID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipalViewModel DespesaPrincipal { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o fator De")]
        [DisplayName("Fator De")]
        public int FatorDe { get; set; }
        [DisplayName("Moeda De")]
        public int MoedaDeID { get; set; }
        public virtual MoedaViewModel De { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha a cotação")]
        [DisplayName("Cotação Preço")]
        public double cotPreco { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o fator Para")]
        [DisplayName("Fator Para")]
        public int FatorPara { get; set; }
        [DisplayName("Moeda Para ")]
        public int MoedaParaID { get; set; }
        public virtual MoedaViewModel Para { get; set; }
        [DisplayName("Data Inicial")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInicial { get; set; }
        [DisplayName("Data Final")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFinal { get; set; }


        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}