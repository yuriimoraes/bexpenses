using AutoMapper;
using BExpensesDDD.Domain.Entities;
using BExpensesModeloDDD.MVC.ViewModels;


namespace BExpensesModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName 
        {
            get { return "ViewModelToDomainMapping"; }
        }
        protected override void Configure() 
        {
            Mapper.CreateMap<CentroCustoViewModel, CentroCusto>();
            Mapper.CreateMap<ClasseViagemViewModel, ClasseViagem>();
            Mapper.CreateMap<DespesaAcomodacaoViewModel, DespesaAcomodacao>();
            Mapper.CreateMap<DespesaCarroAluguelViewModel, DespesaCarroAluguel>();
            Mapper.CreateMap<DespesaCarroViewModel, DespesaCarro>();
            Mapper.CreateMap<DespesaOutroViewModel, DespesaOutro>();
            Mapper.CreateMap<DespesaPerDiemViewModel, DespesaPerDiem>();
            Mapper.CreateMap<DespesaPrincipalViewModel, DespesaPrincipal>();
            Mapper.CreateMap<DespesaTransporteViewModel, DespesaTransporte>();
            Mapper.CreateMap<DespesaViagemViewModel, DespesaViagem>();
            Mapper.CreateMap<MoedaViewModel, Moeda>();
            Mapper.CreateMap<PaisViewModel, Pais>();
            Mapper.CreateMap<ParametrosSistemaViewModel, ParametrosSistema>();
            Mapper.CreateMap<PessoaViewModel, Pessoa>();
            Mapper.CreateMap<RespostaSolicitacaoReembolsoViewModel, RespostaSolicitacaoReembolso>();
            Mapper.CreateMap<RespostaSolicitacaoViagemViewModel, RespostaSolicitacaoViagem>();
            Mapper.CreateMap<SolicitacaoReembolsoViewModel, SolicitacaoReembolso>();
            Mapper.CreateMap<SolicitacaoViagemViewModel, SolicitacaoViagem>();
            Mapper.CreateMap<TaxaCambioViewModel, TaxaCambio>();
            Mapper.CreateMap<TipoAcomodacaoViewModel, TipoAcomodacao>();
            Mapper.CreateMap<TipoDespesaCarroViewModel, TipoDespesaCarro>();
            Mapper.CreateMap<TipoViagemViewModel, TipoViagem>();
        }
    }
}