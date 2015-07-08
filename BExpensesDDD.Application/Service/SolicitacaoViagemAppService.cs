

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class SolicitacaoViagemAppService : AppServiceBase<SolicitacaoViagem>, ISolicitacaoViagemAppService
    {
        private readonly ISolicitacaoViagemService _solicitacaoViagem;

        public SolicitacaoViagemAppService(ISolicitacaoViagemService solicitacaoViagem)
            :base(solicitacaoViagem)
        {
            _solicitacaoViagem = solicitacaoViagem;
        }
    }
}
