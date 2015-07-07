

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class TipoDespesaCarroService : ServiceBase<TipoDespesaCarro>, ITipoDespesaCarroService
    {
        private readonly IRepositoryTipoDespesaCarro _repositoryTipoDespesaCarro;

        public TipoDespesaCarroService(IRepositoryTipoDespesaCarro repositoryTipoDespesaCarro)
            :base(repositoryTipoDespesaCarro)
        {
            _repositoryTipoDespesaCarro = repositoryTipoDespesaCarro;
        }
        
    }
}
