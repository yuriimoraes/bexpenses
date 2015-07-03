using System;
namespace BExpensesDDD.Domain.Entities
{
    public class DespesaCarro
    {
        public int DespesaCarroID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipal DespesaPrincipal { get; set; }
        public int TipoDespesaCarroID { get; set; }
        public virtual TipoDespesaCarro TipoDespesaCarro { get; set; }
        public string DescricaoDespesa { get; set; }
        public double ValorDespesaCarro { get; set; }
        public string Observacao { get; set; }
        public double KmRodado { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
