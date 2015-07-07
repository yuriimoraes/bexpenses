

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class SolicitacaoReembolsoService : ServiceBase<SolicitacaoReembolso>, ISolicitacaoReembolsoService
    {
        private readonly IRepositorySolicitacaoReembolso _repositorySolicitacaoReembolso;

        public SolicitacaoReembolsoService(IRepositorySolicitacaoReembolso repositorySolicitacaoReembolso)
            :base(repositorySolicitacaoReembolso) 
        {
            _repositorySolicitacaoReembolso = repositorySolicitacaoReembolso;
        }

        
    }
}
