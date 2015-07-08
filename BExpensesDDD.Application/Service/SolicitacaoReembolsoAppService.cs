

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class SolicitacaoReembolsoAppService : AppServiceBase<SolicitacaoReembolso>, ISolicitacaoReembolsoAppService
    {
        private readonly ISolicitacaoReembolsoService _solicitacaoReembolso;

        public SolicitacaoReembolsoAppService(ISolicitacaoReembolsoService solicitacaoReembolso)
            :base(solicitacaoReembolso)
        {
            _solicitacaoReembolso = solicitacaoReembolso;
        }

    }
}
