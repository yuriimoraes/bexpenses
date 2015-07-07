

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;
namespace BExpensesDDD.Domain.Services
{
    public class DespesaCarroAluguelService : ServiceBase<DespesaCarroAluguel>, IDespesaCarroAluguelService
    {
        private readonly IRepositoryDespesaCarroAluguel _repositoryDespesaCarroAluguel;

        public DespesaCarroAluguelService(IRepositoryDespesaCarroAluguel repositoryDespesaCarroAluguel)
            :base(repositoryDespesaCarroAluguel)
        {
            _repositoryDespesaCarroAluguel = repositoryDespesaCarroAluguel;
        }
    }
}
