
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class DespesaCarroService : ServiceBase<DespesaCarro>, IDespesaCarroService
    {
        private readonly IRepositoryDespesaCarro _repositoryDespesaCarro;

        public DespesaCarroService(IRepositoryDespesaCarro repositoryDespesaCarro)
            : base(repositoryDespesaCarro)
        {
            _repositoryDespesaCarro = repositoryDespesaCarro;
        }
    }
}
