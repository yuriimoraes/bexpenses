

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class SolicitacaoViagemViewModel
    {
        [Key]
        public int SolicitacaoViagemID { get; set; }
        public int PessoaRecebeID { get; set; }
        public virtual PessoaViewModel PessoaRecebe { get; set; }
        public int PessoaSolicitanteID { get; set; }
        public virtual PessoaViewModel PessoaSolicitante { get; set; }
        public int RespostaSolicitacaoID { get; set; }
        public virtual RespostaSolicitacaoViewModel RespostaSolicitacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string DescricaoViagem { get; set; }
        
        [Required(ErrorMessage = "Adiantamento?")]
        public bool Adiantamento { get; set; }
        
        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","9999999999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        public double ValorAdiantamento { get; set; }
        public int PaisOrigemID { get; set; }
        public virtual PaisViewModel PaisOrigem { get; set; }
        
        [Required(ErrorMessage = "Preencha a Cidade de Origem")]
        public string CidadeOrigem { get; set; }
        public int PaisDestinoID { get; set; }
        public virtual PaisViewModel PaisDestino { get; set; }
        
        [Required(ErrorMessage = "Preencha a Cidade de Destino")]
        public string CidadeDestino { get; set; }
        public DateTime DataViagemIncial { get; set; }
        public DateTime DataViagemFinal { get; set; }
        public string Status { get; set; }

        public virtual IEnumerable<DespesaPrincipalViewModel> DespesasPrincipais { get; set; }
        public virtual IEnumerable<DespesaPerDiemViewModel> DespesasPerDiem { get; set; }
    }
}