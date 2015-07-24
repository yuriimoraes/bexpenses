
using System;
namespace BExpensesDDD.Domain.Entities
{
    public class DespesaAcomodacao
    {
        public int DespesaAcomodacaoID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipal DespesaPrincipal { get; set; }
        public int TipoAcomodacaoID { get; set; }
        public virtual TipoAcomodacao TipoAcomodacao { get; set; }
        public string DescricaoAcomodacao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int PaisAcomodacaoID { get; set; }
        public virtual Pais PaisAcomodacao { get; set; }
        public string CidadeAcomodacao { get; set; }
        public double ValorDespesaAcomodacao { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public byte[] Imagem { get; set; }
        public string ImagemMimmeType { get; set; }
    }
}
