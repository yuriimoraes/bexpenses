
using System;
namespace BExpensesDDD.Domain.Entities
{
    public class DespesaOutro
    {
        public int DespesaOutroID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipal DespesaPrincipal { get; set; }
        public string DescricaoGeral { get; set; }
        public double ValorDespesaOutro { get; set; }
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public byte[] Imagem { get; set; }
    }
}
