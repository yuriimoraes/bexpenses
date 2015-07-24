using System;
using System.Collections.Generic;
namespace BExpensesDDD.Domain.Entities
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string NomeBanco { get; set; }
        public string NumeroConta { get; set; }
        public string AgenciaConta { get; set; }
        public string CodigoFornecedorSAP { get; set; }
        public bool Administrador { get; set; }
        public bool Aprovador { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int Aprovador1ID { get; set; }
       // public virtual Pessoa Aprovador1 { get; set; }
        public int Aprovador2ID { get; set; }
       // public virtual Pessoa Aprovador2 { get; set; }
        public int CentroCustoID { get; set; }
        public virtual CentroCusto CentroCusto { get; set; }

        public virtual IEnumerable<SolicitacaoViagem> SolicitacoesViagens { get; set; }
        public virtual IEnumerable<RespostaSolicitacaoReembolso> RespostasSolicitacoesReembolsos { get; set; }
        public virtual IEnumerable<RespostaSolicitacaoViagem> RespostasSolicitacoesViagens { get; set; }

        public bool PessoaAprovador(Pessoa pessoa)
        {
            return pessoa.Aprovador;
        }

        public bool PessoaAdministrador(Pessoa pessoa)
        {
            return pessoa.Administrador;
        }

    }
}
