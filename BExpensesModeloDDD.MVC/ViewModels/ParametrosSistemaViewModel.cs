using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class ParametrosSistemaViewModel
    {
        [Key]
        public int ParametrosSistemaID { get; set; }
        [Required(ErrorMessage = "Preencha o campo Campo")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Campo { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "Preencha a Data Inicial")]
        [DisplayName("Data Inicial")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInicial { get; set; }
        [Required(ErrorMessage = "Preencha a Data Final")]
        [DisplayName("Data Final")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFinal { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}