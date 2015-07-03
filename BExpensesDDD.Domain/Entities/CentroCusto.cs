using System;
using System.Collections.Generic;
namespace BExpensesDDD.Domain.Entities
{
    public class CentroCusto
    {
        public int CentroCustoID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        //Pessoa que atualizou
        public string UsuarioAtualizacao { get; set; }
        public string Observacao { get; set; }
        public virtual IEnumerable<Pessoa> Pessoas { get; set; }


    }
}
