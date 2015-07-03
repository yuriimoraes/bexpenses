
using System;
namespace BExpensesDDD.Domain.Entities
{
    public class TaxaCambio
    {
        public int TaxaCambioID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipal DespesaPrincipal { get; set; }
        public int FatorDe { get; set; }
        public int MoedaDeID { get; set; }
        public virtual Moeda De { get; set; }
        public double cotPreco { get; set; }
        public int FatorPara { get; set; }
        public int MoedaParaID { get; set; }
        public virtual Moeda Para { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
