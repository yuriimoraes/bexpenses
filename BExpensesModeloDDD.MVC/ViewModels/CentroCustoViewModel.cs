using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class CentroCustoViewModel
    {
        [Key]
        public int CentroCustoID { get; set; }

        
        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        
        //Pessoa que atualizou
        [ScaffoldColumn(false)]
        public string UsuarioAtualizacao { get; set; }

        [DisplayName("Observação")]
        public string Observacao { get; set; }
        public virtual IEnumerable<PessoaViewModel> Pessoas { get; set; }
    }
}