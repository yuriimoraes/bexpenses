

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class RespostaSolicitacaoReembolsoService : ServiceBase<RespostaSolicitacaoReembolso>, IRespostaSolicitacaoReembolsoService
    {
        private readonly IRepositoryRespostaSolicitacao _repositoryRespostaSolicitacao;

        public RespostaSolicitacaoReembolsoService(IRepositoryRespostaSolicitacao repositoryRespostaSolicitacao)
            : base(repositoryRespostaSolicitacao) 
        {
            _repositoryRespostaSolicitacao = repositoryRespostaSolicitacao;
        }
    }
}
