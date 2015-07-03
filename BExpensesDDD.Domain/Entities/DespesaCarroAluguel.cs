using System;
namespace BExpensesDDD.Domain.Entities
{
    public class DespesaCarroAluguel
    {
        public int DespesaCarroAluguelID { get; set; }
        public int DespesaPrincipalID { get; set; }
        public virtual DespesaPrincipal DespesaPrincipal { get; set; }
        public string Descricao { get; set; }
        public bool VeiculoCompartilhado { get; set; }
        public string CompartilhadoCom { get; set; }
        public string AgenciaAluguel { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int DiasExtras { get; set; }
        public double ValorDespesaCarroAluguel { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}
