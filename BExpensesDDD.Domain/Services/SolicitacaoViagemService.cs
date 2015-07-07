
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class SolicitacaoViagemService : ServiceBase<SolicitacaoViagem>, ISolicitacaoViagemService
    {
        private readonly IRepositorySolicitacaoViagem _repositorySolicitacaoViagem;

        public SolicitacaoViagemService(IRepositorySolicitacaoViagem repositorySolicitacaoViagem)
            : base(repositorySolicitacaoViagem)
        {
            _repositorySolicitacaoViagem = repositorySolicitacaoViagem;
        }
    }
}
