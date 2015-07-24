

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Repositories;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class RespostaSolicitacaoViagemService : ServiceBase<RespostaSolicitacaoViagem>, IRespostaSolicitacaoViagemService
    {
        private readonly IRepositoryRespostaSolicitacaoViagem _repositoryRespostaSolicitacaoViagem;

        public RespostaSolicitacaoViagemService(IRepositoryRespostaSolicitacaoViagem repositoryRespostaSolicitacaoViagem)
            : base(repositoryRespostaSolicitacaoViagem)
        {
            _repositoryRespostaSolicitacaoViagem = repositoryRespostaSolicitacaoViagem;
        }
    }
}
