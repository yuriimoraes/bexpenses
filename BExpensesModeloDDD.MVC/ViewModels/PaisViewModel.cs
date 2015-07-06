using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class PaisViewModel
    {   
        [Key]
        public int PaisID { get; set; }


        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string NomePais { get; set; }

        public virtual IEnumerable<DespesaAcomodacaoViewModel> DespesasAcomodacoes { get; set; }
        public virtual IEnumerable<SolicitacaoViagemViewModel> SolicitacaoViagens { get; set; }
    }
}