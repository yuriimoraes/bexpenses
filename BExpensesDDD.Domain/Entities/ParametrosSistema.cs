using System;
namespace BExpensesDDD.Domain.Entities
{
    public class ParametrosSistema
    {
        public int ParametrosSistemaID { get; set; }
        public string Campo { get; set; }
        public double Valor { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
