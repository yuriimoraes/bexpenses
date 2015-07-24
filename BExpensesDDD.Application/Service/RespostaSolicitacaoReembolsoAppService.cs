

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class RespostaSolicitacaoReembolsoAppService : AppServiceBase<RespostaSolicitacaoReembolso>, IRespostaSolicitacaoReembolsoAppService
    {
        private readonly IRespostaSolicitacaoReembolsoService _respostaSolicitacao;

        public RespostaSolicitacaoReembolsoAppService(IRespostaSolicitacaoReembolsoService respostaSolicitacao)
            : base(respostaSolicitacao)
        {
            _respostaSolicitacao = respostaSolicitacao;
        }
    }
}
