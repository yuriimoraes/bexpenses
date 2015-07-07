

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class RespostaSolicitacaoService : ServiceBase<RespostaSolicitacao>, IRespostaSolicitacaoService
    {
        private readonly IRepositoryRespostaSolicitacao _repositoryRespostaSolicitacao;

        public RespostaSolicitacaoService(IRepositoryRespostaSolicitacao repositoryRespostaSolicitacao)
            : base(repositoryRespostaSolicitacao) 
        {
            _repositoryRespostaSolicitacao = repositoryRespostaSolicitacao;
        }
    }
}
