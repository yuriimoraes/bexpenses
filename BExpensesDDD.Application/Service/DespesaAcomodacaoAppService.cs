

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class DespesaAcomodacaoAppService : AppServiceBase<DespesaAcomodacao>, IDespesaAcomodacaoAppService
    {
        private readonly IDespesaAcomodacaoService _despesaAcomodacao;

        public DespesaAcomodacaoAppService(IDespesaAcomodacaoService despesaAcomodacao)
            : base(despesaAcomodacao)
        {
            _despesaAcomodacao = despesaAcomodacao;
        }
    }
}
