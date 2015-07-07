
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class DespesaViagemService : ServiceBase<DespesaViagem>, IDespesaViagemService
    {
        private readonly IRepositoryDespesaViagem _repositoryDespesaViagem;

        public DespesaViagemService(IRepositoryDespesaViagem repositoryDespesaViagem)
            :base(repositoryDespesaViagem)
        {
            _repositoryDespesaViagem = repositoryDespesaViagem;
        }
    }
}
