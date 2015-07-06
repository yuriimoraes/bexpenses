using System;
using System.Collections.Generic;
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
        public int FatorDe { get; set; }
        public int MoedaDeID { get; set; }
        public virtual MoedaViewModel De { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha a cotação")]
        public double cotPreco { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o fator Para")]
        public int FatorPara { get; set; }
        public int MoedaParaID { get; set; }
        public virtual MoedaViewModel Para { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }


        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}