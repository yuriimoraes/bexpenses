﻿

using System;
using System.ComponentModel.DataAnnotations;
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
        public string DescricaoDespesa { get; set; }


        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        public double ValorDespesaCarro { get; set; }
        public string Observacao { get; set; }
        public double KmRodado { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}