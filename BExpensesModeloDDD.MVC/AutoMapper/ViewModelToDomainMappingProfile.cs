using AutoMapper;
using BExpensesDDD.Domain.Entities;
using BExpensesModeloDDD.MVC.ViewModels;

namespace BExpensesModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile 
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMapping"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<CentroCusto, CentroCustoViewModel>();
            Mapper.CreateMap<ClasseViagem, ClasseViagemViewModel>();
            Mapper.CreateMap<DespesaAcomodacao, DespesaAcomodacaoViewModel>();
            Mapper.CreateMap<DespesaCarroAluguel, DespesaCarroAluguelViewModel>();
            Mapper.CreateMap<DespesaCarro, DespesaCarroViewModel>();
            Mapper.CreateMap<DespesaOutro, DespesaOutroViewModel>();
            Mapper.CreateMap<DespesaPerDiem, DespesaPerDiemViewModel>();
            Mapper.CreateMap<DespesaPrincipal, DespesaPrincipalViewModel>();
            Mapper.CreateMap<DespesaTransporte, DespesaTransporteViewModel>();
            Mapper.CreateMap<DespesaViagem, DespesaViagemViewModel>();
            Mapper.CreateMap<Moeda, MoedaViewModel>();
            Mapper.CreateMap<Pais, PaisViewModel>();
            Mapper.CreateMap<ParametrosSistema, ParametrosSistemaViewModel>();
            Mapper.CreateMap<Pessoa, PessoaViewModel>();
            Mapper.CreateMap<RespostaSolicitacao, RespostaSolicitacaoViewModel>();
            Mapper.CreateMap<SolicitacaoReembolso, SolicitacaoReembolsoViewModel>();
            Mapper.CreateMap<SolicitacaoViagem, SolicitacaoViagemViewModel>();
            Mapper.CreateMap<TaxaCambio, TaxaCambioViewModel>();
            Mapper.CreateMap<TipoAcomodacao, TipoAcomodacaoViewModel>();
            Mapper.CreateMap<TipoDespesaCarro, TipoDespesaCarroViewModel>();
            Mapper.CreateMap<TipoViagem, TipoViagemViewModel>();
        }
    }
}