using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class ClasseViagemViewModel
    {
        [Key]
        public int ClasseViagemID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição Viagem")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Descrição")]
        public string DescricaoViagem { get; set; }
        public virtual IEnumerable<DespesaViagemViewModel> DespesasViagens { get; set; }
    }
}