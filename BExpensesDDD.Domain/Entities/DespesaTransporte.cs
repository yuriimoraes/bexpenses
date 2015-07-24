using System;
namespace BExpensesDDD.Domain.Entities
{
    public class DespesaTransporte
    {
        public int DespesaTransporteID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipal DespesaPrincipal { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double ValorTransporte { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public byte[] Imagem { get; set; }
    }
}
