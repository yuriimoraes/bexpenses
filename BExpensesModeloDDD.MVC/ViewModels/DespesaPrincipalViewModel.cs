

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BExpensesModeloDDD.MVC.ViewModels
{
    public class DespesaPrincipalViewModel
    {
        [Key]
        public int DespesaPrincipalID { get; set; }
        public int SolicitacaoViagemID { get; set; }
        public virtual SolicitacaoViagemViewModel SolicitacaoViagem { get; set; }
        public int MoedaPadraoID { get; set; }
        public virtual MoedaViewModel MoedaPadrao { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999999")]
        [DisplayName("Valor")]
        public double ValorTotal { get; set; }
        [Editable(false, AllowInitialValue = false)]
        [DisplayName("Data Atualização")]
        public DateTime DataAtualizacao { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }

        public virtual IEnumerable<DespesaAcomodacaoViewModel> DespesasAcomodacoes { get; set; }
        public virtual IEnumerable<DespesaCarroViewModel> DespesasCarros { get; set; }
        public virtual IEnumerable<DespesaCarroAluguelViewModel> DespesasCarrosAluguel { get; set; }
        public virtual IEnumerable<DespesaOutroViewModel> DespesasOutros { get; set; }
        public virtual IEnumerable<DespesaPerDiemViewModel> DespesasPerDiem { get; set; }
        public virtual IEnumerable<DespesaTransporteViewModel> DespesasTransportes { get; set; }
        public virtual IEnumerable<DespesaViagemViewModel> DespesasViagens { get; set; }
        public virtual IEnumerable<TaxaCambioViewModel> TaxasCambio { get; set; }
        public virtual IEnumerable<SolicitacaoReembolsoViewModel> SolicitacoesReembolsos { get; set; }

    }
}