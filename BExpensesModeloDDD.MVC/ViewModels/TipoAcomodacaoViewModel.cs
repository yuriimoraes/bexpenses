using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class TipoAcomodacaoViewModel
    {
        [Key]
        public int TipoAcomodacaoID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string DescricaoTipoAcomodacao { get; set; }
        public virtual IEnumerable<DespesaAcomodacaoViewModel> DespesasAcomodacoes { get; set; }
    }
}