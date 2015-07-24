

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class RespostaSolicitacaoViagemAppService : AppServiceBase<RespostaSolicitacaoViagem>, IRespostaSolicitacaoViagemAppService
    {
        private readonly IRespostaSolicitacaoViagemService _respostaSolicitacaoViagem;

        public RespostaSolicitacaoViagemAppService(IRespostaSolicitacaoViagemService respostaSolicitacaoViagem)
            : base(respostaSolicitacaoViagem)
        {
            _respostaSolicitacaoViagem = respostaSolicitacaoViagem;
        }
    }
}
