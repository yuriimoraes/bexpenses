using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class PessoaViewModel
    {   
        [Key]
        public int PessoaID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Login")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(11, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Telefone 1")]
        public string Telefone1 { get; set; }

        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(11, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Telefone 2")]
        public string Telefone2 { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Banco")]
        [MaxLength(80, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Nome Banco")]
        public string NomeBanco { get; set; }

        [Required(ErrorMessage = "Preencha o campo Numero Conta Banco")]
        [MaxLength(80, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Numero Conta")]
        public string NumeroConta { get; set; }

        [Required(ErrorMessage = "Preencha o campo Agência")]
        [MaxLength(80, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Agencia Conta")]
        public string AgenciaConta { get; set; }

        [Required(ErrorMessage = "Preencha o campo Código Fornecedor")]
        [MaxLength(6, ErrorMessage = "Digite {0} caracteres")]
        [MinLength(6, ErrorMessage = "Digite {0} caracteres")]
        [DisplayName("Código Fornecedor SAP ")]
        public string CodigoFornecedorSAP { get; set; }
        public bool Administrador { get; set; }
        public bool Aprovador { get; set; }

        [DisplayName("Data Atualização")]
        public DateTime DataAtualizacao { get; set; }
        
        [DisplayName("Aprovador 1")]
        public int Aprovador1ID { get; set; }

        public virtual PessoaViewModel Aprovador1 { get; set; }
        [DisplayName("Aprovador 2")]
        public int Aprovador2ID { get; set; }

        public virtual PessoaViewModel Aprovador2 { get; set; }
        [DisplayName("Centro Custo")]
        public int CentroCustoID { get; set; }
        public virtual CentroCustoViewModel CentroCusto { get; set; }

        public virtual IEnumerable<SolicitacaoViagemViewModel> SolicitacoesViagens { get; set; }
        public virtual IEnumerable<RespostaSolicitacaoViewModel> RespostasSolicitacoes { get; set; }
    }
}