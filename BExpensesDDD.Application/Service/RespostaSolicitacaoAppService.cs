

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class RespostaSolicitacaoAppService : AppServiceBase<RespostaSolicitacao>, IRespostaSolicitacaoAppService
    {
        private readonly IRespostaSolicitacaoService _respostaSolicitacao;

        public RespostaSolicitacaoAppService(IRespostaSolicitacaoService respostaSolicitacao)
            : base(respostaSolicitacao)
        {
            _respostaSolicitacao = respostaSolicitacao;
        }
    }
}
